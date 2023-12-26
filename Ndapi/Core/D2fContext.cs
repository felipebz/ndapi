using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Ndapi.Core;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate IntPtr D2fMalloc(ref IntPtr context, IntPtr size);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate IntPtr D2fRealloc(ref IntPtr context, IntPtr ptr, IntPtr newsize);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void D2fFree(ref IntPtr context, IntPtr ptr);

[StructLayout(LayoutKind.Sequential)]
internal struct D2fContextAttributes
{
    public int mask_d2fctxa;
    public IntPtr cdata_d2fctxa;
    public D2fMalloc d2fmalc_d2fctxa;
    public D2fFree d2fmfre_d2fctxa;
    public D2fRealloc d2fmrlc_d2fctxa;
}

[CustomMarshaller(typeof(D2fContextAttributes), MarshalMode.ManagedToUnmanagedRef, typeof(D2fContextAttributesMarshaler))]
internal static unsafe class D2fContextAttributesMarshaler
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct D2fContextAttributesUnmanaged
    {
        public int mask_d2fctxa;
        public IntPtr cdata_d2fctxa;
        public IntPtr d2fmalc_d2fctxa;
        public IntPtr d2fmfre_d2fctxa;
        public IntPtr d2fmrlc_d2fctxa;
    }

    internal static D2fContextAttributes ConvertToManaged(D2fContextAttributesUnmanaged unmanaged)
    {
        return new D2fContextAttributes
        {
            mask_d2fctxa = unmanaged.mask_d2fctxa,
            cdata_d2fctxa = unmanaged.cdata_d2fctxa,
            d2fmalc_d2fctxa = Marshal.GetDelegateForFunctionPointer<D2fMalloc>(unmanaged.d2fmalc_d2fctxa),
            d2fmfre_d2fctxa = Marshal.GetDelegateForFunctionPointer<D2fFree>(unmanaged.d2fmfre_d2fctxa),
            d2fmrlc_d2fctxa = Marshal.GetDelegateForFunctionPointer<D2fRealloc>(unmanaged.d2fmrlc_d2fctxa)
        };
    }

    public static D2fContextAttributesUnmanaged ConvertToUnmanaged(D2fContextAttributes managed)
    {
        return new D2fContextAttributesUnmanaged
        {
            mask_d2fctxa = managed.mask_d2fctxa,
            cdata_d2fctxa = managed.cdata_d2fctxa,
            d2fmalc_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmalc_d2fctxa),
            d2fmfre_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmfre_d2fctxa),
            d2fmrlc_d2fctxa = Marshal.GetFunctionPointerForDelegate(managed.d2fmrlc_d2fctxa)
        };
    }
}
