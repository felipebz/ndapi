using Microsoft.CodeAnalysis;

namespace NdapiSourceGenerator;

internal static class Diagnostics
{
    private const string Category = "Ndapi";

    public static readonly DiagnosticDescriptor NotPartial = new("NDAPI001",
        "Property must be partial",
        "Property '{0}' must be declared partial so its Forms property accessors can be generated",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor UnsupportedType = new("NDAPI002",
        "Unsupported property type",
        "Property '{0}' has type '{1}', which no Forms property accessor handles",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor ListWithSetter = new("NDAPI003",
        "Object list property must be get-only",
        "Property '{0}' is an object list, which can only be read",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor InitAccessor = new("NDAPI004",
        "Init accessors are not supported",
        "Property '{0}' must use a set accessor instead of init",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);
}
