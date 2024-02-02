using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a Forms API context.
/// </summary>
public sealed class NdapiContext : IDisposable
{
    private const int ClientData = 1; // client data
    private const int MemoryCallbacks = 2; // memory callbacks

    // keep these delegates here to avoid a "CallbackOnCollectedDelegate was detected"
    private static readonly Malloc AllocateMemoryDelegate = AllocateMemory;
    private static readonly Realloc ReallocateMemoryDelegate = ReallocateMemory;
    private static readonly Free FreeMemoryDelegate = FreeMemory;

    private static readonly List<NdapiModule> ModuleList = [];
    private static ContextSafeHandle s_context;
    private static string s_formsLib;
    private static BuilderVersion s_builderVersion;

    /// <summary>
    /// If true, the module loading will not fail when a required library module is not in the 
    /// search path. The default value is false.
    /// </summary>
    public static bool IgnoreMissingLibrary { get; set; } = false;

    /// <summary>
    /// If true, the module loading will not fail when a required object library is not in the 
    /// search path. The default value is false.
    /// </summary>
    public static bool IgnoreMissingSubclass { get; set; } = false;

    /// <summary>
    /// Gets whether the context is connected to database or not.
    /// </summary>
    public static bool IsConnected { get; private set; }

    static NdapiContext()
    {
        s_formsLib = NativeMethods.FormsLib;
        if (!Environment.Is64BitProcess)
        {
            NativeLibrary.SetDllImportResolver(typeof(NdapiContext).Assembly, ((name, assembly, path) =>
            {
                if (name != NativeMethods.FormsLib)
                {
                    return IntPtr.Zero;
                }

                s_formsLib = NativeMethods.Forms6Lib;
                return NativeLibrary.Load(s_formsLib, assembly, path);
            }));
        }
    }

    internal static ContextSafeHandle GetContext()
    {
        if (s_context != null)
        {
            return s_context;
        }

        var contextAttributes = new ContextAttributes
        {
            mask_d2fctxa = MemoryCallbacks,
            d2fmalc_d2fctxa = AllocateMemoryDelegate,
            d2fmrlc_d2fctxa = ReallocateMemoryDelegate,
            d2fmfre_d2fctxa = FreeMemoryDelegate
        };

        FormsErrorCode status;
        try
        {
            status = NativeMethods.d2fctxcr_Create(out s_context, ref contextAttributes);
        }
        catch (DllNotFoundException)
        {
            throw new NdapiException($"Could not found the {s_formsLib} from Oracle Forms installation. " +
                                     "Please check if this version of Oracle Forms is installed.");
        }

        Ensure.Success(status);
        return s_context;
    }

    private static IntPtr AllocateMemory(ref IntPtr context, IntPtr size)
    {
        return Marshal.AllocHGlobal(size);
    }

    private static IntPtr ReallocateMemory(ref IntPtr context, IntPtr ptr, IntPtr newsize)
    {
        return ptr == IntPtr.Zero ? AllocateMemory(ref context, newsize) : Marshal.ReAllocHGlobal(ptr, newsize);
    }

    private static void FreeMemory(ref IntPtr context, IntPtr ptr)
    {
        Marshal.FreeHGlobal(ptr);
    }

    /// <summary>
    /// Gets the version of the Forms API currently running. The format of the version number is a number 
    /// of the form 12334455, that corresponds to version 1.2.33.44.55.
    /// </summary>
    public static BuilderVersion BuilderVersion
    {
        get
        {
            if (s_builderVersion != null)
            {
                return s_builderVersion;
            }

            var status = NativeMethods.d2fctxbv_BuilderVersion(GetContext(), out var version);
            Ensure.Success(status);

            s_builderVersion = new BuilderVersion(version);
            return s_builderVersion;
        }
    }

    /// <summary>
    /// Returns the open modules in the current context.
    /// </summary>
    public static IEnumerable<NdapiModule> Modules => ModuleList;

    internal static void AddModule(NdapiModule module)
    {
        ModuleList.Add(module);
    }

    internal static void RemoveModule(NdapiModule module)
    {
        ModuleList.Remove(module);
    }

    /// <summary>
    /// Establish a database connection given a connect string.
    /// </summary>
    /// <param name="connection">Connection string (username/password@database).</param>
    public static void ConnectToDatabase(string connection)
    {
        var status = NativeMethods.d2fctxcn_Connect(GetContext(), connection, IntPtr.Zero);
        Ensure.Success(status);
        IsConnected = true;
    }

    /// <summary>
    /// Disconnect from the current database if one has been established.
    /// </summary>
    public static void DisconnectFromDatabase()
    {
        var status = NativeMethods.d2fctxdc_Disconnect(GetContext());
        Ensure.Success(status);
        IsConnected = false;
    }

    /// <summary>
    /// Destroy the Forms API context.
    /// </summary>
    public static void Destroy()
    {
        if (s_context.IsInvalid)
        {
            return;
        }

        s_context.Dispose();
        s_context = null;
        s_builderVersion = null;
    }

    /// <summary>
    /// Destroy the Forms API context and dispose the object.
    /// </summary>
    public void Dispose()
    {
        Destroy();
    }
}
