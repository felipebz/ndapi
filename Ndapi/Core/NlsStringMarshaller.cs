using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Ndapi.Core;

#nullable enable
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
internal static unsafe class NlsStringMarshaller
{
    private static readonly Encoding Enc = InitializeEncoding();

    /// <summary>
    /// Encodes into the stack buffer the generated stub provides, and only allocates native memory for strings that
    /// don't fit (e.g. PL/SQL text). Forms copies string arguments, so the buffer only has to outlive the call.
    /// </summary>
    public ref struct ManagedToUnmanagedIn
    {
        public static int BufferSize => 0x100;

        private byte* _native;
        private bool _allocated;

        public void FromManaged(string? managed, Span<byte> buffer)
        {
            if (managed is null)
            {
                _native = null;
                return;
            }

            try
            {
                // the exact count is a second pass over the string, only needed when the worst case doesn't fit
                if (Enc.GetMaxByteCount(managed.Length) + 1 > buffer.Length)
                {
                    var byteCount = Enc.GetByteCount(managed) + 1;
                    if (byteCount > buffer.Length)
                    {
                        buffer = new Span<byte>((byte*)Marshal.AllocHGlobal(byteCount), byteCount);
                        _allocated = true;
                    }
                }

                var bytesWritten = Enc.GetBytes(managed, buffer);
                buffer[bytesWritten] = 0;
            }
            catch (EncoderFallbackException e)
            {
                // never store a replacement character ('?') in place of text the module charset can't represent
                throw new NdapiException(
                    $"The character '{e.CharUnknown}' (U+{(int)e.CharUnknown:X4}) at position {e.Index} has no " +
                    $"representation in the module charset ({Enc.WebName}, from NLS_LANG).", e);
            }

            // the stub's buffer is stackalloc'ed and the fallback is native memory: neither moves
            _native = (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(buffer));
        }

        public readonly byte* ToUnmanaged() => _native;

        public readonly void Free()
        {
            if (_allocated)
                Marshal.FreeHGlobal((IntPtr)_native);
        }
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
            return Encoding.GetEncoding(dotNetName, EncoderFallback.ExceptionFallback, DecoderFallback.ReplacementFallback);

        return Encoding.GetEncoding(Encoding.Default.CodePage, EncoderFallback.ExceptionFallback,
            DecoderFallback.ReplacementFallback);
    }

    public static string? ReadNlsStringAndFree(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return null;

        try
        {
            return Enc.GetString(MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)ptr));
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }
    }
}
