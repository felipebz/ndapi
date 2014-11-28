using NUnit.Framework;

namespace Ndapi.Tests
{
    public class NdapiContextTests
    {
        [Test]
        public void Get_ProductVersion()
        {
            var version = NdapiContext.ProductVersion;
            Assert.Greater(version, 0);
        }
    }
}
