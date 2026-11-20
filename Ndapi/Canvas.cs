using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a canvas object.
/// </summary>
public partial class Canvas : NdapiObject<Canvas>
{
    /// <summary>
    /// Creates a canvas object.
    /// </summary>
    /// <param name="module">Canvas owner.</param>
    /// <param name="name">Canvas name.</param>
    public Canvas(FormModule module, string name) : base(name, ObjectType.Canvas, module)
    {
    }

    /// <summary>
    /// Creates a canvas object.
    /// </summary>
    /// <param name="group">Canvas owner.</param>
    /// <param name="name">Canvas name.</param>
    public Canvas(ObjectGroup group, string name) : base(name, ObjectType.Canvas, group)
    {
    }

    internal Canvas(ObjectSafeHandle handle) : base(handle, ObjectType.Canvas)
    {
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstant.D2FP_BEVEL)]
    public partial Bevel Bevel { get; set; }

    /// <summary>
    /// Gets or sets the canvas type.
    /// </summary>
    [Property(NdapiConstant.D2FP_CNV_TYP)]
    public partial CanvasType CanvasType { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string FillPattern { get; set; }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public partial string FontName { get; set; }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public partial int FontSize { get; set; }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public partial FontSpacing FontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public partial FontStyle FontStyle { get; set; }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public partial FontWeight FontWeight { get; set; }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public partial string ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstant.D2FP_HEIGHT)]
    public partial int Height { get; set; }

    /// <summary>
    /// Gets or sets the associated help book topic.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TOPIC)]
    public partial string HelpBookTopic { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the name of the popup object.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_NAM)]
    public partial string PopupMenuName { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display the canvas when the end user or the application
    /// navigates to an item on the canvas. 
    /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Tab"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_RAISE_ON_ENT)]
    public partial bool RaiseOnEntry { get; set; }

    /// <summary>
    /// Gets or sets the name of the splitter secondary canvas. A splitter allows two stacked canvases to share the
    /// same space on the screen at runtime. The splitter bar is used to adjust the amount of each canvas to show or
    /// hide. If this property is set to a non-null value, it means that this canvas (the primary splitter canvas) and
    /// the canvas specified by the property should be joined by a user-adjustable splitter bar. This splitter bar can
    /// be moved by the user with a mouse or programmatically.
    /// </summary>
    [Property(NdapiConstant.D2FP_SPLITTER_CANVAS)]
    public partial string SplitterSecondaryCanvasName { get; set; }

    /// <summary>
    /// Gets or sets whether the splitter bar separating two canvases can be repositioned by using the mouse to move it.
    /// The value of this property in the primary splitter canvas is the value that will be used at runtime. Even if
    /// the splitter bar is disabled, its location can still be modified programmatically
    /// </summary>
    [Property(NdapiConstant.D2FP_SPLITTER_ENABLED)]
    public partial bool SplitterBarEnabled { get; set; }

    /// <summary>
    /// Gets or sets the orientation of two canvases separated by a splitter bar. When set to horizontal, this canvas
    /// (the primary splitter canvas) will be to the left of a vertical splitter bar (when run in a left-to-right
    /// environment) with the secondary splitter canvas to the right of the bar. When set to vertical, this canvas will
    /// be above a horizontal splitter bar, with the secondary splitter canvas below the bar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SPLITTER_ORIENTATION)]
    public partial SplitterOrientation SplitterOrientation { get; set; }

    /// <summary>
    /// Gets or sets the location where tabs are attached to a tab canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_TAB_ATT_EDGE)]
    public partial TabAttachmentEdge TabAttachmentEdge { get; set; }

    /// <summary>
    /// Gets or sets the tab style.
    /// </summary>
    [Property(NdapiConstant.D2FP_TAB_STY)]
    public partial TabStyle TabStyle { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets whether the canvas is initially shown or hidden in the window to which it is assigned.
    /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public partial bool IsVisible { get; set; }

    /// <summary>
    /// Gets or sets the viewport height.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_HGT)]
    public partial int ViewportHeight { get; set; }

    /// <summary>
    /// Gets or sets the viewport width.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_WID)]
    public partial int ViewportWidth { get; set; }

    /// <summary>
    /// Gets or sets the X position of canvas's upper left corner relative to the upper left corner of the window's current content view. 
    /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_X_POS)]
    public partial int ViewportXPosition { get; set; }

    /// <summary>
    /// Gets or sets the X position of the view's upper left corner relative to the upper left corner of the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_X_POS_ON_CNV)]
    public partial int ViewportXPositionOnCanvas { get; set; }

    /// <summary>
    /// Gets or sets the Y position of canvas's upper left corner relative to the upper left corner of the window's current content view. 
    /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_Y_POS)]
    public partial int ViewportYPosition { get; set; }

    /// <summary>
    /// Gets or sets the Y position of the view's upper left corner relative to the upper left corner of the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_VPRT_Y_POS_ON_CNV)]
    public partial int ViewportYPositionOnCanvas { get; set; }

    /// <summary>
    /// Gets or sets the white-on-black property.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public partial bool IsWhiteOnBlack { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIDTH)]
    public partial int Width { get; set; }

    /// <summary>
    /// Gets or sets the window in which the canvas will be displayed at runtime.
    /// </summary>
    [Property(NdapiConstant.D2FP_WND_OBJ)]
    public partial Window Window { get; set; }

    /// <summary>
    /// Gets or sets the window name in which the canvas will be displayed at runtime.
    /// </summary>
    [Property(NdapiConstant.D2FP_WND_NAM)]
    public partial string WindowName { get; set; }

    /// <summary>
    /// Gets or sets the side of the canvas from where the gradient color begins
    /// or that there should be no gradient color used.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRADIENT_START)]
    public partial GradientStartSide GradientStartSide { get; set; }

    /// <summary>
    /// Gets all the graphics objects attached to the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRAPHIC)]
    public partial NdapiObjectList<Graphics> Graphics { get; }

    /// <summary>
    /// Gets all the tab pages associated with the current canvas.
    /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Tab"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_TAB_PAGE)]
    public partial NdapiObjectList<TabPage> TabPages { get; }

    /// <summary>
    /// Gets or sets whether the Builder's layout editor shows the viewport. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_VIEWPORT)]
    public partial bool DisplayViewport { get; set; }

    /// <summary>
    /// Gets or sets the popup menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_OBJ)]
    public partial Menu PopupMenu { get; set; }

    /// <summary>
    /// Gets or sets whether the canvas shows a horizontal scroll bar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR)]
    public partial bool ShowHorizontalScrollbar { get; set; }

    /// <summary>
    /// Gets or sets whether the canvas shows a vertical scroll bar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VERT_SCRLBR)]
    public partial bool ShowVerticalScrollbar { get; set; }

    /// <summary>
    /// Gets or sets how the label of the active tab is drawn: 0 = Normal, 1 = Bold.
    /// </summary>
    [Property(NdapiConstant.D2FP_TAB_ACT_STY)]
    public partial int ActiveStyle { get; set; }

    /// <summary>
    /// Gets or sets whether the tab width varies with its label: 0 = Fixed, 1 = Variable.
    /// </summary>
    [Property(NdapiConstant.D2FP_TAB_WID_STY)]
    public partial int WidthStyle { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string CharacterModeLogicalAttribute { get; set; }

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
    /// Creates a child graphics.
    /// </summary>
    /// <param name="name">Name of the child graphics.</param>
    /// <returns>The child object.</returns>
    public Graphics CreateGraphics(string name) => new(this, name);

    /// <summary>
    /// Creates a tab page.
    /// </summary>
    /// <param name="name">Name of the tab page.</param>
    /// <returns>The child object.</returns>
    public TabPage CreateTabPage(string name) => new(this, name);
}
