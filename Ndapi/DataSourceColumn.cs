using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a data source column.
/// </summary>
public partial class DataSourceColumn : NdapiObject<DataSourceColumn>
{
    /// <summary>
    /// Creates a data source column.
    /// </summary>
    /// <param name="block">Block object.</param>
    /// <param name="name">Data source column name.</param>
    public DataSourceColumn(Block block, string name) : base(name, ObjectType.DataSourceColumn, block)
    {
    }

    internal DataSourceColumn(ObjectSafeHandle handle) : base(handle, ObjectType.DataSourceColumn)
    {
    }

    /// <summary>
    /// Gets or sets the data source column length.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_LEN)]
    public partial int Length { get; set; }

    /// <summary>
    /// Gets or sets whether the data source column is mandatory.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_MANDATORY)]
    public partial bool IsMandatory { get; set; }

    /// <summary>
    /// Gets or sets the data source column name.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_NAM)]
    public override partial string Name { get; set; }

    /// <summary>
    /// Gets or sets the data source column precision.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_PRECISION)]
    public partial int Precision { get; set; }

    /// <summary>
    /// Gets or sets the data source column scale.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_SCALE)]
    public partial int Scale { get; set; }

    /// <summary>
    /// Gets or sets the data source column type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_TYP)]
    public partial DataSourceColumnType Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the data source column type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_TYPE_NAME)]
    public partial string TypeName { get; set; }
}
