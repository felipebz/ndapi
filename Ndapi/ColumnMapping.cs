using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a column mapping for lists of values.
/// </summary>
public class ColumnMapping : NdapiObject<ColumnMapping>
{
    /// <summary>
    /// Creates a column mapping.
    /// </summary>
    /// <param name="lov">List of values.</param>
    /// <param name="name">Column name.</param>
    public ColumnMapping(LOV lov, string name) : base(name, ObjectType.ColumnMapping, lov)
    {
    }

    internal ColumnMapping(ObjectSafeHandle handle) : base(handle, ObjectType.ColumnMapping)
    {
    }

    /// <summary>
    /// Gets or sets the display width.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_WID)]
    public int DisplayWidth
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DISP_WID);
        set => SetNumberProperty(NdapiConstant.D2FP_DISP_WID, value);
    }

    /// <summary>
    /// Gets or sets the return item.
    /// </summary>
    [Property(NdapiConstant.D2FP_RTRN_ITM)]
    public string ReturnItem
    {
        get => GetStringProperty(NdapiConstant.D2FP_RTRN_ITM);
        set => SetStringProperty(NdapiConstant.D2FP_RTRN_ITM, value);
    }

    /// <summary>
    /// Gets or sets the column title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public string Title
    {
        get => GetStringProperty(NdapiConstant.D2FP_TITLE);
        set => SetStringProperty(NdapiConstant.D2FP_TITLE, value);
    }
}
