using System;

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
    /// Creates a data source column in the block's column list for the given operation.
    /// </summary>
    /// <param name="block">Block object.</param>
    /// <param name="operation">Operation whose procedure data source owns the column.</param>
    /// <param name="name">Data source column name.</param>
    public DataSourceColumn(Block block, DataSourceOperation operation, string name)
        : base(Create(block, operation), ObjectType.DataSourceColumn)
    {
        Name = name;
    }

    private static ObjectSafeHandle Create(Block block, DataSourceOperation operation)
    {
        var list = operation switch
        {
            DataSourceOperation.Query => NdapiConstant.D2FP_QRY_DAT_SRC_COL,
            DataSourceOperation.Insert => NdapiConstant.D2FP_INS_DAT_SRC_COL,
            DataSourceOperation.Update => NdapiConstant.D2FP_UPD_DAT_SRC_COL,
            DataSourceOperation.Delete => NdapiConstant.D2FP_DEL_DAT_SRC_COL,
            DataSourceOperation.Lock => NdapiConstant.D2FP_LOCK_DAT_SRC_COL,
            _ => throw new ArgumentOutOfRangeException(nameof(operation))
        };
        var status = NativeMethods.d2fdsccr_Create(NdapiContext.GetContext(), block.Handle, out var handle,
            (ushort)ConstantConverter.GetValue(list));
        Ensure.Success(status);
        return handle;
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

    /// <summary>
    /// Gets or sets whether the column has no child columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_NOCHILDREN)]
    public partial bool HasNoChildren { get; set; }

    /// <summary>
    /// Gets or sets the name of the parent column.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSC_PARENT_NAME)]
    public partial string ParentColumnName { get; set; }
}
