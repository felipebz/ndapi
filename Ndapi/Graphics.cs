using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a graphics opbject.
/// </summary>
public partial class Graphics : NdapiObject<Graphics>
{
    /// <summary>
    /// Creates a graphics object.
    /// </summary>
    /// <param name="canvas">Graphics owner.</param>
    /// <param name="name">Graphics name.</param>
    public Graphics(Canvas canvas, string name) : base(name, ObjectType.Graphics, canvas)
    {
    }

    /// <summary>
    /// Creates a graphics object.
    /// </summary>
    /// <param name="graphics">Graphics owner.</param>
    /// <param name="name">Graphics name.</param>
    public Graphics(Graphics graphics, string name) : base(name, ObjectType.Graphics, graphics)
    {
    }

    /// <summary>
    /// Creates a graphics object.
    /// </summary>
    /// <param name="group">Graphics owner.</param>
    /// <param name="name">Graphics name.</param>
    public Graphics(ObjectGroup group, string name) : base(name, ObjectType.Graphics, group)
    {
    }

    /// <summary>
    /// Creates a graphics object.
    /// </summary>
    /// <param name="tab">Graphics owner.</param>
    /// <param name="name">Graphics name.</param>
    public Graphics(TabPage tab, string name) : base(name, ObjectType.Graphics, tab)
    {
    }

    internal Graphics(ObjectSafeHandle handle) : base(handle, ObjectType.Graphics)
    {
    }

    /// <summary>
    /// Gets or sets whether runtime can automatically expand a frame when the contents of the
    /// frame extend beyond the frame's borders.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALLOW_EXPANSION)]
    public partial bool AllowExpansion { get; set; }

    /// <summary>
    /// Gets or sets whether runtime can conserve space within a frame by splitting a prompt into multiple lines.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALLOW_MLT_LIN_PRMPTS)]
    public partial bool AllowMultilinePrompts { get; set; }

    /// <summary>
    /// Gets or sets whether runtime will attach prompts to the item's start edge if there is enough space.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALLOW_STRT_ATT_PRMPTS)]
    public partial bool AllowStartAttachedPrompts { get; set; }

    /// <summary>
    /// Gets or sets whether runtime will attach prompts to the item's top edge if there is enough space.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALLOW_TOP_ATT_PRMPTS)]
    public partial bool AllowTopAttachedPrompts { get; set; }

    /// <summary>
    /// Gets or sets the line arrow style.
    /// </summary>
    [Property(NdapiConstant.D2FP_ARROW_STY)]
    public partial LineArrowStyle LineArrowStyle { get; set; }

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
    /// Gets or sets the object edge cap style.
    /// </summary>
    [Property(NdapiConstant.D2FP_CAP_STY)]
    public partial ObjectEdgeCapStyle ObjectEdgeCapStyle { get; set; }

    /// <summary>
    /// Gets or sets the clipping height.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLIP_HGT)]
    public partial int ClippingHeight { get; set; }

    /// <summary>
    /// Gets or sets the clipping width.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLIP_WID)]
    public partial int ClippingWidth { get; set; }

    /// <summary>
    /// Gets or sets the clipping X origin.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLIP_X_POS)]
    public partial int ClippingXOrigin { get; set; }

    /// <summary>
    /// Gets or sets the clipping Y origin.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLIP_Y_POS)]
    public partial int ClippingYOrigin { get; set; }

    /// <summary>
    /// Gets or sets whether an arc is closed.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLOSED)]
    public partial bool IsClosed { get; set; }

    /// <summary>
    /// Gets or sets the X corner radius.
    /// </summary>
    [Property(NdapiConstant.D2FP_CORNER_RADIUS_X)]
    public partial int XCornerRadius { get; set; }

    /// <summary>
    /// Gets or sets the Y corner radius.
    /// </summary>
    [Property(NdapiConstant.D2FP_CORNER_RADIUS_Y)]
    public partial int YCornerRadius { get; set; }

    /// <summary>
    /// Gets or sets the custom spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_CSTM_SPCING)]
    public partial int CustomSpacing { get; set; }

    /// <summary>
    /// Gets or sets the dash style.
    /// </summary>
    [Property(NdapiConstant.D2FP_DASH_STY)]
    public partial DashStyle DashStyle { get; set; }

    /// <summary>
    /// Gets or sets the display quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_QLTY)]
    public partial DisplayQuality DisplayQuality { get; set; }

    /// <summary>
    /// Gets or sets the distance between records.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIST_BTWN_RECS)]
    public partial int DistanceBetweenRecords { get; set; }

    /// <summary>
    /// Gets or sets whether graphics dithers image.
    /// </summary>
    [Property(NdapiConstant.D2FP_DITHER)]
    public partial bool GraphicsDithersImage { get; set; }

