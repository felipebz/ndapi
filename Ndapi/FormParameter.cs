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
    /// Gets or sets the maximum length. Forms 6i only.
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

    /// <summary>
    /// Gets or sets the translation string id of the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_PARAM_INIT_VAL_STRID)]
    public partial int InitialValueStringId { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject Source { get; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as part of an object group.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_OBJGRP)]
    public partial bool IsSubclassObjectGroup { get; set; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as a sub-object of a subclassed parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_SUBOBJ)]
    public partial bool IsSubclassSubObject { get; set; }
}
