using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a form parameter.
/// </summary>
public partial class FormParameter : NdapiObject<FormParameter>
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
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public partial int MaximumLength { get; set; }

    /// <summary>
    /// Gets or sets the parameter data type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PARAM_DAT_TYP)]
    public partial ParameterDataType DataType { get; set; }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_PARAM_INIT_VAL)]
    public partial string InitialValue { get; set; }
}