    /// <summary>
    /// Gets or sets the edge background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDGE_BACK_COLOR)]
    public partial string EdgeBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the edge foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDGE_FORE_COLOR)]
    public partial string EdgeForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the edge foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDGE_PAT)]
    public partial string EdgePattern { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string FillPattern { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should use a fixed size for bounding box.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIXED_BOUNDING_BX)]
    public partial bool IsFixedSizeForBoundingBox { get; set; }

    /// <summary>
    /// Gets or sets whether point size scales with object.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SCALEABLE)]
    public partial bool IsPointSizeScalable { get; set; }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public partial string ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the frame alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_ALIGN)]
    public partial FrameAlignment FrameAlignment { get; set; }

    /// <summary>
    /// Gets or sets the frame title.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL)]
    public partial string FrameTitle { get; set; }

    /// <summary>
    /// Gets or sets the frame title alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_ALIGN)]
    public partial FrameTitleAlignment FrameTitleAlignment { get; set; }

    /// <summary>
    /// Gets or sets the frame title background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_BACK_COLOR)]
    public partial string FrameTitleBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the frame's title fill region.
    /// Patterns are rendered in the two colors specified by <see cref="FrameTitleBackgroundColor"/> and <see cref="FrameTitleForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FILL_PAT)]
    public partial string FrameTitleFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the frame's font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_NAM)]
    public partial string FrameTitleFontName { get; set; }

    /// <summary>
    /// Gets or sets the frame's font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_SIZ)]
    public partial int FrameTitleFontSize { get; set; }

    /// <summary>
    /// Gets or sets the frame font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_SPCING)]
    public partial FontSpacing FrameTitleFontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the frame font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_STY)]
    public partial FontStyle FrameTitleFontStyle { get; set; }

    /// <summary>
    /// Gets or sets the frame font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_WGHT)]
    public partial FontWeight FrameTitleFontWeight { get; set; }

    /// <summary>
    /// Gets or sets the frame title foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FORE_COLOR)]
    public partial string FrameTitleForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the frame title offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_OFST)]
    public partial int FrameTitleOffset { get; set; }

    /// <summary>
    /// Gets or sets the frame title spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_SPCING)]
    public partial int FrameTitleSpacing { get; set; }

    /// <summary>
    /// Gets or sets the frame title visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_VAT_NAM)]
    public partial string FrameTitleVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the graphics object type.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRAPHICS_TYP)]
    public partial GraphicsObjectType GraphicsObjectType { get; set; }

    /// <summary>
    /// Gets or sets the graphics font color.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_COLOR)]
    public partial string GraphicsFontColor { get; set; }

    /// <summary>
    /// Gets or sets the graphic's font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_NAM)]
    public partial string GraphicsFontName { get; set; }

    /// <summary>
    /// Gets or sets the graphic's font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_SIZ)]
    public partial int GraphicsFontSize { get; set; }

    /// <summary>
    /// Gets or sets the graphics font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_SPCING)]
    public partial FontSpacing GraphicsFontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the graphics font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_STY)]
    public partial FontStyle GraphicsFontStyle { get; set; }

    /// <summary>
    /// Gets or sets the graphics font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_FONT_WGHT)]
    public partial FontWeight GraphicsFontWeight { get; set; }

    /// <summary>
    /// Gets or sets the graphics text.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRA_TEXT)]
    public partial string GraphicsText { get; set; }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstant.D2FP_HEIGHT)]
    public partial int Height { get; set; }

    /// <summary>
    /// Gets or sets the horizontal justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_JST)]
    public partial HorizontalJustification HorizontalJustification { get; set; }

    /// <summary>
    /// Gets or sets the horizontal margin.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_MARGN)]
    public partial int HorizontalMargin { get; set; }

    /// <summary>
    /// Gets or sets the horizontal object offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_OBJ_OFST)]
    public partial int HorizontalObjectOffset { get; set; }

    /// <summary>
    /// Gets or sets the horizontal position relative to origin.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_ORGN)]
    public partial int HorizontalPositionRelativeToOrigin { get; set; }

    /// <summary>
    /// Gets or sets the internal end angle.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERNAL_END_ANGLE)]
    public partial int InternalEndAngle { get; set; }

    /// <summary>
    /// Gets or sets the internal rotation angle.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERNAL_ROTATION_ANGLE)]
    public partial int InternalRotationAngle { get; set; }

    /// <summary>
    /// Gets or sets the internal line width.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERNAL_LIN_WID)]
    public partial int InternalLineWidth { get; set; }

    /// <summary>
    /// Gets or sets the internal rotation angle.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERNAL_STRT_ANGLE)]
    public partial int InternalStartAngle { get; set; }

    /// <summary>
    /// Gets or sets the joint style.
    /// </summary>
    [Property(NdapiConstant.D2FP_JOIN_STY)]
    public partial JoinStyle JoinStyle { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the layout data block.
    /// </summary>
    [Property(NdapiConstant.D2FP_LAYOUT_DATA_BLK_NAM)]
    public partial string LayoutDataBlock { get; set; }

    /// <summary>
    /// Gets or sets the layout style.
    /// </summary>
    [Property(NdapiConstant.D2FP_LAYOUT_STY)]
    public partial LayoutStyle LayoutStyle { get; set; }

    /// <summary>
    /// Gets or sets the line spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIN_SPCING)]
    public partial LineSpacing LineSpacing { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of objects per line.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_OBJS)]
    public partial int MaximumObjectsPerLine { get; set; }

    /// <summary>
    /// Gets or sets the number of records displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_DISP_COUNT)]
    public partial int NumberOfRecordsDisplayed { get; set; }

    /// <summary>
    /// Gets or sets the scrollbar alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_ALIGN)]
    public partial ScrollBarAlignment ScrollBarAlignment { get; set; }

    /// <summary>
    /// Gets or sets the scrollbar width.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_WID)]
    public partial int ScrollBarWidth { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should create a block scrollbar for the graphics.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_SCRLBR)]
    public partial bool ShowScrollBar { get; set; }

    /// <summary>
    /// Gets or sets whether blank space should be automatically removed from the frame.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHRINKWRAP)]
    public partial bool Shrinkwrap { get; set; }

    /// <summary>
    /// Gets or sets the single object alignment when the <see cref="FrameAlignment"/> is set to <see cref="FrameAlignment.Fill"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_SNGL_OBJ_ALIGN)]
    public partial Alignment SingleObjectAlignment { get; set; }

    /// <summary>
    /// Gets or sets the start prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_STRT_PRMPT_ALIGN)]
    public partial Alignment StartPromptAlignment { get; set; }

    /// <summary>
    /// Gets or sets the start prompt offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_STRT_PRMPT_OFST)]
    public partial int StartPromptOffset { get; set; }

    /// <summary>
    /// Gets or sets the top prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOP_PRMPT_ALIGN)]
    public partial Alignment TopPromptAlignment { get; set; }

    /// <summary>
    /// Gets or sets the top prompt offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOP_PRMPT_OFST)]
    public partial int TopPromptOffset { get; set; }

    /// <summary>
    /// Gets or sets the title reading order,
    /// </summary>
    [Property(NdapiConstant.D2FP_TTL_READING_ORDR)]
    public partial ReadingOrder TitleReadingOrder { get; set; }

    /// <summary>
    /// Gets or sets the update layout mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_LAYOUT)]
    public partial UpdateLayout UpdateLayout { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets whether the runtime uses the empty space surrounding an object when the <see cref="LayoutStyle"/> is set to <see cref="LayoutStyle.Form"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_FILL)]
    public partial bool VerticalFill { get; set; }

    /// <summary>
    /// Gets or sets the vertical justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_JST)]
    public partial VerticalJustification VerticalJustification { get; set; }

    /// <summary>
    /// Gets or sets the vertical margin.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_MARGN)]
    public partial int VerticalMargin { get; set; }

    /// <summary>
    /// Gets or sets the vertical object offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_OBJ_OFST)]
    public partial int VerticalObjectOffset { get; set; }

    /// <summary>
    /// Gets or sets the vertical position relative to origin.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_ORGN)]
    public partial int VerticalPositionRelativeToOrigin { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIDTH)]
    public partial int Width { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should wrap text.
    /// </summary>
    [Property(NdapiConstant.D2FP_WRAP_TXT)]
    public partial bool WrapText { get; set; }

    /// <summary>
    /// Gets or sets the X position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_X_POS)]
    public partial int XPosition { get; set; }

    /// <summary>
    /// Gets or sets the Y position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_Y_POS)]
    public partial int YPosition { get; set; }

    /// <summary>
    /// Gets the compound texts.
    /// </summary>
    [Property(NdapiConstant.D2FP_CMPTXT)]
    public partial NdapiObjectList<CompoundText> CompoundTexts { get; }

    /// <summary>
    /// Gets the graphics points.
    /// </summary>
    [Property(NdapiConstant.D2FP_POINT)]
    public partial NdapiObjectList<Point> Points { get; }

    /// <summary>
    /// Gets or sets the child graphics.
    /// </summary>
    [Property(NdapiConstant.D2FP_GRAPHIC)]
    public partial NdapiObjectList<Graphics> ChildGraphics { get; }

    /// <summary>
    /// Imports an image from disk into a graphics image object.
    /// </summary>
    /// <param name="filename">Image path.</param>
    /// <param name="format">Image format.</param>
    public void ImportImage(string filename, ImageFormat format)
    {
        var status = NativeMethods.d2fgraim_importImage(NdapiContext.GetContext(), Handle, filename, format);
        Ensure.Success(status);
    }

    /// <summary>
    /// Creates a compound text.
    /// </summary>
    /// <param name="name">Name of the compound text.</param>
    /// <returns>The child object.</returns>
    public CompoundText CreateCompoundText(string name) => new(this, name);

    /// <summary>
    /// Creates a point.
    /// </summary>
    /// <param name="name">Name of the point.</param>
    /// <returns>The child object.</returns>
    public Point CreatePoint(string name) => new(this, name);

    /// <summary>
    /// Creates a child graphics object.
    /// </summary>
    /// <param name="name">Name of the graphics object.</param>
    /// <returns>The child object.</returns>
    public Graphics CreateChildGraphics(string name) => new(this, name);
}
