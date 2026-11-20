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
