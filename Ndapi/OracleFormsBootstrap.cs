using System.Runtime.CompilerServices;

namespace Ndapi;

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

internal static partial class OracleFormsBootstrap
{
    private const int RtldNow = 0x0002;
    private const int RtldGlobal = 0x0100;

    [LibraryImport("libdl.so.2", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial IntPtr dlopen(string fileName, int flags);

    [LibraryImport("libdl.so.2")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial IntPtr dlerror();

    [SupportedOSPlatform("linux")]
    public static void Init(string oracleHome)
    {
        var libDir = Path.Combine(oracleHome, "lib");
        var frmjapiPath = Path.Combine(libDir, "libfrmjapi.so");

        if (!File.Exists(frmjapiPath))
        {
            throw new NdapiException($"Could not found the {frmjapiPath} from Oracle Forms installation. " +
                                     "Please check if this version of Oracle Forms is installed.");
        }

        var handle = dlopen(frmjapiPath, RtldNow | RtldGlobal);
        if (handle != IntPtr.Zero)
        {
            return;
        }

        var errPtr = dlerror();
        var err = errPtr == IntPtr.Zero ? "unknown" : Marshal.PtrToStringAnsi(errPtr);
        throw new InvalidOperationException($"dlopen failure({frmjapiPath}): {err}");
    }
}
