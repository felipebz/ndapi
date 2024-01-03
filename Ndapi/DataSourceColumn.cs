using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a data source column.
/// </summary>
public class DataSourceColumn : NdapiObject<DataSourceColumn>
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
    public int Length
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DSC_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_DSC_LEN, value);
    }

    /// <summary>
    /// Gets or sets whether the data source column is mandatory.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_MANDATORY)]
    public bool IsMandatory
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DSC_MANDATORY);
        set => SetBooleanProperty(NdapiConstant.D2FP_DSC_MANDATORY, value);
    }

    /// <summary>
    /// Gets or sets the data source column name.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_NAM)]
    public override string Name
    {
        get => GetStringProperty(NdapiConstant.D2FP_DSC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_DSC_NAM, value);
    }

    /// <summary>
    /// Gets or sets the data source column precision.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_PRECISION)]
    public int Precision
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DSC_PRECISION);
        set => SetNumberProperty(NdapiConstant.D2FP_DSC_PRECISION, value);
    }

    /// <summary>
    /// Gets or sets the data source column scale.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_SCALE)]
    public int Scale
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DSC_SCALE);
        set => SetNumberProperty(NdapiConstant.D2FP_DSC_SCALE, value);
    }

    /// <summary>
    /// Gets or sets the data source column type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_TYP)]
    public DataSourceColumnType Type
    {
        get => GetNumberProperty<DataSourceColumnType>(NdapiConstant.D2FP_DSC_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_DSC_TYP, value);
    }

    /// <summary>
    /// Gets or sets the name of the data source column type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_TYPE_NAME)]
    public string TypeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_DSC_TYPE_NAME);
        set => SetStringProperty(NdapiConstant.D2FP_DSC_TYPE_NAME, value);
    }
}
