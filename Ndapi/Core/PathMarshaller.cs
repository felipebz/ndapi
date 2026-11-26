using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Ndapi.Core;

/// <summary>
/// Marshals file paths. Forms hands them to the operating system untouched, so they use the encoding of the file
/// system rather than the module charset from NLS_LANG: the ANSI code page on Windows, whose narrow file APIs Forms
/// calls, and UTF-8 elsewhere, where .NET itself names files in UTF-8.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
internal static unsafe class PathMarshaller
{
    private static Encoding? s_encoding;

    private static Encoding Enc => s_encoding ??= InitializeEncoding();

    public ref struct ManagedToUnmanagedIn
    {
        public static int BufferSize => 0x100;

        private byte* _native;
        private bool _allocated;

        public void FromManaged(string? managed, Span<byte> buffer) =>
            _native = managed is null
                ? null
                : NlsStringMarshaller.Encode(managed, buffer, Enc, "the file system encoding", out _allocated);

        public readonly byte* ToUnmanaged() => _native;

        public readonly void Free()
        {
            if (_allocated)
                Marshal.FreeHGlobal((IntPtr)_native);
        }
    }

    private static Encoding InitializeEncoding()
    {
        var encoding = (Encoding)((OperatingSystem.IsWindows() ? CodePagesEncodingProvider.Instance.GetEncoding(0) : null)
            ?? Encoding.UTF8).Clone();
        encoding.EncoderFallback = EncoderFallback.ExceptionFallback;
        return encoding;
    }
}
