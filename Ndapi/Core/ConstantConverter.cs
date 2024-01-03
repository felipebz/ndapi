using System;

namespace Ndapi.Core;

internal static partial class ConstantConverter
{
    public static int GetValue(Enum propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.ProductVersion == 60082201) ? Forms6Constants[property] : Forms12Constants[property];
    }

    public static int GetValue(int propertyId)
    {
        var property = (NdapiConstant)propertyId;
        return (NdapiContext.ProductVersion == 60082201) ? Forms6Constants[property] : Forms12Constants[property];
    }
}
