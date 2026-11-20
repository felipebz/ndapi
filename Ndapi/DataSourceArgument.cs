using System;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a data source argument.
/// </summary>
public partial class DataSourceArgument : NdapiObject<DataSourceArgument>
{
    /// <summary>
    /// Creates a data source argument in the block's argument list for the given operation.
    /// </summary>
    /// <param name="block">Block object.</param>
    /// <param name="operation">Operation whose procedure data source owns the argument.</param>
    /// <param name="name">Data source argument name.</param>
    public DataSourceArgument(Block block, DataSourceOperation operation, string name)
        : base(Create(block, operation), ObjectType.DataSourceArgument)
    {
        Name = name;
    }

    private static ObjectSafeHandle Create(Block block, DataSourceOperation operation)
    {
        var list = operation switch
        {
            DataSourceOperation.Query => NdapiConstant.D2FP_QRY_DAT_SRC_ARG,
            DataSourceOperation.Insert => NdapiConstant.D2FP_INS_DAT_SRC_ARG,
            DataSourceOperation.Update => NdapiConstant.D2FP_UPD_DAT_SRC_ARG,
            DataSourceOperation.Delete => NdapiConstant.D2FP_DEL_DAT_SRC_ARG,
            DataSourceOperation.Lock => NdapiConstant.D2FP_LOCK_DAT_SRC_ARG,
            _ => throw new ArgumentOutOfRangeException(nameof(operation))
        };
        var status = NativeMethods.d2fdsacr_Create(NdapiContext.GetContext(), block.Handle, out var handle,
            (ushort)ConstantConverter.GetValue(list));
        Ensure.Success(status);
        return handle;
    }

    internal DataSourceArgument(ObjectSafeHandle handle) : base(handle, ObjectType.DataSourceArgument)
    {
    }

    /// <summary>
    /// Gets or sets data source argument mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_MODE)]
    public partial DataSourceArgumentMode Mode { get; set; }

    /// <summary>
    /// Gets or sets the data source argument name.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_NAM)]
    public override partial string Name { get; set; }

    /// <summary>
    /// Gets or sets the data source argument type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_TYP)]
    public partial DataSourceColumnType Type { get; set; }

    /// <summary>
    /// Gets or sets name of the data source argument type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_TYP_NAM)]
    public partial string TypeName { get; set; }

    /// <summary>
    /// Gets or sets the data source argument value.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_VAL)]
    public partial string Value { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }
}
