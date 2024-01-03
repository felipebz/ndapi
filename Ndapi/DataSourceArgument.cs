using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a data source argument.
/// </summary>
public class DataSourceArgument : NdapiObject<DataSourceArgument>
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
    public DataSourceArgumentMode Mode
    {
        get => GetNumberProperty<DataSourceArgumentMode>(NdapiConstant.D2FP_DSA_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_DSA_MODE, value);
    }

    /// <summary>
    /// Gets or sets the data source argument name.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_NAM)]
    public override string Name
    {
        get => GetStringProperty(NdapiConstant.D2FP_DSA_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_DSA_NAM, value);
    }

    /// <summary>
    /// Gets or sets the data source argument type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_TYP)]
    public DataSourceColumnType Type
    {
        get => GetNumberProperty<DataSourceColumnType>(NdapiConstant.D2FP_DSA_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_DSA_TYP, value);
    }

    /// <summary>
    /// Gets or sets name of the data source argument type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_TYP_NAM)]
    public string TypeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_DSA_TYP_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_DSA_TYP_NAM, value);
    }

    /// <summary>
    /// Gets or sets the data source argument value.
    /// </summary>
    [Property(NdapiConstant.D2FP_DSA_VAL)]
    public string Value
    {
        get => GetStringProperty(NdapiConstant.D2FP_DSA_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_DSA_VAL, value);
    }
}
