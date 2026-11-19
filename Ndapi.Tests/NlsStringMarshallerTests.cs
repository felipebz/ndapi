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
            var module = new FormModule("NLS_OK");
            var item = new Item(new Block(module, "B"), "I");
            item.SetStringProperty(NdapiConstant.D2FP_PRMPT, "Ação código");
            Assert.Equal("Ação código", item.GetStringProperty(NdapiConstant.D2FP_PRMPT));
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
