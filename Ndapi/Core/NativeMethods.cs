using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi.Core;

internal static partial class NativeMethods
{
    internal const string forms6Lib = "ifd2f60";
    internal const string formsLib = "frmd2f";

    #region Context methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxbv_BuilderVersion(ContextSafeHandle pd2fctx, out int version);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxcr_Create(out ContextSafeHandle ppd2fctx,
        [MarshalUsing(typeof(D2fContextAttributesMarshaler))]
        ref D2fContextAttributes d2fctx_attr);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxcn_Connect(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string con_str,
        IntPtr phstdef);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxdc_Disconnect(ContextSafeHandle pd2fctx);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxde_Destroy(IntPtr pd2fctx);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fctxcf_ConvertFile(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string filename,
        int modtyp,
        int direction);

    #endregion

    #region Attached library methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2falbat_Attach(ContextSafeHandle pd2fctx,
        ObjectSafeHandle parent,
        out ObjectSafeHandle ppd2falb,
        [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2falbdt_Detach(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2falb);

    #endregion

    #region Block methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fblkco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fblk);

    #endregion

    #region Coordinate methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fcrdcr_Create(ContextSafeHandle pd2fctx, out ObjectSafeHandle ppd2fcrd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fcrdex_Extract(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fcrd,
        ObjectSafeHandle pd2ffmd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fcrdap_Apply(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fcrd,
        ObjectSafeHandle pd2ffmd);

    #endregion

    #region Font methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffntcr_Create(ContextSafeHandle pd2fctx, out ObjectSafeHandle ppd2ffnt);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffntex_Extract(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffnt,
        ObjectSafeHandle pd2fob, VisualAttributeType vat_typ);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffntap_Apply(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffnt,
        ObjectSafeHandle pd2fob, VisualAttributeType vat_typ);

    #endregion

    #region Form module methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ffmd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        out int version);

    #endregion

    #region Object library methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        int pos, out ObjectSafeHandle ppret_obj);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbao_AddObj(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2folt,
        ObjectSafeHandle pd2fob,
        out ObjectSafeHandle ppd2fob,
        [MarshalAs(UnmanagedType.I1)] bool replace);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbro_RemoveObj(ContextSafeHandle pd2fctx, ObjectSafeHandle po2olb,
        ObjectSafeHandle pd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbss_SetSmartclass(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob,
        [MarshalAs(UnmanagedType.I1)] bool state);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbis_IsSmartclassed(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbsd_SetDesc(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] string desc);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbgd_GetDesc(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] out string desc);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbot_ObjTabname(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folb,
        ObjectSafeHandle pd2fob, [MarshalAs(UnmanagedType.LPStr)] out string tname);

    #endregion

    #region Object library tab methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2foltf2_Findobjbypos(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2folt,
        int pos, out ObjectSafeHandle ppret_obj);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string olibname,
        out int version);

    #endregion

    #region Menu module methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string menuname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdcf_CompileFile(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string menuname,
        out int version);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index,
        [MarshalAs(UnmanagedType.LPStr)] string role_name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdrr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd,
        int index);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdgr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmmd, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string role_name);

    #endregion

    #region Menu item methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmnico_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmniar_AddRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index,
        [MarshalAs(UnmanagedType.LPStr)] string role_name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmnirr_RemoveRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni,
        int index);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmnigr_GetRole(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmni, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string role_name);

    #endregion

    #region Menu parameter methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmpmaam_AddAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index, [MarshalAs(UnmanagedType.LPStr)] string menu_name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmpmram_RemoveAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmpmgam_GetAssocMenu(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fmpm,
        int index, [MarshalAs(UnmanagedType.LPStr)] out string menu_name);

    #endregion

    #region Library module methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2flibld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2flib,
        [MarshalAs(UnmanagedType.LPStr)] string libname);

    #endregion

    #region Block relation methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2frelup_Update(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);

    #endregion

    #region Graphics methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fgraim_importImage(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fgra,
        [MarshalAs(UnmanagedType.LPStr)] string filename, ImageFormat format);

    #endregion

    #region Item methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fitmco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fitmile_InsertListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index, [MarshalAs(UnmanagedType.LPStr)] string label, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fitmdle_DeleteListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fitmgle_GetListElem(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fitm,
        int index, [MarshalAs(UnmanagedType.LPStr)] out string label,
        [MarshalAs(UnmanagedType.LPStr)] out string value);

    #endregion

    #region Program unit methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fpguco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fpgu);

    #endregion

    #region Property methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int d2fprgt_GetType(ContextSafeHandle pd2fctx, int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fprgn_GetName(ContextSafeHandle pd2fctx, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fprgvn_GetValueName(ContextSafeHandle pd2fctx, int pnum, int val,
        [MarshalAs(UnmanagedType.LPStr)] out string vname);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fprgcv_GetConstValue(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string pcname, out int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fprgcn_GetConstName(ContextSafeHandle pd2fctx, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pcname);

    #endregion

    #region Property classes methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fppcrp_RemoveProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fppc,
        int pnum);

    #endregion

    #region Record group methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2frcgs_qry_noparse(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcg,
        [MarshalAs(UnmanagedType.LPStr)] string query);

    #endregion

    #region Trigger methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ftrgco_CompileObj(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2ftrg);

    #endregion

    #region Record group column methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2frcsir_InsertRow_Int(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs,
        int index, [MarshalAs(UnmanagedType.LPStr)] string dat, [MarshalAs(UnmanagedType.LPStr)] string fmt_mask);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2frcsdr_DeleteRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs,
        int index);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2frcsgr_GetRow(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2frcs, int index,
        [MarshalAs(UnmanagedType.LPStr)] out string dat);

    #endregion

    #region Object methods

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobcr_Create(ContextSafeHandle pd2fctx,
        ObjectSafeHandle owner,
        out ObjectSafeHandle ppd2fob,
        [MarshalAs(UnmanagedType.LPStr)] string name,
        int objtyp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobgt_GetTextProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.LPStr)] out string pprp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobst_SetTextProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        [MarshalAs(UnmanagedType.LPStr)] string prp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobgn_GetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        out int pprp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobsn_SetNumProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        int prp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobgb_GetBoolProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.I1)] out bool pprp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobsb_SetBoolProp(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        int pnum,
        [MarshalAs(UnmanagedType.I1)] bool prp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobgo_GetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        out ObjectSafeHandle pprp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobso_SetObjProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum,
        ObjectSafeHandle prp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobhp_HasProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode
        d2fobip_InheritProp(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob, int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobii_IspropInherited(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobid_IspropDefault(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        int pnum);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobis_IsSubclassed(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobqt_QueryType(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        out int objtyp);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobde_Destroy(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobra_Reattach(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobdu_Duplicate(ContextSafeHandle pd2fctx,
        ObjectSafeHandle new_owner,
        ObjectSafeHandle pd2fob_src,
        out ObjectSafeHandle ppd2fob_dst,
        [MarshalAs(UnmanagedType.LPStr)] string new_name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobre_Replicate(ContextSafeHandle pd2fctx,
        ObjectSafeHandle new_parent,
        ObjectSafeHandle pd2fob_src,
        out ObjectSafeHandle ppd2fob_dst,
        [MarshalAs(UnmanagedType.LPStr)] string new_name);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobfo_FindObj(ContextSafeHandle pd2fctx,
        ObjectSafeHandle owner,
        [MarshalAs(UnmanagedType.LPStr)] string name,
        int objtyp,
        out ObjectSafeHandle ppd2fob);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobsc_SubClass(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fob,
        ObjectSafeHandle parent,
        [MarshalAs(UnmanagedType.I1)] bool keep_path);

    [LibraryImport(formsLib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fobmv_Move(ContextSafeHandle pd2fctx, ObjectSafeHandle pd2fob,
        ObjectSafeHandle pd2fob_nxt);

    #endregion
}
