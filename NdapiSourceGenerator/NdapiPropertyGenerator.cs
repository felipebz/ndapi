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

        foreach (var prop in classDecl.Members.OfType<PropertyDeclarationSyntax>())
        {
            if (prop.Modifiers.Any(SyntaxKind.PartialKeyword) &&
                prop.AttributeLists.SelectMany(a => a.Attributes)
                    .Any(attr => attr.Name.ToString().Contains("Property")))
            {
                return classDecl;
            }
        }

        return null;
    }

    private static void GenerateSources(Compilation compilation, IReadOnlyList<ClassDeclarationSyntax> classes,
        SourceProductionContext context)
    {
        foreach (var classDecl in classes)
        {
            var semanticModel = compilation.GetSemanticModel(classDecl.SyntaxTree);
            if (semanticModel.GetDeclaredSymbol(classDecl) is not { } classSymbol)
                continue;

            var namespaceName = classSymbol.ContainingNamespace.ToDisplayString();
            var className = classSymbol.Name;
            var sb = new StringBuilder();

            sb.AppendLine($$"""
                            namespace {{namespaceName}};
                            using Ndapi.Core;
                            public partial class {{className}}
                            {
                            """);

            foreach (var propDecl in classDecl.Members.OfType<PropertyDeclarationSyntax>())
            {
                if (!propDecl.Modifiers.Any(SyntaxKind.PartialKeyword))
                    continue;

                var propSymbol = semanticModel.GetDeclaredSymbol(propDecl);
                if (propSymbol == null)
                    continue;

                var propertyAttr = propSymbol.GetAttributes()
                    .FirstOrDefault(a => a.AttributeClass?.Name == "PropertyAttribute");
                if (propertyAttr == null)
                    continue;

                var constantName = GetPropertyConstantName(propertyAttr);
                var propertyType = propSymbol.Type.ToDisplayString();
                var propertyName = propSymbol.Name;

                string getter;
                string? setter;

                if (propertyType == "string")
                {
                    getter = $"GetStringProperty({constantName})";
                    setter = $"SetStringProperty({constantName}, value)";
                }
                else if (propertyType == "int")
                {
                    getter = $"GetNumberProperty({constantName})";
                    setter = $"SetNumberProperty({constantName}, value)";
                }
                else if (propertyType == "bool")
                {
                    getter = $"GetBooleanProperty({constantName})";
                    setter = $"SetBooleanProperty({constantName}, value)";
                }
                else if (propSymbol.Type.TypeKind == TypeKind.Enum)
                {
                    getter = $"GetNumberProperty<{propertyType}>({constantName})";
                    setter = $"SetNumberProperty({constantName}, value)";
                }
                else if (propSymbol.Type.TypeKind == TypeKind.Class)
                {
                    if (propSymbol.Type.Name != "NdapiObjectList")
                    {
                        getter = $"GetObjectProperty<{propertyType}>({constantName})";
                        setter = $"SetObjectProperty({constantName}, value)";
                    }
                    else
                    {
                        var typeArg = (propSymbol.Type as INamedTypeSymbol)?.TypeArguments.FirstOrDefault()
                            ?.ToDisplayString();
                        if (typeArg is null)
                            continue;

                        getter = $"GetObjectList<{typeArg}>({constantName})";
                        setter = null; // Don't generate
                    }
                }
                else
                {
                    continue; // Type not supported
                }

                var modifiers = string.Join(" ",
                    propSymbol.DeclaredAccessibility.ToString().ToLower(),
                    propSymbol.IsOverride ? "override" : "",
                    propSymbol.IsVirtual ? "virtual" : "",
                    propSymbol.IsSealed ? "sealed" : "",
                    propSymbol.IsStatic ? "static" : "",
                    propDecl.Modifiers.Any(SyntaxKind.NewKeyword) ? "new" : "",
                    "partial"
                ).Replace("  ", " ").Trim();

                var hasSetter = propDecl.AccessorList?.Accessors.Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration) ?? false;
                var isExpressionBodied = propDecl.ExpressionBody != null;

                var generateGetterOnly = isExpressionBodied || !hasSetter;

                sb.AppendLine(generateGetterOnly
                    ? $$"""
                            {{modifiers}} {{propertyType}} {{propertyName}}
                            {
                                get => {{getter}};
                            }
                        """
                    : $$"""
                            {{modifiers}} {{propertyType}} {{propertyName}}
                            {
                                get => {{getter}};
                                set => {{setter}};
                            }
                        """);
            }

            sb.AppendLine("}");

            context.AddSource($"{className}_NdapiProperties.g.cs", sb.ToString());
        }
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
