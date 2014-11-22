using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged.Core
{
    internal static class Ensure
    {
        public static void Success(int result)
        {
            if (result == (int)D2fErrorCode.D2FS_SUCCESS)
            {
                return;
            }

            HandleError(result);
        }

        public static void BooleanResult(int result)
        {
            if (result == (int)D2fErrorCode.D2FS_YES || result == (int)D2fErrorCode.D2FS_NO)
            {
                return;
            }

            HandleError(result);
        }

        private static void HandleError(int result)
        {
            throw new NdapiException("An error ocurred", (D2fErrorCode)result); // TODO: improve error handling
        }
    }
}
