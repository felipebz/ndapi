using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Ndapi.Core.Handles
{
    internal abstract class SafeHandleBase : SafeHandle
    {
        protected SafeHandleBase() : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid => handle == IntPtr.Zero;

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected abstract bool ReleaseHandleImpl();

        protected override sealed bool ReleaseHandle() => ReleaseHandleImpl();
    }
}
