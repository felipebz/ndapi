using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi.Core;

internal static partial class NativeMethods
{
    // Methods exclusive to Forms 6i

    #region Attached library methods

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2falbat_Attach(ContextSafeHandle pd2fctx,
        ObjectSafeHandle parent,
        out ObjectSafeHandle ppd2falb,
        [MarshalAs(UnmanagedType.I1)] bool db,
        [MarshalAs(UnmanagedType.LPStr)] string name);

    #endregion

    #region Form module methods

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2ffmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2ffmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Object library methods

    // Forms 6i only
    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2folb,
        [MarshalAs(UnmanagedType.LPStr)] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

    #region Object library tab methods

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2folbfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string olibname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Menu module methods

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string formname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdsv_Save(ContextSafeHandle pd2fctx,
        ObjectSafeHandle pd2fmmd,
        [MarshalAs(UnmanagedType.LPStr)] string menuname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2fmmdfv_FileVersion(ContextSafeHandle pd2fctx,
        [MarshalAs(UnmanagedType.LPStr)] string menuname,
        [MarshalAs(UnmanagedType.I1)] bool db,
        out int version);

    #endregion

    #region Library module methods

    [LibraryImport(forms6Lib)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial D2fErrorCode d2flibld_Load(ContextSafeHandle pd2fctx,
        out ObjectSafeHandle ppd2flib,
        [MarshalAs(UnmanagedType.LPStr)] string libname,
        [MarshalAs(UnmanagedType.I1)] bool db);

    #endregion

}
