using NdapiManaged;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
