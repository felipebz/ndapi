using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NdapiSourceGenerator;

/// <summary>
/// Implements the partial properties marked with <c>[Property(NdapiConstant.X)]</c> through the NdapiObject accessors
/// of that Forms property.
/// </summary>
[Generator]
public sealed class NdapiPropertyGenerator : IIncrementalGenerator
{
    private const string PropertyAttribute = "Ndapi.Core.PropertyAttribute";

    private static readonly SymbolDisplayFormat TypeFormat =
        SymbolDisplayFormat.FullyQualifiedFormat.AddMiscellaneousOptions(
            SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Only strings and other value-equatable data leave the transform, so unchanged properties stay cached
        // across edits.
        var properties = context.SyntaxProvider.ForAttributeWithMetadataName(
            PropertyAttribute,
            static (node, _) => node is PropertyDeclarationSyntax,
            static (attributeContext, cancellationToken) => Analyze(attributeContext, cancellationToken));

        context.RegisterSourceOutput(
            properties.Where(static p => p.Diagnostic is not null).Select(static (p, _) => p.Diagnostic!),
            static (output, diagnostic) => output.ReportDiagnostic(diagnostic.Create()));

        // a class can be split across files: its properties are grouped so each class gets one generated file
        var classes = properties
            .Where(static p => p.Property is not null)
            .Collect()
            .SelectMany(static (all, _) => all
                .GroupBy(static p => p.Class!)
                .Select(static group => new ClassModel(group.Key,
                    new EquatableArray<PropertyModel>(group.Select(static p => p.Property!).ToImmutableArray()))));

        context.RegisterSourceOutput(classes,
            static (output, model) => output.AddSource(model.Class.HintName, Render(model)));
    }

    private static PropertyResult Analyze(GeneratorAttributeSyntaxContext context, CancellationToken cancellationToken)
    {
        var declaration = (PropertyDeclarationSyntax)context.TargetNode;
        var property = (IPropertySymbol)context.TargetSymbol;
        var location = declaration.Identifier.GetLocation();

        if (!declaration.Modifiers.Any(SyntaxKind.PartialKeyword))
        {
            return PropertyResult.Error(Diagnostics.NotPartial, location, property.Name);
        }

        // an implementing declaration written by hand needs nothing generated
        if (!property.IsPartialDefinition || property.PartialImplementationPart is not null)
        {
            return PropertyResult.Nothing;
        }

        if (property.SetMethod is { IsInitOnly: true })
        {
            return PropertyResult.Error(Diagnostics.InitAccessor, location, property.Name);
        }

        // a malformed attribute is already a compiler error
        if (GetConstant(context, cancellationToken) is not { } constant)
        {
            return PropertyResult.Nothing;
        }

        if (GetAccessors(property.Type, constant) is not var (getter, setter))
        {
            return PropertyResult.Error(Diagnostics.UnsupportedType, location, property.Name,
                property.Type.ToDisplayString());
        }

        if (property.SetMethod is not null && setter is null)
        {
            return PropertyResult.Error(Diagnostics.ListWithSetter, location, property.Name);
        }

        var accessors = declaration.AccessorList!.Accessors;
        var model = new PropertyModel(
            declaration.Modifiers.ToString(),
            property.Type.ToDisplayString(TypeFormat),
            property.Name,
            AccessorModifiers(accessors, SyntaxKind.GetAccessorDeclaration),
            getter,
            property.SetMethod is null ? null : AccessorModifiers(accessors, SyntaxKind.SetAccessorDeclaration),
            property.SetMethod is null ? null : setter);

        return new PropertyResult(GetClass(property.ContainingType), model, null);
    }

    private static string AccessorModifiers(SyntaxList<AccessorDeclarationSyntax> accessors, SyntaxKind kind) =>
        accessors.FirstOrDefault(a => a.IsKind(kind))?.Modifiers.ToString() ?? "";

