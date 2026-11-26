using System;

using Microsoft.Win32.SafeHandles;

namespace Ndapi.Core.Handles;

/// <summary>
/// A Forms object, owned by its module: the handle never frees it, so it isn't finalizable either.
/// </summary>
internal sealed class ObjectSafeHandle() : SafeHandleZeroOrMinusOneIsInvalid(ownsHandle: false)
{
    /// <summary>
    /// Passed for a null object argument (no parent, no value). Only ever passed to Forms, never disposed.
    /// </summary>
    internal static ObjectSafeHandle Null { get; } = new();

    /// <summary>
    /// The native object address, used as identity (object registry, module lookup). The handle owns nothing, so
    /// reading the address carries none of the risks DangerousGetHandle guards against.
    /// </summary>
    internal IntPtr Address => handle;

    protected override bool ReleaseHandle() => true;
}
