using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi.Core.Handles
{
    internal class ObjectSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            // TODO: try to figure out a way to do it.
            //var status = NativeMethods.d2fobde_Destroy(NdapiContext.Context, handle);
            //return status == (int)D2fErrorCode.D2FS_SUCCESS;
            return true;
        }
    }
}
