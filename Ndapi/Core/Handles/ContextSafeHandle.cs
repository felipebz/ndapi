using Microsoft.Win32.SafeHandles;

using Ndapi.Enums;

namespace Ndapi.Core.Handles;

internal sealed class ContextSafeHandle() : SafeHandleZeroOrMinusOneIsInvalid(ownsHandle: true)
{
    protected override bool ReleaseHandle() => NativeMethods.d2fctxde_Destroy(handle) == FormsErrorCode.Success;
}
