using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi.Core;

// ReSharper disable InconsistentNaming
internal static partial class NativeMethods
{
    internal const string Forms6Lib = "ifd2f60";
    internal const string FormsLib = "frmd2f";
    internal const string FormsLibLinux = "libd2f.so";

    #region Context methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxbv_BuilderVersion(ContextSafeHandle pd2fctx, out int version);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxcr_Create(out ContextSafeHandle ppd2fctx,
        [MarshalUsing(typeof(ContextAttributesMarshaler))]
        ref ContextAttributes d2fctx_attr);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxcn_Connect(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string con_str,
        IntPtr phstdef);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxdc_Disconnect(ContextSafeHandle pd2fctx);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxde_Destroy(IntPtr pd2fctx);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fctxcf_ConvertFile(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string filename,
        int modtyp,
        int direction);

    #endregion

    #region Attached library methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2falbat_Attach(ContextSafeHandle pd2fctx,
        ObjectSafeHandle parent,
        out ObjectSafeHandle ppd2falb,
        [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2falbdt_Detach(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2falb);

    #endregion

    #region Block methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fblkco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fblk);

    #endregion

    #region Coordinate methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fcrdcr_Create(ContextSafeHandle pd2fctx, out ObjectSafeHandle ppd2fcrd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fcrdex_Extract(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fcrd,
        ObjectSafeHandle pd2ffmd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fcrdap_Apply(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fcrd,
        ObjectSafeHandle pd2ffmd);

    #endregion

    #region Font methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffntcr_Create(ContextSafeHandle pd2fctx, out ObjectSafeHandle ppd2ffnt);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffntex_Extract(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffnt,
        ObjectSafeHandle pd2fob, VisualAttributeType vat_typ);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffntap_Apply(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffnt,
        ObjectSafeHandle pd2fob, VisualAttributeType vat_typ);

    #endregion

    #region Form module methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        out int version);

    #endregion

    #region Object library methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        int pos, out ObjectSafeHandle ppret_obj);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbao_AddObj(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2folt,
        ObjectSafeHandle pd2fob,
        out ObjectSafeHandle ppd2fob,
        [MarshalAs(UnmanagedType.I1)] bool replace);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbro_RemoveObj(ContextSafeHandle pd2fctx, ObjectSafeHandle po2olb,
        ObjectSafeHandle pd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbss_SetSmartclass(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob,
        [MarshalAs(UnmanagedType.I1)] bool state);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbis_IsSmartclassed(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbsd_SetDesc(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] string desc);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbgd_GetDesc(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] out string desc);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbot_ObjTabname(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] out string tname);

    #endregion

    #region Object library tab methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2foltf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folt,
        int pos, out ObjectSafeHandle ppret_obj);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string olibname,
        out int version);

    #endregion

    #region Menu module methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string menuname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string menuname,
        out int version);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index,
        [MarshalAs(UnmanagedType.LPStr)] string role_name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdrr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd,
        int index);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdgr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string role_name);

    #endregion

    #region Menu item methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmnico_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmniar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index,
        [MarshalAs(UnmanagedType.LPStr)] string role_name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmnirr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni,
        int index);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmnigr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string role_name);

    #endregion

    #region Menu parameter methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmpmaam_AddAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index, [MarshalAs(UnmanagedType.LPStr)] string menu_name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmpmram_RemoveAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmpmgam_GetAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index, [MarshalAs(UnmanagedType.LPStr)] out string menu_name);

    #endregion

    #region Library module methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2flibld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2flib,
        [MarshalAs(UnmanagedType.LPStr)] string libname);

    #endregion

    #region Block relation methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frelup_Update(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);

    #endregion

    #region Graphics methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fgraim_importImage(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fgra,
        [MarshalAs(UnmanagedType.LPStr)] string filename, ImageFormat format);

    #endregion

    #region Item methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fitmco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fitmile_InsertListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index, [MarshalAs(UnmanagedType.LPStr)] string label, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fitmdle_DeleteListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fitmgle_GetListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index, [MarshalAs(UnmanagedType.LPStr)] out string label,
        [MarshalAs(UnmanagedType.LPStr)] out string value);

    #endregion

    #region Program unit methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fpguco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);

    #endregion

    #region Property methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int d2fprgt_GetType(ContextSafeHandle pd2fctx, int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fprgn_GetName(ContextSafeHandle pd2fctx, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fprgvn_GetValueName(ContextSafeHandle pd2fctx, int pnum, int val,
        [MarshalAs(UnmanagedType.LPStr)] out string vname);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fprgcv_GetConstValue(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string pcname, out int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fprgcn_GetConstName(ContextSafeHandle pd2fctx, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pcname);

    #endregion

    #region Property classes methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fppcrp_RemoveProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fppc,
        int pnum);

    #endregion

    #region Record group methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frcgs_qry_noparse(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcg,
        [MarshalAs(UnmanagedType.LPStr)] string query);

    #endregion

    #region Trigger methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ftrgco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ftrg);

    #endregion

    #region Record group column methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frcsir_InsertRow_Int(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs,
        int index, [MarshalAs(UnmanagedType.LPStr)] string dat, [MarshalAs(UnmanagedType.LPStr)] string fmt_mask);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frcsdr_DeleteRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs,
        int index);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frcsgr_GetRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string dat);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2frcsgrn_GetRowName(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string dat);

    #endregion

    #region Object methods

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobcr_Create(ContextSafeHandle pd2fctx,
        ObjectSafeHandle owner,
        out ObjectSafeHandle ppd2fob,
        [MarshalAs(UnmanagedType.LPStr)] string name,
        int objtyp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobgt_GetTextProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pprp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobst_SetTextProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] string prp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobgn_GetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        out int pprp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobsn_SetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        int prp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobgb_GetBoolProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.I1)] out bool pprp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobsb_SetBoolProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.I1)] bool prp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobgo_GetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        out ObjectSafeHandle pprp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobso_SetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        ObjectSafeHandle prp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobhp_HasProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode
        d2fobip_InheritProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobii_IspropInherited(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobid_IspropDefault(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        int pnum);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobis_IsSubclassed(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobqt_QueryType(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        out int objtyp);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobde_Destroy(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobra_Reattach(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobdu_Duplicate(ContextSafeHandle pd2fctx,
        ObjectSafeHandle new_owner,
        ObjectSafeHandle pd2fob_src,
        out ObjectSafeHandle ppd2fob_dst,
        [MarshalAs(UnmanagedType.LPStr)] string new_name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobre_Replicate(ContextSafeHandle pd2fctx,
        ObjectSafeHandle new_parent,
        ObjectSafeHandle pd2fob_src,
        out ObjectSafeHandle ppd2fob_dst,
        [MarshalAs(UnmanagedType.LPStr)] string new_name);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobfo_FindObj(ContextSafeHandle pd2fctx,
        ObjectSafeHandle owner,
        [MarshalAs(UnmanagedType.LPStr)] string name,
        int objtyp,
        out ObjectSafeHandle ppd2fob);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobsc_SubClass(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        ObjectSafeHandle parent,
        [MarshalAs(UnmanagedType.I1)] bool keep_path);

    [LibraryImport(FormsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fobmv_Move(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        ObjectSafeHandle pd2fob_nxt);

    #endregion
}
