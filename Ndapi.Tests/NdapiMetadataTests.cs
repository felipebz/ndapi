using Ndapi.Core;
using Ndapi.Enums;
using Ndapi.Metadata;

using Xunit;

namespace Ndapi.Tests;

public class NdapiMetadataTests
{
    [Fact]
    public void SupportedPropertiesContainsOnlyRealObjectProperties()
    {
        Sta.Run(() =>
        {
            var properties = NdapiMetadata.SupportedProperties;

            Assert.Contains(NdapiConstant.D2FP_NAME, properties);
            Assert.Contains(NdapiConstant.D2FP_REC_GRP_QRY, properties);
            Assert.DoesNotContain(NdapiConstant.D2FP_TYP_TEXT, properties);
            Assert.DoesNotContain(NdapiConstant.D2FP_MAX, properties);
            Assert.DoesNotContain(NdapiConstant.D2FP_NONE, properties);
            Assert.DoesNotContain(NdapiConstant.D2FP_UNDEFINED, properties);
            Assert.DoesNotContain(properties, p => !p.ToString().StartsWith("D2FP_"));
            Assert.Equal(properties.Count, properties.Distinct().Count());
        });
    }

    [Fact]
    public void EverySupportedPropertyIsKnownByTheNativeApi()
    {
        Sta.Run(() =>
        {
            // pointer-valued properties have no D2FP_TYP_* of their own
            NdapiConstant[] pointerProperties =
                [NdapiConstant.D2FP_CLIENT_INFO, NdapiConstant.D2FP_LIST_ELEM, NdapiConstant.D2FP_PERSIST_CLIENT_INFO];

            foreach (var property in NdapiMetadata.SupportedProperties)
            {
                Assert.Equal(pointerProperties.Contains(property),
                    NdapiMetaProperty.GetPropertyType(property) == PropertyType.Unknown);
            }
        });
    }

    [Fact]
    public void SupportedPropertiesIncludesEveryTypedMember()
    {
        Sta.Run(() =>
        {
            var supported = NdapiMetadata.SupportedProperties.ToHashSet();
            var typed = NdapiMetadata.Classes
                .SelectMany(c => NdapiMetadata.GetMetaObjectFrom(c).AllProperties)
                .Select(p => p.PropertyId)
                .Distinct();

            Assert.All(typed, p => Assert.Contains(p, supported));
        });
    }

    [Fact]
    public void SupportedPropertiesExposesPropertiesWithoutTypedMember()
    {
        Sta.Run(() =>
        {
            var typed = NdapiMetadata.Classes
                .SelectMany(c => NdapiMetadata.GetMetaObjectFrom(c).AllProperties)
                .Select(p => p.PropertyId)
                .ToHashSet();

            Assert.DoesNotContain(NdapiConstant.D2FP_PERSIST_CLT_INF_LEN, typed);
            Assert.Contains(NdapiConstant.D2FP_PERSIST_CLT_INF_LEN, NdapiMetadata.SupportedProperties);

            var module = new FormModule("META_TEST");
            Assert.True(module.HasProperty(NdapiConstant.D2FP_PERSIST_CLT_INF_LEN));
            module.Destroy();
        });
    }
}
