using Ndapi.Enums;

namespace Ndapi.Core;

internal static class Ensure
{
    public static void Success(D2fErrorCode result)
    {
        var success = (result == D2fErrorCode.D2FS_SUCCESS);
        var shouldIgnoreMissingSubclass = (result == D2fErrorCode.D2FS_MISSINGSUBCLMOD && NdapiContext.IgnoreMissingSubclass);
        var shouldIgnoreMissingLibrary = (result == D2fErrorCode.D2FS_MISSINGLIBMOD && NdapiContext.IgnoreMissingLibrary);

        if (success || shouldIgnoreMissingLibrary || shouldIgnoreMissingSubclass)
        {
            return;
        }

        HandleError(result);
    }

    public static void BooleanResult(D2fErrorCode result)
    {
        if (result == D2fErrorCode.D2FS_YES || result == D2fErrorCode.D2FS_NO)
        {
            return;
        }

        HandleError(result);
    }

    private static void HandleError(D2fErrorCode result)
    {
        throw new NdapiException($"The Forms API returned an error. Error code: {result}", result);
    }
}