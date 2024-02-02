using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Ndapi.Core;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate IntPtr Malloc(ref IntPtr context, IntPtr size);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate IntPtr Realloc(ref IntPtr context, IntPtr ptr, IntPtr newsize);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void Free(ref IntPtr context, IntPtr ptr);

[StructLayout(LayoutKind.Sequential)]
internal struct ContextAttributes
{
    public int mask_d2fctxa;
    public IntPtr cdata_d2fctxa;
    public Malloc d2fmalc_d2fctxa;
    public Free d2fmfre_d2fctxa;
    public Realloc d2fmrlc_d2fctxa;
}

[CustomMarshaller(typeof(ContextAttributes), MarshalMode.ManagedToUnmanagedRef, typeof(ContextAttributesMarshaler))]
internal static class ContextAttributesMarshaler
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct ContextAttributesUnmanaged
    {
        public int mask_d2fctxa;
        public IntPtr cdata_d2fctxa;
        public IntPtr d2fmalc_d2fctxa;
        public IntPtr d2fmfre_d2fctxa;
        public IntPtr d2fmrlc_d2fctxa;
    }

    internal static ContextAttributes ConvertToManaged(ContextAttributesUnmanaged unmanaged)
    {
        return new ContextAttributes
        {
            mask_d2fctxa = unmanaged.mask_d2fctxa,
            cdata_d2fctxa = unmanaged.cdata_d2fctxa,
            d2fmalc_d2fctxa = Marshal.GetDelegateForFunctionPointer<Malloc>(unmanaged.d2fmalc_d2fctxa),
            d2fmfre_d2fctxa = Marshal.GetDelegateForFunctionPointer<Free>(unmanaged.d2fmfre_d2fctxa),
            d2fmrlc_d2fctxa = Marshal.GetDelegateForFunctionPointer<Realloc>(unmanaged.d2fmrlc_d2fctxa)
        };
    }

    public static ContextAttributesUnmanaged ConvertToUnmanaged(ContextAttributes managed)
    {
        return new ContextAttributesUnmanaged
        {
            mask_d2fctxa = managed.mask_d2fctxa,
            cdata_d2fctxa = managed.cdata_d2fctxa,
            d2fmalc_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmalc_d2fctxa),
            d2fmfre_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmfre_d2fctxa),
            d2fmrlc_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmrlc_d2fctxa)
        };
    }
}
