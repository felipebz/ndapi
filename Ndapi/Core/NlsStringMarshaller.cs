using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Ndapi.Core;

#nullable enable
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(NlsStringMarshaller))]
internal static class NlsStringMarshaller
{
    private static readonly Encoding Enc = InitializeEncoding();

    public static IntPtr ConvertToUnmanaged(string? managed)
    {
        if (managed is null)
            return IntPtr.Zero;

        byte[] rented = ArrayPool<byte>.Shared.Rent(Enc.GetByteCount(managed) + 1);
        int bytesWritten = Enc.GetBytes(managed, 0, managed.Length, rented, 0);
        rented[bytesWritten] = 0;

        IntPtr native = Marshal.AllocHGlobal(bytesWritten + 1);
        Marshal.Copy(rented, 0, native, bytesWritten + 1);

        ArrayPool<byte>.Shared.Return(rented);
        return native;
    }

    public static void Free(IntPtr unmanaged)
    {
        if (unmanaged != IntPtr.Zero)
            Marshal.FreeHGlobal(unmanaged);
    }

    private static Encoding InitializeEncoding()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        string? nlsLang = Environment.GetEnvironmentVariable("NLS_LANG");
        string? oracleCs = nlsLang?
            .Split('.', StringSplitOptions.RemoveEmptyEntries)
            .LastOrDefault()
            ?.ToUpperInvariant();

        var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["AL32UTF8"] = "utf-8",
            ["UTF8"] = "utf-8",
            ["WE8ISO8859P1"] = "iso-8859-1",
            ["WE8MSWIN1252"] = "windows-1252"
        };

        if (oracleCs != null && map.TryGetValue(oracleCs, out string? dotNetName))
            return Encoding.GetEncoding(dotNetName);

        return Encoding.Default;
    }
    
    public static string? ReadNlsStringAndFree(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return null;

        try
        {
            int length = 0;
            while (Marshal.ReadByte(ptr, length) != 0)
            {
                length++;
            }

            if (length == 0)
                return string.Empty;

            byte[] buffer = ArrayPool<byte>.Shared.Rent(length);
            try
            {
                Marshal.Copy(ptr, buffer, 0, length);
                return Enc.GetString(buffer, 0, length);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }
    }
}
