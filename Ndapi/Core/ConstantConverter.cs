using System;

namespace Ndapi.Core;

internal static partial class ConstantConverter
{
    public static int GetValue(Enum propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.BuilderVersion.MajorVersion == 6) ? Forms6Constants[property] : Forms12Constants[property];
    }

    public static int GetValue(int propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.BuilderVersion.MajorVersion == 6) ? Forms6Constants[property] : Forms12Constants[property];
    }

    public static bool HasConstant(Enum propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.BuilderVersion.MajorVersion == 6)
            ? Forms6Constants.ContainsKey(property)
            : Forms12Constants.ContainsKey(property);
    }

    public static bool HasConstant(int propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.BuilderVersion.MajorVersion == 6)
            ? Forms6Constants.ContainsKey(property)
            : Forms12Constants.ContainsKey(property);
    }
}
