using System;

using Ndapi.Enums;

namespace Ndapi.Core;

internal static class Ensure
{
    public static void Success(D2fErrorCode result)
    {
        var success = (result == D2fErrorCode.D2FS_SUCCESS);
        var shouldIgnoreMissingSubclass =
            (result == D2fErrorCode.D2FS_MISSINGSUBCLMOD && NdapiContext.IgnoreMissingSubclass);
        var shouldIgnoreMissingLibrary =
            (result == D2fErrorCode.D2FS_MISSINGLIBMOD && NdapiContext.IgnoreMissingLibrary);

        if (success || shouldIgnoreMissingLibrary || shouldIgnoreMissingSubclass)
        {
            return;
        }

        HandleError(result);
    }

    public static void BooleanResult(D2fErrorCode result)
    {
        if (result is D2fErrorCode.D2FS_YES or D2fErrorCode.D2FS_NO)
        {
            return;
        }

        HandleError(result);
    }

    private static void HandleError(D2fErrorCode result)
    {
        throw new NdapiException($"The Forms API returned an error. Error code: {result}", result);
    }

    public static void IsValueSupportedByBuilderVersion(NdapiConstant property, Enum value)
    {
        if (!ConstantConverter.IsPropertySupportedByBuilderVersion(value))
        {
            throw new NdapiException(
                $"The value {value} is not a valid value for property {property} in the current Oracle Forms version.");
        }
    }

    public static void IsPropertySupportedByBuilderVersion(NdapiConstant property)
    {
        if (!ConstantConverter.IsPropertySupportedByBuilderVersion(property))
        {
            throw new NdapiException($"The property {property} is not supported in the current Oracle Forms version.");
        }
    }
}
