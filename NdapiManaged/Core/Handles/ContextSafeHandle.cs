using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged.Core.Handles
{
    internal class ContextSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            var status = NativeMethods.d2fctxde_Destroy(handle);
            return status == (int)D2fErrorCode.D2FS_SUCCESS;
        }
    }
}
