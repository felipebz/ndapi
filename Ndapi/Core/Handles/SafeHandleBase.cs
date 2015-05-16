using System;
using System.Runtime.InteropServices;
#if !NETCORE
using System.Runtime.ConstrainedExecution;
#endif

namespace Ndapi.Core.Handles
{
    internal abstract class SafeHandleBase : SafeHandle
    {
        protected SafeHandleBase() : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid => handle == IntPtr.Zero;

#if !NETCORE
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
#endif
        protected abstract bool ReleaseHandleImpl();

        protected override sealed bool ReleaseHandle() => ReleaseHandleImpl();
    }
}
