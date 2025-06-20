using System;

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
            14 => Forms12Constants.ContainsKey(property),
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };
    }
}
