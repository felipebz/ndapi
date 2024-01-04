using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a tab page.
/// </summary>
public class TabPage : NdapiObject<TabPage>
{
    /// <summary>
    /// Creates a tab page.
    /// </summary>
    /// <param name="canvas">Canvas object.</param>
    /// <param name="name">Tab page name.</param>
    public TabPage(Canvas canvas, string name) : base(name, ObjectType.TabPage, canvas)
    {
    }

    internal TabPage(ObjectSafeHandle handle) : base(handle, ObjectType.TabPage)
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
    /// Gets or sets whether the tab is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public bool IsEnabled
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ENABLED);
        set => SetBooleanProperty(NdapiConstant.D2FP_ENABLED, value);
    }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public string Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_LABEL);
        set => SetStringProperty(NdapiConstant.D2FP_LABEL, value);
    }

    /// <summary>
    /// Gets or sets whether the tab is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public bool IsVisible
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_VISIBLE);
        set => SetBooleanProperty(NdapiConstant.D2FP_VISIBLE, value);
    }

    /// <summary>
    /// Gets or sets the side of the tab-page from where the gradient color begins
    /// or that there should be no gradient color used.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRADIENT_START)]
    public GradientStartSide GradientStartSide
    {
        get => GetNumberProperty<GradientStartSide>(NdapiConstant.D2FP_GRADIENT_START);
        set => SetNumberProperty(NdapiConstant.D2FP_GRADIENT_START, value);
    }

    /// <summary>
    /// Gets all the graphic objects attached to the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRAPHIC)]
    public NdapiObjectList<Graphics> Graphics => GetObjectList<Graphics>(NdapiConstant.D2FP_GRAPHIC);

    /// <summary>
    /// Creates a child graphics object.
    /// </summary>
    /// <param name="name">Name of the graphics object.</param>
    /// <returns>The child object.</returns>
    public Graphics CreateGraphics(string name) => new(this, name);
}
