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
    /// Creates a data source argument.
    /// </summary>
    /// <param name="block">Block object.</param>
    /// <param name="name">Data source argument name.</param>
    public DataSourceArgument(Block block, string name) : base(name, ObjectType.DataSourceArgument, block)
    {
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
}
