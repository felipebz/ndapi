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
    private const int D2FCTXACDATA = 1; // client data
    private const int D2FCTXAMCALLS = 2; // memory callbacks

    // keep these delegates here to avoid a "CallbackOnCollectedDelegate was detected"
    private static readonly D2fMalloc allocateMemory = AllocateMemory;
    private static readonly D2fRealloc reallocateMemory = ReallocateMemory;
    private static readonly D2fFree freeMemory = FreeMemory;

    private static readonly List<NdapiModule> _modules = new List<NdapiModule>();
    private static ContextSafeHandle _context;

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

    internal static ContextSafeHandle GetContext()
    {
        if (_context != null)
        {
            return _context;
        }

        var contextAttributes = new D2fContextAttributes
        {
            mask_d2fctxa = D2FCTXAMCALLS,
            d2fmalc_d2fctxa = allocateMemory,
            d2fmrlc_d2fctxa = reallocateMemory,
            d2fmfre_d2fctxa = freeMemory
        };

        D2fErrorCode status;
        try
        {
            status = NativeMethods.d2fctxcr_Create(out _context, ref contextAttributes);
        }
        catch (DllNotFoundException)
        {
            throw new NdapiException($"Could not found the {NativeMethods.formsLib} from Oracle Forms installation. " +
                                     "Please check if this version of Oracle Forms is installed.");
        }
        Ensure.Success(status);
        return _context;
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
    public static int ProductVersion
    {
        get
        {
            var status = NativeMethods.d2fctxbv_BuilderVersion(GetContext(), out var version);
            Ensure.Success(status);

            return version;
        }
    }

    /// <summary>
    /// Returns the open modules in the current context.
    /// </summary>
    public static IEnumerable<NdapiModule> Modules => _modules;

    internal static void AddModule(NdapiModule module)
    {
        _modules.Add(module);
    }

    internal static void RemoveModule(NdapiModule module)
    {
        _modules.Remove(module);
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
        if (_context.IsInvalid)
        {
            return;
        }

        _context.Dispose();
        _context = null;
    }

    /// <summary>
    /// Destroy the Forms API context and dispose the object.
    /// </summary>
    public void Dispose()
    {
        Destroy();
        GC.SuppressFinalize(this);
    }
}