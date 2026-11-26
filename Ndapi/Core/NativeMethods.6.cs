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
        [MarshalUsing(typeof(NlsStringMarshaller))] string? name);

    #endregion

    #region Form module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2ffmd,
        [MarshalUsing(typeof(PathMarshaller))] string? formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2ffmd,
        [MarshalUsing(typeof(PathMarshaller))] string? formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(PathMarshaller))] string? formname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Object library methods

    // Forms 6i only
    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2folb,
        [MarshalUsing(typeof(PathMarshaller))] string? olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        [MarshalUsing(typeof(PathMarshaller))] string? olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

    #region Object library tab methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(PathMarshaller))] string? olibname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Menu module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2fmmd,
        [MarshalUsing(typeof(PathMarshaller))] string? formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fmmd,
        [MarshalUsing(typeof(PathMarshaller))] string? menuname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalUsing(typeof(PathMarshaller))] string? menuname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Library module methods

    [LibraryImport(Forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FormsErrorCode d2flibld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2flib,
        [MarshalUsing(typeof(PathMarshaller))] string? libname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

}
