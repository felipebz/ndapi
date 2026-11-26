using Ndapi.Core;

using Xunit;

namespace Ndapi.Tests;

// Needs NLS_LANG with a single-byte charset (e.g. BRAZILIAN PORTUGUESE_BRAZIL.WE8ISO8859P1).
public class NlsStringMarshallerTests
{
    [Fact]
    public void TextInTheModuleCharsetRoundTrips()
    {
        Sta.Run(() =>
        {
            using var module = new FormModule("NLS_OK");
            var item = new Item(new Block(module, "B"), "I");
            item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "Ação código");
            Assert.Equal("Ação código", item.GetStringProperty(NdapiConstant.D2FP_PRMPT));
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
            using var module = new FormModule("NLS_LONG");
            module.Comment = text;
            Assert.Equal(text, module.Comment);
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

            using var module = new FormModule("NLS_BAD");
            var item = new Item(new Block(module, "B"), "I");
            item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "antes");

            var error = Assert.Throws<NdapiException>(() => item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "ok ✓"));
            Assert.Contains("U+2713", error.Message);
            Assert.Equal("antes", item.GetStringProperty(NdapiConstant.D2FP_PRMPT)); // nothing written
        });
    }
}