    /// <summary>
    /// The NdapiConstant member the attribute names, resolved through the semantic model so aliases and
    /// <c>using static</c> work.
    /// </summary>
    private static string? GetConstant(GeneratorAttributeSyntaxContext context, CancellationToken cancellationToken)
    {
        var attribute = context.Attributes[0];
        if (attribute.ApplicationSyntaxReference?.GetSyntax(cancellationToken) is not AttributeSyntax
            {
                ArgumentList.Arguments: { Count: 1 } arguments
            })
        {
            return null;
        }

        return context.SemanticModel.GetSymbolInfo(arguments[0].Expression, cancellationToken).Symbol is IFieldSymbol
        {
            ContainingType.TypeKind: TypeKind.Enum
        } field
            ? $"{field.ContainingType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}.{field.Name}"
            : null;
    }

    private static (string Getter, string? Setter)? GetAccessors(ITypeSymbol type, string constant)
    {
        switch (type.SpecialType)
        {
            case SpecialType.System_String:
                return ($"GetStringProperty({constant})", $"SetStringProperty({constant}, value)");
            case SpecialType.System_Int32:
                return ($"GetNumberProperty({constant})", $"SetNumberProperty({constant}, value)");
            case SpecialType.System_Boolean:
                return ($"GetBooleanProperty({constant})", $"SetBooleanProperty({constant}, value)");
        }

        var bareType = type.WithNullableAnnotation(NullableAnnotation.NotAnnotated)
            .ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

        if (type.TypeKind == TypeKind.Enum)
        {
            return ($"GetNumberProperty<{bareType}>({constant})", $"SetNumberProperty({constant}, value)");
        }

        if (type is not INamedTypeSymbol named)
        {
            return null;
        }

        if (named.OriginalDefinition.ToDisplayString() == "Ndapi.NdapiObjectList<T>")
        {
            var itemType = named.TypeArguments[0].WithNullableAnnotation(NullableAnnotation.NotAnnotated)
                .ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            return ($"GetObjectList<{itemType}>({constant})", null);
        }

        return IsNdapiObject(named)
            ? ($"GetObjectProperty<{bareType}>({constant})", $"SetObjectProperty({constant}, value)")
            : null;
    }

    private static bool IsNdapiObject(INamedTypeSymbol type)
    {
        for (var current = type; current is not null; current = current.BaseType)
        {
            // by name: the declared type carries its nullable annotation (NdapiObject?)
            if (current is { Name: "NdapiObject", ContainingNamespace: { Name: "Ndapi", ContainingNamespace.IsGlobalNamespace: true } })
            {
                return true;
            }
        }

        return false;
    }

    private static ClassInfo GetClass(INamedTypeSymbol type)
    {
        var ns = type.ContainingNamespace.IsGlobalNamespace ? null : type.ContainingNamespace.ToDisplayString();
        var hintName = $"{(ns is null ? "" : ns + ".")}{type.MetadataName.Replace('`', '_')}.g.cs";
        return new ClassInfo(ns, type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat), hintName);
    }

    // \n rather than Environment.NewLine, so the output doesn't depend on the build machine
    private static string Render(ClassModel model)
    {
        var source = new StringBuilder("// <auto-generated/>\n#nullable enable\n\n");
        if (model.Class.Namespace is { } ns)
        {
            source.Append("namespace ").Append(ns).Append(";\n\n");
        }

        source.Append("partial class ").Append(model.Class.Name).Append("\n{\n");
        var first = true;
        foreach (var property in model.Properties)
        {
            if (!first)
            {
                source.Append('\n');
            }

            first = false;
            source.Append("    ").Append(property.Modifiers).Append(' ').Append(property.Type).Append(' ')
                .Append(property.Name).Append("\n    {\n");
            AppendAccessor(source, property.GetterModifiers, "get", property.Getter);
            if (property.Setter is not null)
            {
                AppendAccessor(source, property.SetterModifiers!, "set", property.Setter);
            }

            source.Append("    }\n");
        }

        return source.Append("}\n").ToString();
    }

    private static void AppendAccessor(StringBuilder source, string modifiers, string keyword, string body)
    {
        source.Append("        ");
        if (modifiers.Length > 0)
        {
            source.Append(modifiers).Append(' ');
        }

        source.Append(keyword).Append(" => ").Append(body).Append(";\n");
    }
}
