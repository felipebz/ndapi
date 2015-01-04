using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Runtime.InteropServices;

namespace Ndapi.Core
{
    internal static class NativeMethods
    {
        const string ifd2f60 = "ifd2f60.DLL";

        #region Context methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxbv_BuilderVersion(ContextSafeHandle pd2fctx, ref int version);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxcr_Create(out ContextSafeHandle ppd2fctx, ref D2fContextAttributes d2fctx_attr);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fctxcn_Connect(ContextSafeHandle pd2fctx,
                                                  string con_str,
                                                  IntPtr phstdef);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxdc_Disconnect(ContextSafeHandle pd2fctx);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fctxde_Destroy(IntPtr pd2fctx);
        #endregion

        #region Attached library methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2falbat_Attach(ContextSafeHandle pd2fctx,
                                                 ObjectSafeHandle parent,
                                                 out ObjectSafeHandle ppd2falb,
                                                 [MarshalAs(UnmanagedType.I1)] bool db,
                                                 string name);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2falbdt_Detach(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2falb);
        #endregion

        #region Block methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fblkco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fblk);
        #endregion

        #region Form module methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2ffmdld_Load(ContextSafeHandle pd2fctx,
                                               out ObjectSafeHandle ppd2ffmd,
                                               string formname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2ffmdsv_Save(ContextSafeHandle pd2fctx,
                                               ObjectSafeHandle pd2ffmd,
                                               string formname, 
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2ffmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2ffmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
                                                      string formname,
                                                      [MarshalAs(UnmanagedType.I1)] bool db,
                                                      out int version);
        #endregion

        #region Object library methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2folbld_Load(ContextSafeHandle pd2fctx,
                                               out ObjectSafeHandle ppd2folb,
                                               string olibname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2folbsv_Save(ContextSafeHandle pd2fctx,
                                               ObjectSafeHandle pd2folb,
                                               string olibname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2folbf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb, int pos, out ObjectSafeHandle ppret_obj);
        #endregion

        #region Object library tab methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2foltf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folt, int pos, out ObjectSafeHandle ppret_obj);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
                                                      string olibname,
                                                      [MarshalAs(UnmanagedType.I1)] bool db,
                                                      out int version);
        #endregion

        #region Menu module methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmmdld_Load(ContextSafeHandle pd2fctx,
                                               out ObjectSafeHandle ppd2fmmd,
                                               string formname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmmdsv_Save(ContextSafeHandle pd2fctx,
                                               ObjectSafeHandle pd2fmmd,
                                               string menuname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
                                                      string menuname,
                                                      [MarshalAs(UnmanagedType.I1)] bool db,
                                                      out int version);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmmdar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index, string role_name);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmmdrr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmmdgr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index, out string role_name);
        #endregion

        #region Menu item methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmnico_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmniar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index, string role_name);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmnirr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmnigr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index, out string role_name);
        #endregion

        #region Menu parameter methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmpmaam_AddAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm, int index, string menu_name);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fmpmram_RemoveAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm, int index);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fmpmgam_GetAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm, int index, out string menu_name);
        #endregion

        #region Library module methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2flibld_Load(ContextSafeHandle pd2fctx,
                                               out ObjectSafeHandle ppd2flib,
                                               string libname,
                                               [MarshalAs(UnmanagedType.I1)] bool db);
        #endregion

        #region Block relation methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2frelup_Update(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);
        #endregion

        #region Graphics methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fgraim_importImage(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fgra, string filename, ImageFormat format);
        #endregion

        #region Item methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fitmco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fitmile_InsertListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm, int index, string label, string value);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fitmdle_DeleteListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm, int index);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fitmgle_GetListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm, int index, out string label, out string value);
        #endregion

        #region Program unit methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fpguco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);
        #endregion

        #region Property methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern PropertyType d2fprgt_GetType(ContextSafeHandle pd2fctx, int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fprgn_GetName(ContextSafeHandle pd2fctx, int pnum, out string pname);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fprgvn_GetValueName(ContextSafeHandle pd2fctx, int pnum, int val, out string vname);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fprgcv_GetConstValue(ContextSafeHandle pd2fctx, string pcname, out int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fprgcn_GetConstName(ContextSafeHandle pd2fctx, int pnum, out string pcname);
        #endregion

        #region Property classes methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fppcrp_RemoveProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fppc, int pnum);
        #endregion

        #region Record group methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2frcgs_qry_noparse(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcg, string query);
        #endregion

        #region Trigger methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2ftrgco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ftrg);
        #endregion

        #region Record group column methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2frcsir_InsertRow_Int(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index, string dat, string fmt_mask);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2frcsdr_DeleteRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2frcsgr_GetRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index, out string dat);
        #endregion

        #region Object methods
        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fobcr_Create(ContextSafeHandle pd2fctx,
                                                ObjectSafeHandle owner,
                                                out ObjectSafeHandle ppd2fob,
                                                string name,
                                                int objtyp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fobgt_GetTextProp(ContextSafeHandle pd2fctx,
                                                     ObjectSafeHandle pd2fob,
                                                     int pnum,
                                                     out string pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int d2fobst_SetTextProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, string prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgn_GetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, out int pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobsn_SetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, int prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgb_GetBoolProp(ContextSafeHandle pd2fctx,
                                                     ObjectSafeHandle pd2fob,
                                                     int pnum,
                                                     [MarshalAs(UnmanagedType.I1)] out bool pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobsb_SetBoolProp(ContextSafeHandle pd2fctx,
                                                     ObjectSafeHandle pd2fob,
                                                     int pnum,
                                                     [MarshalAs(UnmanagedType.I1)] bool prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobgo_GetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, out ObjectSafeHandle pprp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobso_SetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum, ObjectSafeHandle prp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobhp_HasProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobip_InheritProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobii_IspropInherited(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobid_IspropDefault(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobis_IsSubclassed(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobqt_QueryType(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, out ObjectType objtyp);

        [DllImport(ifd2f60, CallingConvention = CallingConvention.Cdecl)]
        public static extern int d2fobde_Destroy(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);
        #endregion
    }
}
