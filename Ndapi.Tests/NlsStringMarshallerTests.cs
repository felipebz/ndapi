using Ndapi.Core;

using Xunit;

namespace Ndapi.Tests;

// Needs NLS_LANG with a single-byte charset (e.g. BRAZILIAN PORTUGUESE_BRAZIL.WE8ISO8859P1).
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

    [Fact]
    public void TextInTheModuleCharsetRoundTrips()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("NLS_OK");
            var item = new Item(new Block(module, "B"), "I");
            item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "Ação código");
            Assert.Equal("Ação código", item.GetStringProperty(NdapiConstant.D2FP_PRMPT));
            module.Destroy();
        });
    }

    // the marshaller encodes into a 256-byte stack buffer and falls back to native memory past it
    [Theory]
    [InlineData(254)]
    [InlineData(255)]
    [InlineData(256)]
    [InlineData(4000)]
    public void TextAroundTheStackBufferSizeRoundTrips(int length)
    {
        Sta.Run(() =>
        {
            var text = string.Concat(Enumerable.Repeat("ação ", length / 5 + 1))[..length];
            var module = new FormModule("NLS_LONG");
            module.Comment = text;
            Assert.Equal(text, module.Comment);
            module.Destroy();
        });
    }

    [Fact]
    public void CharacterOutsideTheModuleCharsetIsRejectedInsteadOfReplaced()
    {
        Sta.Run(() =>
        {
            var nlsLang = Environment.GetEnvironmentVariable("NLS_LANG") ?? "";
            Assert.True(nlsLang.EndsWith("WE8ISO8859P1", StringComparison.OrdinalIgnoreCase),
                "this test expects NLS_LANG=...WE8ISO8859P1");

            var module = new FormModule("NLS_BAD");
            var item = new Item(new Block(module, "B"), "I");
            item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "antes");

            var error = Assert.Throws<NdapiException>(() => item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "ok ✓"));
            Assert.Contains("U+2713", error.Message);
            Assert.Equal("antes", item.GetStringProperty(NdapiConstant.D2FP_PRMPT)); // nothing written
            module.Destroy();
        });
    }
}
