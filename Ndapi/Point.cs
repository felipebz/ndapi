using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a point object.
/// </summary>
public class Point : NdapiObject<Point>
{
    /// <summary>
    /// Creates a point.
    /// </summary>
    /// <param name="graphics">Point owner.</param>
    /// <param name="name">Point name.</param>
    public Point(Graphics graphics, string name) : base(name, ObjectType.Point, graphics)
    {
    }

    internal Point(ObjectSafeHandle handle) : base(handle, ObjectType.Point)
    {
    }

    /// <summary>
    /// Gets or sets the X position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstants.D2FP_X_POS)]
    public int XPosition
    {
        get => GetNumberProperty(NdapiConstants.D2FP_X_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstants.D2FP_Y_POS)]
    public int YPosition
    {
        get => GetNumberProperty(NdapiConstants.D2FP_Y_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_Y_POS, value);
    }
}
