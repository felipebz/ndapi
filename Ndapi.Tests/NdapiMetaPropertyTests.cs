using Ndapi.Core;
using Ndapi.Enums;
using Ndapi.Metadata;

using Xunit;

namespace Ndapi.Tests;

public class NdapiMetaPropertyTests
{
    [Fact]
    public void AllowedValuesMapsNativeValuesToMemberNames()
    {
        Sta.Run(() =>
        {
            var dataType = NdapiMetadata.GetMetaObjectFrom(typeof(Item)).AllProperties
                .Single(p => p.PropertyId == NdapiConstant.D2FP_DAT_TYP);

            using var module = new FormModule("ALLOWED_VALUES");
            var item = new Item(new Block(module, "B"), "I") { DataType = ItemDataType.Number };
            var native = item.GetNumberProperty(NdapiConstant.D2FP_DAT_TYP);

            Assert.Equal(nameof(ItemDataType.Number), dataType.AllowedValues[native]);
        });
    }

    [Fact]
    public void AllowedValuesHasANameForEveryValue()
    {
        Sta.Run(() =>
        {
            var enumProperties = NdapiMetadata.Classes
                .SelectMany(c => NdapiMetadata.GetMetaObjectFrom(c).AllProperties)
                .Where(p => p.AcceptConstants);

            foreach (var property in enumProperties)
            {
                Assert.NotEmpty(property.AllowedValues);
                Assert.All(property.AllowedValues.Values, name => Assert.False(string.IsNullOrEmpty(name)));
            }
        });
    }
}
