using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;

namespace Ndapi.Core.Handles
{
    internal abstract class SafeHandleBase : SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeHandleBase() : base(true)
        {
        }
        
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected abstract bool ReleaseHandleImpl();

        protected override sealed bool ReleaseHandle() => ReleaseHandleImpl();
    }
}
