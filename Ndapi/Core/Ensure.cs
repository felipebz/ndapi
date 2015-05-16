using Ndapi.Enums;

namespace Ndapi.Core
{
    internal static class Ensure
    {
        public static void Success(D2fErrorCode result)
        {
            if (result == D2fErrorCode.D2FS_SUCCESS)
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
            throw new NdapiException($"The Forms API returned an error. Error code: {result}");
        }
    }
}
