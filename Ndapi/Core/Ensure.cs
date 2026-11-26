using System;
using System.Diagnostics.CodeAnalysis;

using Ndapi.Enums;

namespace Ndapi.Core;

internal static class Ensure
{
    public static void Success(FormsErrorCode result)
    {
        var success = (result == FormsErrorCode.Success);
        var shouldIgnoreMissingSubclass =
            (result == FormsErrorCode.MissingSubclassedModule && NdapiContext.IgnoreMissingSubclass);
        var shouldIgnoreMissingLibrary =
            (result == FormsErrorCode.MissingLibraryModule && NdapiContext.IgnoreMissingLibrary);

        if (success || shouldIgnoreMissingLibrary || shouldIgnoreMissingSubclass)
        {
            return;
        }

        HandleError(result);
    }

    public static void BooleanResult(FormsErrorCode result)
    {
        if (result is FormsErrorCode.Yes or FormsErrorCode.No)
        {
            return;
        }

        HandleError(result);
    }

    [DoesNotReturn]
    private static void HandleError(FormsErrorCode result)
    {
        throw new NdapiException($"The Forms API returned an error. Error code: {result}", result);
    }

    public static void IsValueSupportedByBuilderVersion<T>(NdapiConstant property, T value) where T : struct, Enum
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

    public static void MinimumMajorVersion(int majorVersion, string operation)
    {
        if (NdapiContext.BuilderVersion.MajorVersion < majorVersion)
        {
            throw new NdapiException(
                $"{operation} requires Oracle Forms {majorVersion} or later (running {NdapiContext.BuilderVersion.FullVersion}).");
        }
    }
}
