using Ndapi.Core;
using Ndapi.Enums;

using Xunit;

namespace Ndapi.Tests;

public class NdapiObjectTests
{
    // a static record group column points to its values through D2FP_COLUMN_VALUE, an object type Ndapi has no
    // class for: reading it must fail with an NdapiException that says so, not an InvalidOperationException
    [Fact]
    public void ObjectPropertyOfATypeWithoutClassFailsClearly()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("NO_CLASS");
            var group = new RecordGroup(module, "RG") { Type = RecordGroupType.Static };
            var column = group.CreateRecordGroupColumn("C");
            column.DataType = ColumnSpecificationDataType.Char;
            column.MaximumLength = 10;
            column.AddValueAt(1, "A");

            var error = Assert.Throws<NdapiException>(() => column.GetObjectProperty<NdapiObject>(NdapiConstant.D2FP_COLUMN_VALUE));
            Assert.Contains("no class for the object type", error.Message);
            module.Destroy();
        });
    }

    [Fact]
    public void PropertyIntroducedInForms14CanBeUsedOnForms14()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 14, "D2FP_PLACEHOLDER_TEXT requires Forms 14");

            var module = new FormModule("FORMS14_PROP");
            var item = new Item(new Block(module, "B"), "I") { ItemType = ItemType.TextItem };

            item.SetStringProperty(NdapiConstant.D2FP_PLACEHOLDER_TEXT, "type here");

            Assert.Equal("type here", item.GetStringProperty(NdapiConstant.D2FP_PLACEHOLDER_TEXT));
            module.Destroy();
        });
    }

    [Fact]
    public void CreatingAnObjectTypeTheBuilderLacksFailsClearly()
    {
        Sta.Run(() =>
        {
            var is6 = NdapiContext.BuilderVersion.MajorVersion == 6;
            var form = new FormModule("NO_TYPE_FMB");
            var menu = new MenuModule("NO_TYPE_MMB");

            var error = Assert.Throws<NdapiException>(() =>
            {
                if (is6)
                {
                    _ = new Event(form, "EVT");
                }
                else
                {
                    _ = new MenuParameter(menu, "MPM");
                }
            });

            Assert.Contains(is6 ? "D2FFO_EVENT" : "D2FFO_MENU_PARAM", error.Message);
            Assert.Contains("not supported", error.Message);
            form.Destroy();
            menu.Destroy();
        });
    }
}
