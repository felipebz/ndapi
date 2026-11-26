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
    public void CreatingAnEventOnForms6FailsClearly()
    {
        Sta.Run(() =>
        {
            Assert.SkipUnless(NdapiContext.BuilderVersion.MajorVersion == 6, "events exist from Forms 12c on");
            var form = new FormModule("NO_EVENT_FMB");

            var error = Assert.Throws<NdapiException>(() => new Event(form, "EVT"));

            Assert.Contains("D2FFO_EVENT", error.Message);
            Assert.Contains("not supported", error.Message);
            form.Destroy();
        });
    }

    [Fact]
    public void CreatingAMenuParameterAfterForms6FailsClearly()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion == 6, "menu parameters exist on Forms 6i");
            var menu = new MenuModule("NO_PARAM_MMB");

            var error = Assert.Throws<NdapiException>(() => new MenuParameter(menu, "MPM"));

            Assert.Contains("D2FFO_MENU_PARAM", error.Message);
            Assert.Contains("not supported", error.Message);
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

    [Fact]
    public void BiPublisherReportSettingsSurviveSaveAndReopen()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");

            var path = Path.Join(Path.GetTempPath(), $"bip_{Guid.NewGuid():N}.fmb");
            var module = new FormModule("BIP_SAVE");
            _ = new Report(module, "RPT")
            {
                ReportObjectType = 1,
                ReportPath = "/Sample/Emp.xdo",
                DeliveryType = 4,
                FtpServer = "ftp1",
                SecureFtp = true,
                NumberOfCopies = 3,
                PrintSide = 2,
                WebDavAuthenticationType = 2
            };
            module.Save(path);
            module.Destroy();

            var reopened = FormModule.Open(path);
            try
            {
                var report = Assert.Single(reopened.Reports);
                Assert.Equal(1, report.ReportObjectType);
                Assert.Equal("/Sample/Emp.xdo", report.ReportPath);
                Assert.Equal(4, report.DeliveryType);
                Assert.Equal("ftp1", report.FtpServer);
                Assert.True(report.SecureFtp);
                Assert.Equal(3, report.NumberOfCopies);
                Assert.Equal(2, report.PrintSide);
                Assert.Equal(2, report.WebDavAuthenticationType);
            }
            finally
            {
                reopened.Destroy();
                File.Delete(path);
            }
        });
    }

    [Fact]
    public void ObjectReferencesSurviveSaveAndReopen()
    {
        Sta.Run(() =>
        {
            var path = Path.Join(Path.GetTempPath(), $"refs_{Guid.NewGuid():N}.fmb");
            var module = new FormModule("REFS_SAVE");
            var canvas = new Canvas(module, "CNV");
            var group = new RecordGroup(module, "RG");
            var first = new Block(module, "B1");
            var second = new Block(module, "B2");
            first.NextNavigationBlock = second;
            first.ScrollBarCanvas = canvas;
            _ = new Item(first, "TREE") { ItemType = ItemType.Tree, RecordGroup = group, ShowLines = false };
            module.Save(path);
            module.Destroy();

            var reopened = FormModule.Open(path);
            try
            {
                var block = reopened.Blocks.Single(b => b.Name == "B1");
                Assert.Equal("B2", block.NextNavigationBlock?.Name);
                Assert.Equal("B2", block.NextNavigationBlockName);
                Assert.Equal("CNV", block.ScrollBarCanvas?.Name);
                var tree = Assert.Single(block.Items);
                Assert.Equal("RG", tree.RecordGroup?.Name);
                Assert.Equal("RG", tree.RecordGroupName);
                Assert.False(tree.ShowLines);
            }
            finally
            {
                reopened.Destroy();
                File.Delete(path);
            }
        });
    }

    [Fact]
    public void StringIdsMustBeUniqueWithinTheModule()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("STRING_IDS");
            var item = new Item(new Block(module, "B"), "I") { Prompt = "P", Hint = "H" };

            item.PromptStringId = 42;

            Assert.Equal(42, item.PromptStringId);
            var error = Assert.Throws<NdapiException>(() => item.HintStringId = 42);
            Assert.Equal(FormsErrorCode.DuplicateStringId, error.ErrorCode);
            module.Destroy();
        });
    }

    [Fact]
    public void ObjectsKnowTheirModuleAndSubclassSource()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("SUBCLASS_SRC");
            var propertyClass = new PropertyClass(module, "PC");
            var alert = new Alert(module, "A");

            alert.Subclass(propertyClass);

            Assert.Same(module, alert.Module);
            Assert.Equal("PC", alert.Source?.Name);
            Assert.True(alert.IsDirty);
            module.Destroy();
        });
    }

    [Fact]
    public void DisposingAModuleUnloadsItSoItCanBeReopened()
    {
        Sta.Run(() =>
        {
            var path = Path.Join(Path.GetTempPath(), $"dispose_{Guid.NewGuid():N}.fmb");
            using (var module = new FormModule("DISPOSE_REOPEN"))
            {
                module.Save(path);
            }

            try
            {
                using (var first = FormModule.Open(path))
                {
                    Assert.Equal("DISPOSE_REOPEN", first.Name);
                }

                using var second = FormModule.Open(path);
                Assert.DoesNotContain(NdapiContext.Modules, m => m.Name == "DISPOSE_REOPEN" && m != second);
            }
            finally
            {
                File.Delete(path);
            }
        });
    }

    [Fact]
    public void ObjectsReturnTheModuleInstanceThatOpenedOrCreatedIt()
    {
        Sta.Run(() =>
        {
            var path = Path.Join(Path.GetTempPath(), $"identity_{Guid.NewGuid():N}.fmb");
            var created = new FormModule("MODULE_IDENTITY");
            var block = new Block(created, "B");
            new Block(created, "TMP").Destroy();

            Assert.Same(created, block.Module);
            created.Save(path);
            created.Destroy();
            created.Destroy();

            try
            {
                using var opened = FormModule.Open(path);
                var reopenedBlock = Assert.Single(opened.Blocks);

                Assert.Same(opened, reopenedBlock.Module);
                Assert.Same(opened, new Item(reopenedBlock, "I").Module);
            }
            finally
            {
                File.Delete(path);
            }
        });
    }

    [Fact]
    public void MoveWithoutNextObjectMovesToTheEnd()
    {
        Sta.Run(() =>
        {
            using var module = new FormModule("MOVE_ORDER");
            var first = new Block(module, "B1");
            _ = new Block(module, "B2");
            var third = new Block(module, "B3");

            first.Move(null);
            Assert.Equal(["B2", "B3", "B1"], module.Blocks.Select(b => b.Name));

            first.Move(third);
            Assert.Equal(["B2", "B1", "B3"], module.Blocks.Select(b => b.Name));
        });
    }

    [Fact]
    public void ADestroyedObjectCanNoLongerReachForms()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("DESTROYED");
            var alert = new Alert(module, "ALT");
            alert.Destroy();

            Assert.Throws<ObjectDisposedException>(() => alert.Title);
            Assert.Throws<ObjectDisposedException>(alert.Destroy);
            Assert.Equal("", alert.ToString());
            module.Destroy();
            module.Destroy();
        });
    }

    // the PL/SQL text is cached (reading it leaks native memory): the typed property and the generic accessors
    // must see the same value
    [Fact]
    public void PlsqlTextIsTheSameThroughTypedAndGenericAccess()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("PLSQL_TEXT");
            var trigger = new Trigger(module, "WHEN-NEW-FORM-INSTANCE") { Text = "null;" };

            trigger.SetStringProperty(NdapiConstant.D2FP_TRG_TXT, "message('x');");
            Assert.Equal("message('x');", trigger.Text);

            trigger.Text = "begin null; end;";
            Assert.Equal("begin null; end;", trigger.GetStringProperty(NdapiConstant.D2FP_TRG_TXT));
            module.Destroy();
        });
    }
}
