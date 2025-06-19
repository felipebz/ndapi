using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a column mapping for lists of values.
/// </summary>
public partial class ColumnMapping : NdapiObject<ColumnMapping>
{
    /// <summary>
    /// Creates a column mapping.
    /// </summary>
    /// <param name="lov">List of values.</param>
    /// <param name="name">Column name.</param>
    public ColumnMapping(Lov lov, string name) : base(name, ObjectType.ColumnMapping, lov)
    {
    }

    internal ColumnMapping(ObjectSafeHandle handle) : base(handle, ObjectType.ColumnMapping)
    {
    }

    /// <summary>
    /// Gets or sets the display width.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_WID)]
    public partial int DisplayWidth { get; set; }

    /// <summary>
    /// Gets or sets the return item.
    /// </summary>
    [Property(NdapiConstant.D2FP_RTRN_ITM)]
    public partial string ReturnItem { get; set; }

    /// <summary>
    /// Gets or sets the column title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public partial string Title { get; set; }
}
