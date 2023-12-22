using Microsoft.Win32.SafeHandles;

namespace Ndapi.Core.Handles
{
    internal abstract class SafeHandleBase : SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeHandleBase() : base(true)
        {
        }

        protected abstract bool ReleaseHandleImpl();

        protected override sealed bool ReleaseHandle() => ReleaseHandleImpl();
    }
}
