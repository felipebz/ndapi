using NdapiManaged.Core.Handles;
using System;
using System.Runtime.InteropServices;

namespace NdapiManaged.Core
{
    internal static class NativeMethods
    {
        const string ifd2f60 = "ifd2f60.DLL";

        // Context specific methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxbv_BuilderVersion(ContextSafeHandle pd2fctx, ref int version);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcr_Create(out ContextSafeHandle ppd2fctx, ref D2fContextAttributes d2fctx_attr);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fctxcn_Connect(IntPtr pd2fctx,
                                                  string con_str,
                                                  IntPtr phstdef);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxde_Destroy(IntPtr pd2fctx);

        // Form module specific methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2ffmdld_Load(ContextSafeHandle pd2fctx,
                                               out ObjectSafeHandle ppd2ffmd,
                                               string formname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        // Object methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgt_GetTextProp(IntPtr pd2fctx, IntPtr pd2fob, ushort pnum, ref IntPtr pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobde_Destroy(ContextSafeHandle pd2fctx, IntPtr pd2fob);
    }
}
