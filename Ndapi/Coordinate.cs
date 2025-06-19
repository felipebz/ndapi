using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a coordinate declaration.
/// </summary>
public partial class Coordinate : NdapiObject<Coordinate>
{
    /// <summary>
    /// Creates a coordinate declaration
    /// </summary>
    public Coordinate() : base(ObjectType.Coordinate)
    {
        Handle = new ObjectSafeHandle();
        var status = NativeMethods.d2fcrdcr_Create(NdapiContext.GetContext(), out Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Extracts the coordinate declaration from a form module
    /// </summary>
    /// <param name="module">Form module.</param>
    public Coordinate(FormModule module) : this()
    {
        Extract(module);
    }

    internal Coordinate(ObjectSafeHandle handle) : base(handle, ObjectType.Coordinate)
    {
    }

    /// <summary>
    /// Gets or sets the height of the character cell.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_CELL_HGT)]
    public partial int CharacterCellHeight { get; set; }

    /// <summary>
    /// Gets or sets the width of the character cell.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_CELL_WID)]
    public partial int CharacterCellWidth { get; set; }

    /// <summary>
    /// Gets or sets the coordinate system.
    /// </summary>
    [Property(NdapiConstant.D2FP_COORD_SYS)]
    public partial CoordinateSystem CoordinateSystem { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should use the default font scaling method.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_FNT_SCALING)]
    public partial bool IsDefaultFontScaling { get; set; }

    /// <summary>
    /// Gets or sets the real unit.
    /// </summary>
    [Property(NdapiConstant.D2FP_REAL_UNIT)]
    public partial RealUnit RealUnit { get; set; }

    /// <summary>
    /// Extract the coordinate declaration from the specified form module.
    /// </summary>
    /// <param name="module">Form module.</param>
    public void Extract(FormModule module)
    {
        var status = NativeMethods.d2fcrdex_Extract(NdapiContext.GetContext(), Handle, module.Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Apply the coordinate declaration to the specified form module.
    /// </summary>
    /// <param name="module">Form module to be changed.</param>
    public void Apply(FormModule module)
    {
        var status = NativeMethods.d2fcrdap_Apply(NdapiContext.GetContext(), Handle, module.Handle);
        Ensure.Success(status);
    }
}
