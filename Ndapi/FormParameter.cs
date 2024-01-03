using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a form parameter.
/// </summary>
public class FormParameter : NdapiObject<FormParameter>
{
    /// <summary>
    /// Creates a parameter in the specified form module.
    /// </summary>
    /// <param name="module">Parameter owner.</param>
    /// <param name="name">Parameter name.</param>
    public FormParameter(FormModule module, string name) : base(name, ObjectType.FormParameter, module)
    {
    }

    internal FormParameter(ObjectSafeHandle handle) : base(handle, ObjectType.FormParameter)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public int MaximumLength
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_LEN, value);
    }

    /// <summary>
    /// Gets or sets the parameter data type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PARAM_DAT_TYP)]
    public ParameterDataType DataType
    {
        get => GetNumberProperty<ParameterDataType>(NdapiConstant.D2FP_PARAM_DAT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_PARAM_DAT_TYP, value);
    }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_PARAM_INIT_VAL)]
    public string InitialValue
    {
        get => GetStringProperty(NdapiConstant.D2FP_PARAM_INIT_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_PARAM_INIT_VAL, value);
    }
}
