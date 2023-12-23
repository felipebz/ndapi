using System;
using System.Runtime.InteropServices;

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
