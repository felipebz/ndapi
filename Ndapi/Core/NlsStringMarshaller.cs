using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;

namespace Ndapi.Core;

#nullable enable
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
internal static unsafe partial class NlsStringMarshaller
{
    // resolved on first use, so an unsupported NLS_LANG is reported by every call instead of poisoning the type
    private static Encoding Enc => field ??= InitializeEncoding();

    /// <summary>
    /// Encodes into the stack buffer the generated stub provides, and only allocates native memory for strings that
    /// don't fit (e.g. PL/SQL text). Forms copies string arguments, so the buffer only has to outlive the call.
    /// </summary>
    public ref struct ManagedToUnmanagedIn
    {
        public static int BufferSize => 0x100;

        private byte* _native;
        private bool _allocated;

        public void FromManaged(string? managed, Span<byte> buffer) =>
            _native = managed is null
                ? null
                : Encode(managed, buffer, Enc, "the module charset from NLS_LANG", out _allocated);

        public readonly byte* ToUnmanaged() => _native;

        public readonly void Free()
        {
            if (_allocated)
                Marshal.FreeHGlobal((IntPtr)_native);
        }
    }

    /// <summary>
    /// Encodes <paramref name="managed"/> as a null-terminated string into <paramref name="buffer"/>, or into native
    /// memory when it doesn't fit (<paramref name="allocated"/>, freed by the caller).
    /// </summary>
    internal static byte* Encode(string managed, Span<byte> buffer, Encoding encoding, string target,
        out bool allocated)
    {
        allocated = false;
        try
        {
            // the exact count is a second pass over the string, only needed when the worst case doesn't fit
            if (encoding.GetMaxByteCount(managed.Length) + 1 > buffer.Length)
            {
                var byteCount = encoding.GetByteCount(managed) + 1;
                if (byteCount > buffer.Length)
                {
                    buffer = new Span<byte>((byte*)Marshal.AllocHGlobal(byteCount), byteCount);
                    allocated = true;
                }
            }

            var bytesWritten = encoding.GetBytes(managed, buffer);
            buffer[bytesWritten] = 0;
        }
        catch (EncoderFallbackException e)
        {
            // never pass a replacement character ('?') in place of text the target can't represent
            throw new NdapiException(
                $"The character '{e.CharUnknown}' (U+{(int)e.CharUnknown:X4}) at position {e.Index} has no " +
                $"representation in {target} ({encoding.WebName}).", e);
        }

        // the stub's buffer is stackalloc'ed and the fallback is native memory: neither moves
        return (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(buffer));
    }

    private static Encoding InitializeEncoding()
    {
        // NLS_LANG is language_territory.charset
        var nlsLang = Environment.GetEnvironmentVariable("NLS_LANG");
        var separator = nlsLang?.LastIndexOf('.') ?? -1;
        var charset = separator >= 0 ? nlsLang![(separator + 1)..].Trim() : "";

        var encoding = (Encoding)(charset.Length == 0
            ? GetDefaultEncoding()
            : GetEncoding(charset) ?? throw new NdapiException(
                $"The character set {charset} from NLS_LANG has no .NET equivalent known to Ndapi.")).Clone();
        encoding.EncoderFallback = EncoderFallback.ExceptionFallback;
        encoding.DecoderFallback = DecoderFallback.ReplacementFallback;
        return encoding;
    }

    // Without NLS_LANG in the environment, Oracle reads it from the registry on Windows, where the installer sets it
    // to the ANSI code page; elsewhere its default charset is US7ASCII.
    private static Encoding GetDefaultEncoding() =>
        (OperatingSystem.IsWindows() ? CodePagesEncodingProvider.Instance.GetEncoding(0) : null) ?? Encoding.ASCII;

    /// <summary>
    /// Maps an Oracle character set name to its .NET encoding, or null when there's none.
    /// </summary>
    internal static Encoding? GetEncoding(string oracleCharset)
    {
        var charset = oracleCharset.ToUpperInvariant();
        int? codePage = charset switch
        {
            "AL32UTF8" or "UTF8" => 65001,
            "US7ASCII" => 20127,
            "JA16SJIS" => 932,
            "ZHS16GBK" => 936,
            _ => null
        };

        string? name = null;
        if (codePage is null && OracleCharsetPattern().Match(charset) is { Success: true } match)
        {
            if (match.Groups["iso"].Success)
            {
                name = $"iso-8859-{match.Groups["iso"].Value}";
            }
            else
            {
                codePage = int.Parse(match.Groups["cp"].ValueSpan, CultureInfo.InvariantCulture);
            }
        }

        try
        {
            if (codePage is { } cp)
            {
                return CodePagesEncodingProvider.Instance.GetEncoding(cp) ?? Encoding.GetEncoding(cp);
            }

            return name is null
                ? null
                : CodePagesEncodingProvider.Instance.GetEncoding(name) ?? Encoding.GetEncoding(name);
        }
        catch (Exception e) when (e is ArgumentException or NotSupportedException)
        {
            return null;
        }
    }

    // WE8MSWIN1252, EE8MSWIN1250, KO16MSWIN949 (Windows code pages), WE8PC850 (DOS), WE8ISO8859P15, EE8ISO8859P2
    [GeneratedRegex(@"^[A-Z]+\d+(?:MSWIN(?<cp>\d+)|PC(?<cp>\d+)|ISO8859P(?<iso>\d+))$", RegexOptions.CultureInvariant)]
    private static partial Regex OracleCharsetPattern();

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
