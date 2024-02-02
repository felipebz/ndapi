using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a coordinate declaration.
/// </summary>
public class Coordinate : NdapiObject<Coordinate>
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
    public int CharacterCellHeight
    {
        get => GetNumberProperty(NdapiConstant.D2FP_CHAR_CELL_HGT);
        set => SetNumberProperty(NdapiConstant.D2FP_CHAR_CELL_HGT, value);
    }

    /// <summary>
    /// Gets or sets the width of the character cell.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_CELL_WID)]
    public int CharacterCellWidth
    {
        get => GetNumberProperty(NdapiConstant.D2FP_CHAR_CELL_WID);
        set => SetNumberProperty(NdapiConstant.D2FP_CHAR_CELL_WID, value);
    }

    /// <summary>
    /// Gets or sets the coordinate system.
    /// </summary>
    [Property(NdapiConstant.D2FP_COORD_SYS)]
    public CoordinateSystem CoordinateSystem
    {
        get => GetNumberProperty<CoordinateSystem>(NdapiConstant.D2FP_COORD_SYS);
        set => SetNumberProperty(NdapiConstant.D2FP_COORD_SYS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should use the default font scaling method.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_FNT_SCALING)]
    public bool IsDefaultFontScaling
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DFLT_FNT_SCALING);
        set => SetBooleanProperty(NdapiConstant.D2FP_DFLT_FNT_SCALING, value);
    }

    /// <summary>
    /// Gets or sets the real unit.
    /// </summary>
    [Property(NdapiConstant.D2FP_REAL_UNIT)]
    public RealUnit RealUnit
    {
        get => GetNumberProperty<RealUnit>(NdapiConstant.D2FP_REAL_UNIT);
        set => SetNumberProperty(NdapiConstant.D2FP_REAL_UNIT, value);
    }

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
