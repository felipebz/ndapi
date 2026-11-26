using System.Runtime.InteropServices;
using System.Text;

using Ndapi.Core;

using Xunit;

namespace Ndapi.UnitTests;

// ASCII text only: it encodes to the same bytes in every charset NLS_LANG may name
public class NlsStringMarshallerTests
{
    [Theory]
    [InlineData("WE8MSWIN1252", 1252)]
    [InlineData("ee8mswin1250", 1250)]
    [InlineData("KO16MSWIN949", 949)]
    [InlineData("WE8PC850", 850)]
    [InlineData("WE8ISO8859P1", 28591)]
    [InlineData("WE8ISO8859P15", 28605)]
    [InlineData("AL32UTF8", 65001)]
    [InlineData("US7ASCII", 20127)]
    [InlineData("JA16SJIS", 932)]
    public void OracleCharsetsMapToTheirCodePage(string charset, int codePage)
    {
        Assert.Equal(codePage, NlsStringMarshaller.GetEncoding(charset)?.CodePage);
    }

    [Theory]
    [InlineData("WE8DEC")]
    [InlineData("WE8MSWIN9999")]
    public void CharsetsWithoutDotNetEquivalentHaveNoEncoding(string charset)
    {
        Assert.Null(NlsStringMarshaller.GetEncoding(charset));
    }

    // the marshaller encodes into a 256-byte stack buffer and falls back to native memory past it
    [Theory]
    [InlineData(0)]
    [InlineData(255)]
    [InlineData(256)]
    [InlineData(4000)]
    public unsafe void StringsAreNullTerminatedWhetherOrNotTheyFitTheStackBuffer(int length)
    {
        var text = new string('x', length);
        scoped var marshaller = new NlsStringMarshaller.ManagedToUnmanagedIn();
        try
        {
            marshaller.FromManaged(text, stackalloc byte[NlsStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

            var native = MemoryMarshal.CreateReadOnlySpanFromNullTerminated(marshaller.ToUnmanaged());
            Assert.Equal(text, Encoding.ASCII.GetString(native));
        }
        finally
        {
            marshaller.Free();
        }
    }

    [Fact]
    public unsafe void NullIsPassedAsANullPointer()
    {
        scoped var marshaller = new NlsStringMarshaller.ManagedToUnmanagedIn();
        marshaller.FromManaged(null, stackalloc byte[NlsStringMarshaller.ManagedToUnmanagedIn.BufferSize]);

        Assert.True(marshaller.ToUnmanaged() == null);
        marshaller.Free();
    }

    [Theory]
    [InlineData("")]
    [InlineData("PROCEDURE P IS BEGIN NULL; END;")]
    public void NativeStringsAreReadBack(string text)
    {
        var bytes = Encoding.ASCII.GetBytes(text + "\0");
        var native = Marshal.AllocHGlobal(bytes.Length);
        Marshal.Copy(bytes, 0, native, bytes.Length);

        Assert.Equal(text, NlsStringMarshaller.ReadNlsStringAndFree(native));
    }

    [Fact]
    public void NullPointerIsReadAsNull()
    {
        Assert.Null(NlsStringMarshaller.ReadNlsStringAndFree(IntPtr.Zero));
    }
}
