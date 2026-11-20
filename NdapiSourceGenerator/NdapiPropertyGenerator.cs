using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NdapiSourceGenerator;

[Generator]
public class NdapiPropertyGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => IsCandidateClass(s),
                transform: static (ctx, _) => GetClassWithPartialProperties(ctx))
            .Where(static c => c is not null);

        var compilationAndClasses = context.CompilationProvider.Combine(classDeclarations.Collect());

        context.RegisterSourceOutput(compilationAndClasses, static (spc, source) => GenerateSources(source.Left, source.Right, spc));
    }

    private static bool IsCandidateClass(SyntaxNode node)
    {
        return node is ClassDeclarationSyntax classDecl &&
               classDecl.Members.OfType<PropertyDeclarationSyntax>().Any();
    }

    private static ClassDeclarationSyntax? GetClassWithPartialProperties(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;

        var hasPropertyAttribute = classDecl.Members.OfType<PropertyDeclarationSyntax>().Any(prop =>
            prop.Modifiers.Any(SyntaxKind.PartialKeyword) &&
            prop.AttributeLists.SelectMany(a => a.Attributes).Any(attr => attr.Name.ToString().Contains("Property")));

        return hasPropertyAttribute ? classDecl : null;
    }

    private static void GenerateSources(Compilation compilation, IReadOnlyList<ClassDeclarationSyntax> classes,
        SourceProductionContext context)
    {
        foreach (var classDecl in classes)
        {
            var semanticModel = compilation.GetSemanticModel(classDecl.SyntaxTree);
            if (semanticModel.GetDeclaredSymbol(classDecl, context.CancellationToken) is not { } classSymbol)
                continue;

            var className = classSymbol.Name;
            var sb = new StringBuilder();

            sb.AppendLine($$"""
                            #nullable enable
                            namespace {{classSymbol.ContainingNamespace.ToDisplayString()}};
                            using Ndapi.Core;
                            public partial class {{className}}
                            {
                            """);

            foreach (var propDecl in classDecl.Members.OfType<PropertyDeclarationSyntax>()
                         .Where(p => p.Modifiers.Any(SyntaxKind.PartialKeyword)))
            {
                if (semanticModel.GetDeclaredSymbol(propDecl, context.CancellationToken) is { } propSymbol)
                {
                    AppendProperty(sb, propDecl, propSymbol);
                }
            }

            sb.AppendLine("}");

            context.AddSource($"{className}_NdapiProperties.g.cs", sb.ToString());
        }
    }

    private static void AppendProperty(StringBuilder sb, PropertyDeclarationSyntax propDecl, IPropertySymbol propSymbol)
    {
        var propertyAttr = propSymbol.GetAttributes()
            .FirstOrDefault(a => a.AttributeClass?.Name == "PropertyAttribute");
        if (propertyAttr == null)
            return;

        var constantName = GetPropertyConstantName(propertyAttr);
        if (GetAccessors(propSymbol.Type, constantName) is not { } accessors)
            return; // type not supported

        // declared type, with its nullable annotation (string?, Canvas?)
        var propertyType = propSymbol.Type.ToDisplayString();
        var modifiers = GetModifiers(propDecl, propSymbol);
        var hasSetter = propDecl.AccessorList?.Accessors.Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration) ?? false;
        var setter = propDecl.ExpressionBody == null && hasSetter ? accessors.Setter : null;

        if (IsToxicProperty(constantName) && propSymbol.Type.SpecialType == SpecialType.System_String)
        {
            AppendCachedProperty(sb, modifiers, propertyType, propSymbol.Name, accessors.Getter, setter);
        }
        else
        {
            sb.AppendLine(setter == null
                ? $$"""
                        {{modifiers}} {{propertyType}} {{propSymbol.Name}}
                        {
                            get => {{accessors.Getter}};
                        }
                    """
                : $$"""
                        {{modifiers}} {{propertyType}} {{propSymbol.Name}}
                        {
                            get => {{accessors.Getter}};
                            set => {{setter}};
                        }
                    """);
        }
    }

    private static (string Getter, string? Setter)? GetAccessors(ITypeSymbol type, string constantName)
    {
        var propertyType = type.ToDisplayString();
        // dispatch on the bare type: string? and Canvas? use the same accessors as string and Canvas
        var bareType = type.WithNullableAnnotation(NullableAnnotation.NotAnnotated).ToDisplayString();

        if (bareType == "string")
            return ($"GetStringProperty({constantName})", $"SetStringProperty({constantName}, value)");
        if (propertyType == "int")
            return ($"GetNumberProperty({constantName})", $"SetNumberProperty({constantName}, value)");
        if (propertyType == "bool")
            return ($"GetBooleanProperty({constantName})", $"SetBooleanProperty({constantName}, value)");
        if (type.TypeKind == TypeKind.Enum)
            return ($"GetNumberProperty<{propertyType}>({constantName})", $"SetNumberProperty({constantName}, value)");
        if (type.TypeKind != TypeKind.Class)
            return null;
        if (type.Name != "NdapiObjectList")
            return ($"GetObjectProperty<{bareType}>({constantName})", $"SetObjectProperty({constantName}, value)");

        var itemType = (type as INamedTypeSymbol)?.TypeArguments.FirstOrDefault()?.ToDisplayString();
        return itemType is null ? null : ($"GetObjectList<{itemType}>({constantName})", null);
    }

    private static string GetModifiers(PropertyDeclarationSyntax propDecl, IPropertySymbol propSymbol)
    {
        return string.Join(" ",
            propSymbol.DeclaredAccessibility.ToString().ToLowerInvariant(),
            propSymbol.IsOverride ? "override" : "",
            propSymbol.IsVirtual ? "virtual" : "",
            propSymbol.IsSealed ? "sealed" : "",
            propSymbol.IsStatic ? "static" : "",
            propDecl.Modifiers.Any(SyntaxKind.NewKeyword) ? "new" : "",
            "partial"
        ).Replace("  ", " ").Trim();
    }

    // WARN: Toxic Properties Mitigation
    // Some native properties in the Oracle Forms API related to PL/SQL text extraction
    // cause massive unmanaged memory leaks in pls805.dll/CA60.DLL when read repeatedly.
    // We intercept these specific constants to generate a memoization pattern.
    // This ensures the native C API is called only once per object lifecycle.
    private static bool IsToxicProperty(string constantName)
    {
        return constantName.Contains("D2FP_PGU_TXT") ||
               constantName.Contains("D2FP_TRG_TXT") ||
               constantName.Contains("D2FP_MNU_ITM_CODE");
    }

    private static void AppendCachedProperty(StringBuilder sb, string modifiers, string propertyType,
        string propertyName, string getter, string? setter)
    {
        sb.AppendLine($"    private {propertyType} _cached{propertyName};");
        sb.AppendLine($"    private bool _is{propertyName}Cached;");
        sb.AppendLine();

        sb.AppendLine($"    {modifiers} {propertyType} {propertyName}");
        sb.AppendLine("    {");
        sb.AppendLine("        get");
        sb.AppendLine("        {");
        sb.AppendLine($"            if (_is{propertyName}Cached) return _cached{propertyName};");
        sb.AppendLine($"            _cached{propertyName} = {getter};");
        sb.AppendLine($"            _is{propertyName}Cached = true;");
        sb.AppendLine($"            return _cached{propertyName};");
        sb.AppendLine("        }");

        if (setter != null)
        {
            sb.AppendLine("        set");
            sb.AppendLine("        {");
            sb.AppendLine($"            {setter};");
            sb.AppendLine($"            _cached{propertyName} = value;");
            sb.AppendLine($"            _is{propertyName}Cached = true;");
            sb.AppendLine("        }");
        }

        sb.AppendLine("    }");
    }

    private static string GetPropertyConstantName(AttributeData attributeData)
    {
        var syntaxReference = attributeData.ApplicationSyntaxReference;
        if (syntaxReference == null)
            return "";

        var attributeSyntax = syntaxReference.GetSyntax() as AttributeSyntax;

        var argument = attributeSyntax?.ArgumentList?.Arguments.FirstOrDefault();
        return argument == null ? "" : argument.Expression.ToString();
    }
}
