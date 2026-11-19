using System;
using System.Collections.Generic;
using System.Linq;

namespace Ndapi.Core;

internal static partial class ConstantConverter
{
    public static int GetValue(Enum propertyId)
    {
        return GetValue((NdapiConstant)propertyId);
    }

    public static int GetValue(int propertyId)
    {
        return GetValue((NdapiConstant)propertyId);
    }

    private static int GetValue(NdapiConstant property)
    {
        return NdapiContext.BuilderVersion.MajorVersion switch
        {
            6 => Forms6Constants[property],
            12 => Forms12Constants[property],
            14 => Forms14Constants[property],
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };
    }

    public static bool IsPropertySupportedByBuilderVersion(Enum propertyId)
    {
        return IsPropertySupportedByBuilderVersion((NdapiConstant)propertyId);
    }

    public static bool IsPropertySupportedByBuilderVersion(int propertyId)
    {
        return IsPropertySupportedByBuilderVersion((NdapiConstant)propertyId);
    }

    private static bool IsPropertySupportedByBuilderVersion(NdapiConstant property)
    {
        return NdapiContext.BuilderVersion.MajorVersion switch
        {
            6 => Forms6Constants.ContainsKey(property),
            12 => Forms12Constants.ContainsKey(property),
            14 => Forms14Constants.ContainsKey(property),
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };
    }

    /// <summary>
    /// Gets the object property ids (D2FP_*) defined by the running Forms Builder version, ordered by their native value.
    /// Pseudo constants (D2FP_MIN, D2FP_MAX, D2FP_NONE, D2FP_UNDEFINED and the D2FP_TYP_* property types) are excluded.
    /// </summary>
    public static IReadOnlyList<NdapiConstant> GetSupportedProperties()
    {
        var constants = NdapiContext.BuilderVersion.MajorVersion switch
        {
            6 => Forms6Constants,
            12 => Forms12Constants,
            14 => Forms14Constants,
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };

        return constants
            .Where(c => IsObjectProperty(c.Key))
            .OrderBy(c => c.Value)
            .Select(c => c.Key)
            .ToList();
    }

    private static bool IsObjectProperty(NdapiConstant constant)
    {
        var name = constant.ToString();
        return name.StartsWith("D2FP_", StringComparison.Ordinal)
               && !name.StartsWith("D2FP_TYP_", StringComparison.Ordinal)
               && constant is not (NdapiConstant.D2FP_MIN or NdapiConstant.D2FP_MAX or NdapiConstant.D2FP_NONE
                   or NdapiConstant.D2FP_UNDEFINED);
    }
}
