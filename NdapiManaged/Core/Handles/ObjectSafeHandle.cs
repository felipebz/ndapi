using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged.Core.Handles
{
    internal class ObjectSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            var status = NativeMethods.d2fobde_Destroy(NdapiContext.Context, handle);
            return status == (int)D2fErrorCode.D2FS_SUCCESS;
        }
    }
}
