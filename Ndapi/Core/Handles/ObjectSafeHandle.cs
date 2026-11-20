using System;

namespace Ndapi.Core.Handles;

internal sealed class ObjectSafeHandle : SafeHandleBase
{
    /// <summary>
    /// The native object address, used as identity (object registry, module lookup). Releasing an object handle is
    /// a no-op (the module owns its objects), so reading the address carries none of the risks DangerousGetHandle
    /// guards against.
    /// </summary>
    internal IntPtr Address => handle;

    protected override bool ReleaseHandleImpl()
    {
        return true;
    }
}
