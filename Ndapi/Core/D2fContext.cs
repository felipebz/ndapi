using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ndapi.Core;

/// <summary>
/// Context attributes (d2fctxa). Forms allocates the memory it hands over (strings, blobs) through these callbacks, so
/// Ndapi frees that memory with the same allocator.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
internal unsafe struct ContextAttributes
{
    private const int MemoryCallbacks = 2; // the memory callbacks are set

    public int mask_d2fctxa;
    public void* cdata_d2fctxa;
    public delegate* unmanaged[Cdecl]<void*, nuint, void*> d2fmalc_d2fctxa;
    public delegate* unmanaged[Cdecl]<void*, void*, void> d2fmfre_d2fctxa;
    public delegate* unmanaged[Cdecl]<void*, void*, nuint, void*> d2fmrlc_d2fctxa;

    public static ContextAttributes WithMemoryCallbacks() => new()
    {
        mask_d2fctxa = MemoryCallbacks,
        d2fmalc_d2fctxa = &Allocate,
        d2fmfre_d2fctxa = &Free,
        d2fmrlc_d2fctxa = &Reallocate
    };

    // an exception can't unwind into Forms: a failed allocation returns null, as malloc does

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void* Allocate(void* context, nuint size)
    {
        try
        {
            return (void*)Marshal.AllocHGlobal((nint)size);
        }
        catch (OutOfMemoryException)
        {
            return null;
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void* Reallocate(void* context, void* pointer, nuint size)
    {
        try
        {
            return pointer == null
                ? (void*)Marshal.AllocHGlobal((nint)size)
                : (void*)Marshal.ReAllocHGlobal((IntPtr)pointer, (nint)size);
        }
        catch (OutOfMemoryException)
        {
            return null;
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void Free(void* context, void* pointer) => Marshal.FreeHGlobal((IntPtr)pointer);
}
