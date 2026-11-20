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
    public void PropertiesIntroducedInForms14RoundTripEveryValue()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 14, "requires Forms 14");

            var module = new FormModule("FORMS14_PROP");
            var block = new Block(module, "B");
            var item = new Item(block, "I") { ItemType = ItemType.TextItem, Placeholder = "type here" };
            Assert.Equal("type here", item.Placeholder);

            RoundTrip<UiStyle>(v => item.UiStyle = v, () => item.UiStyle);
            RoundTrip<DisplayItemUiStyle>(v => item.DisplayItemUiStyle = v, () => item.DisplayItemUiStyle);
            RoundTrip<ProgressBarOrientation>(v => item.ProgressBarOrientation = v, () => item.ProgressBarOrientation);
            RoundTrip<ForegroundColorMode>(v => item.ForegroundColorMode = v, () => item.ForegroundColorMode);
            RoundTrip<IconLabelPosition>(v => item.LabelOnIconicButton = v, () => item.LabelOnIconicButton);
            RoundTrip<RoundSide>(v => item.RoundedCornerEnd = v, () => item.RoundedCornerEnd);
            RoundTrip<ItemRecordOrientation>(v => item.RecordOrientation = v, () => item.RecordOrientation);
            RoundTrip<DataLengthSemantics>(v => item.DataLengthSemantics = v, () => item.DataLengthSemantics);
            RoundTrip<GradientStartSide>(v => item.GradientStartSide = v, () => item.GradientStartSide);

            item.DataType = ItemDataType.NChar;
            Assert.Equal(ItemDataType.NChar, item.DataType);

            var list = new Item(block, "L") { ItemType = ItemType.ListItem, ListStyle = ListStyle.Slider };
            Assert.Equal(ListStyle.Slider, list.ListStyle);
            list.ListStyle = ListStyle.SpinList;
            Assert.Equal(ListStyle.SpinList, list.ListStyle);

            var evt = new Event(module, "EVT") { EventType = EventType.SystemMdiResize };
            Assert.Equal(EventType.SystemMdiResize, evt.EventType);
            module.Destroy();
        });
    }

    [Fact]
    public void DataSourceTypesIntroducedInForms12RoundTrip()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");

            var module = new FormModule("NATIONAL_TYPES");
            var block = new Block(module, "B") { QueryDataSourceType = QueryDataSourceType.Procedure };
            var column = new DataSourceColumn(block, DataSourceOperation.Query, "C");

            foreach (var type in new[] { DataSourceColumnType.NVarchar2, DataSourceColumnType.NChar, DataSourceColumnType.NClob })
            {
                column.Type = type;
                Assert.Equal(type, column.Type);
            }

            module.Destroy();
        });
    }

    private static void RoundTrip<T>(Action<T> set, Func<T> get) where T : struct, Enum
    {
        foreach (var value in Enum.GetValues<T>())
        {
            set(value);
            Assert.Equal(value, get());
        }
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

    [Fact]
    public void DataSourceObjectsAreCreatedInTheListOfTheirOperation()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("DATA_SOURCE");
            var block = new Block(module, "B") { QueryDataSourceType = QueryDataSourceType.Procedure };
            (DataSourceOperation Operation, Func<IEnumerable<DataSourceArgument>> Arguments,
                Func<IEnumerable<DataSourceColumn>> Columns)[] lists =
            [
                (DataSourceOperation.Query, () => block.QueryDataSourceArguments, () => block.QueryDataSourceColumns),
                (DataSourceOperation.Insert, () => block.InsertDataSourceArguments, () => block.InsertDataSourceColumns),
                (DataSourceOperation.Update, () => block.UpdateDataSourceArguments, () => block.UpdateDataSourceColumns),
                (DataSourceOperation.Delete, () => block.DeleteDataSourceArguments, () => block.DeleteDataSourceColumns)
            ];

            foreach (var (operation, arguments, columns) in lists)
            {
                _ = new DataSourceArgument(block, operation, $"ARG_{operation}");
                _ = new DataSourceColumn(block, operation, $"COL_{operation}");

                Assert.Equal($"ARG_{operation}", Assert.Single(arguments()).Name);
                Assert.Equal($"COL_{operation}", Assert.Single(columns()).Name);
            }

            _ = new DataSourceArgument(block, DataSourceOperation.Lock, "ARG_LOCK");
            _ = new DataSourceColumn(block, DataSourceOperation.Lock, "COL_LOCK");
            module.Destroy();
        });
    }

    [Fact]
    public void QueryNameUsesTheConstantOfTheRunningBuilder()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("QUERY_NAME");
            var item = new Item(new Block(module, "B"), "I");

            item.QueryName = "Q1";

            Assert.Equal("Q1", item.QueryName);
            module.Destroy();
        });
    }

    [Fact]
    public void DeferRequiredEnforcementAcceptsTheThreeSettings()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("DEFER_REQ");

            Assert.Equal(1, module.DeferRequiredEnforcement);
            module.DeferRequiredEnforcement = 2;
            Assert.Equal(2, module.DeferRequiredEnforcement);
            module.Destroy();
        });
    }
}
