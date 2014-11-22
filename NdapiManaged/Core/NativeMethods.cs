using System;
using System.Runtime.InteropServices;

namespace NdapiManaged.Core
{
    public class NativeMethods
    {
        const string ifd2f60 = "ifd2f60.DLL";

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxbv_BuilderVersion(IntPtr pd2fctx, ref int version);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcr_Create(ref IntPtr ppd2fctx, ref D2fContextAttributes d2fctx_attr);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcn_Connect(IntPtr pd2fctx, string con_str, IntPtr phstdef);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2ffmdld_Load(IntPtr pd2fctx,
                                               ref IntPtr ppd2ffmd,
                                               string formname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgt_GetTextProp(IntPtr pd2fctx, IntPtr pd2fob, ushort pnum, ref IntPtr pprp);

    }
}
