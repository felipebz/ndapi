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
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fobgt_GetTextProp(ContextSafeHandle pd2fctx, 
                                                     ObjectSafeHandle pd2fob,
                                                     int pnum,
                                                     [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(StringMarshaller))] out string pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fobst_SetTextProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, string prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgn_GetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, out int pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobsn_SetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, int prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgb_GetBoolProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, out bool pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobsb_SetBoolProp(ContextSafeHandle pd2fctx,
                                                     ObjectSafeHandle pd2fob,
                                                     int pnum,
                                                     [MarshalAs(UnmanagedType.I1)] bool prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobid_IspropDefault(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);


        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobde_Destroy(ContextSafeHandle pd2fctx, IntPtr pd2fob);
    }
}
