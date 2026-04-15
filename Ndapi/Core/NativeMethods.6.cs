using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi.Core;

// ReSharper disable InconsistentNaming
internal static partial class NativeMethods
{
    // Methods exclusive to Forms 6i

    #region Attached library methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2falbat_Attach(ContextSafeHandle pd2fctx,
        ObjectSafeHandle parent,
        out ObjectSafeHandle ppd2falb,
        [MarshalAs(UnmanagedType.I1)] bool db,
        [MarshalAs(UnmanagedType.LPStr)] string name);

    #endregion

    #region Form module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2ffmd,
        [MarshalUsing(typeof(NlsStringMarshaller))] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(NlsStringMarshaller))] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Object library methods

    // Forms 6i only
    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2folb,
        [MarshalUsing(typeof(NlsStringMarshaller))] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        [MarshalUsing(typeof(NlsStringMarshaller))] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

    #region Object library tab methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(NlsStringMarshaller))] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Menu module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2fmmd,
        [MarshalUsing(typeof(NlsStringMarshaller))] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fmmd,
        [MarshalUsing(typeof(NlsStringMarshaller))] string menuname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(NlsStringMarshaller))] string menuname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Library module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2flibld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2flib,
        [MarshalUsing(typeof(NlsStringMarshaller))] string libname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

}
