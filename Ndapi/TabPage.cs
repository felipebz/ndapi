using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a tab page.
/// </summary>
public partial class TabPage : NdapiObject<TabPage>
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
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets whether the tab is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public partial bool IsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string Label { get; set; }

    /// <summary>
    /// Gets or sets whether the tab is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public partial bool IsVisible { get; set; }

    /// <summary>
    /// Gets or sets the side of the tab-page from where the gradient color begins
    /// or that there should be no gradient color used.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRADIENT_START)]
    public partial GradientStartSide GradientStartSide { get; set; }

    /// <summary>
    /// Gets all the graphic objects attached to the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRAPHIC)]
    public partial NdapiObjectList<Graphics> Graphics { get; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the fill pattern.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string FillPattern { get; set; }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public partial string ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the icon file name. Forms 14 and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public partial string IconFilename { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether the tab page is displayed white on black. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public partial bool IsWhiteOnBlack { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string CharacterModeLogicalAttribute { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL_STRID)]
    public partial int LabelStringId { get; set; }

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

    /// <summary>
    /// Gets or sets the name of the first-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL1OBJ_NAM)]
    public partial string ParentSourceLevel1ObjectName { get; set; }

    /// <summary>
    /// Gets or sets the type of the first-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL1OBJ_TYP)]
    public partial int ParentSourceLevel1ObjectType { get; set; }

    /// <summary>
    /// Creates a child graphics object.
    /// </summary>
    /// <param name="name">Name of the graphics object.</param>
    /// <returns>The child object.</returns>
    public Graphics CreateGraphics(string name) => new(this, name);
}
