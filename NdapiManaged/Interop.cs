using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged
{
    /// Return Type: void*
    ///context: d2fctx*
    ///size: size_t->unsigned int
    public delegate IntPtr d2fmalc(ref d2fctx context, IntPtr size);

    /// Return Type: void*
    ///context: d2fctx*
    ///ptr: void*
    ///newsize: size_t->unsigned int
    public delegate IntPtr d2fmrlc(ref d2fctx context, IntPtr ptr, IntPtr newsize);

    /// Return Type: void
    ///context: d2fctx*
    ///ptr: void*
    public delegate void d2fmfre(ref d2fctx context, IntPtr ptr);

    [StructLayout(LayoutKind.Sequential)]
    public struct d2fctx
    {

        /// void*
        public IntPtr pidgc_d2fctx;

        /// void*
        public IntPtr cdata_d2fctx;

        /// d2fmalc
        public d2fmalc d2fmalc_d2fctx;

        /// d2fmfre
        public d2fmfre d2fmfre_d2fctx;

        /// d2fmrlc
        public d2fmrlc d2fmrlc_d2fctx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct d2fctxa
    {

        /// ub4->unsigned int
        public uint mask_d2fctxa;

        /// void*
        public IntPtr cdata_d2fctxa;

        /// d2fmalc
        public d2fmalc d2fmalc_d2fctxa;

        /// d2fmfre
        public d2fmfre d2fmfre_d2fctxa;

        /// d2fmrlc
        public d2fmrlc d2fmrlc_d2fctxa;
    }

    public partial class NativeMethods
    {
        const string dllName = "ifd2f60.DLL";

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxbv_BuilderVersion(IntPtr pd2fctx, ref uint version);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcr_Create(ref IntPtr ppd2fctx, ref d2fctxa d2fctx_attr);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcn_Connect(IntPtr pd2fctx, string con_str, IntPtr phstdef);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2ffmdld_Load(IntPtr pd2fctx,
                                               ref IntPtr ppd2ffmd,
                                               string formname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int d2fobgt_GetTextProp(IntPtr pd2fctx, IntPtr pd2fob, ushort pnum, ref IntPtr pprp);

    }
}
