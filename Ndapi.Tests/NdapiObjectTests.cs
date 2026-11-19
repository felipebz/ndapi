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
}
