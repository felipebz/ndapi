using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a graphics opbject.
/// </summary>
public class Graphics : NdapiObject<Graphics>
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
    [Property(NdapiConstants.D2FP_ALLOW_EXPANSION)]
    public bool AllowExpansion
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION);
        set => SetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION, value);
    }

    /// <summary>
    /// Gets or sets whether runtime can conserve space within a frame by splitting a prompt into multiple lines.
    /// </summary>
    [Property(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS)]
    public bool AllowMultilinePrompts
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS);
        set => SetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime will attach prompts to the item's start edge if there is enough space.
    /// </summary>
    [Property(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS)]
    public bool AllowStartAttachedPrompts
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS);
        set => SetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime will attach prompts to the item's top edge if there is enough space.
    /// </summary>
    [Property(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS)]
    public bool AllowTopAttachedPrompts
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS);
        set => SetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS, value);
    }

    /// <summary>
    /// Gets or sets the line arrow style.
    /// </summary>
    [Property(NdapiConstants.D2FP_ARROW_STY)]
    public LineArrowStyle LineArrowStyle
    {
        get => GetNumberProperty<LineArrowStyle>(NdapiConstants.D2FP_ARROW_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_ARROW_STY, value);
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstants.D2FP_BACK_COLOR)]
    public string BackgroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_BACK_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstants.D2FP_BEVEL)]
    public Bevel Bevel
    {
        get => GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL);
        set => SetNumberProperty(NdapiConstants.D2FP_BEVEL, value);
    }


    /// <summary>
    /// Gets or sets the object edge cap style.
    /// </summary>
    [Property(NdapiConstants.D2FP_CAP_STY)]
    public ObjectEdgeCapStyle ObjectEdgeCapStyle
    {
        get => GetNumberProperty<ObjectEdgeCapStyle>(NdapiConstants.D2FP_CAP_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_CAP_STY, value);
    }

    /// <summary>
    /// Gets or sets the clipping height.
    /// </summary>
    [Property(NdapiConstants.D2FP_CLIP_HGT)]
    public int ClippingHeight
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CLIP_HGT);
        set => SetNumberProperty(NdapiConstants.D2FP_CLIP_HGT, value);
    }

    /// <summary>
    /// Gets or sets the clipping width.
    /// </summary>
    [Property(NdapiConstants.D2FP_CLIP_WID)]
    public int ClippingWidth
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CLIP_WID);
        set => SetNumberProperty(NdapiConstants.D2FP_CLIP_WID, value);
    }

    /// <summary>
    /// Gets or sets the clipping X origin.
    /// </summary>
    [Property(NdapiConstants.D2FP_CLIP_X_POS)]
    public int ClippingXOrigin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the clipping Y origin.
    /// </summary>
    [Property(NdapiConstants.D2FP_CLIP_Y_POS)]
    public int ClippingYOrigin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS, value);
    }

    /// <summary>
    /// Gets or sets whether an arc is closed.
    /// </summary>
    [Property(NdapiConstants.D2FP_CLOSED)]
    public bool IsClosed
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_CLOSED);
        set => SetBooleanProperty(NdapiConstants.D2FP_CLOSED, value);
    }

    /// <summary>
    /// Gets or sets the X corner radius.
    /// </summary>
    [Property(NdapiConstants.D2FP_CORNER_RADIUS_X)]
    public int XCornerRadius
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X);
        set => SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X, value);
    }

    /// <summary>
    /// Gets or sets the Y corner radius.
    /// </summary>
    [Property(NdapiConstants.D2FP_CORNER_RADIUS_Y)]
    public int YCornerRadius
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y);
        set => SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y, value);
    }

    /// <summary>
    /// Gets or sets the custom spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_CSTM_SPCING)]
    public int CustomSpacing
    {
        get => GetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the dash style.
    /// </summary>
    [Property(NdapiConstants.D2FP_DASH_STY)]
    public DashStyle DashStyle
    {
        get => GetNumberProperty<DashStyle>(NdapiConstants.D2FP_DASH_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_DASH_STY, value);
    }

    /// <summary>
    /// Gets or sets the display quality.
    /// </summary>
    [Property(NdapiConstants.D2FP_DISP_QLTY)]
    public DisplayQuality DisplayQuality
    {
        get => GetNumberProperty<DisplayQuality>(NdapiConstants.D2FP_DISP_QLTY);
        set => SetNumberProperty(NdapiConstants.D2FP_DISP_QLTY, value);
    }

    /// <summary>
    /// Gets or sets the distance between records.
    /// </summary>
    [Property(NdapiConstants.D2FP_DIST_BTWN_RECS)]
    public int DistanceBetweenRecords
    {
        get => GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS);
        set => SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value);
    }

    /// <summary>
    /// Gets or sets whether graphics dithers image.
    /// </summary>
    [Property(NdapiConstants.D2FP_DITHER)]
    public bool GraphicsDithersImage
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_DITHER);
        set => SetBooleanProperty(NdapiConstants.D2FP_DITHER, value);
    }

    /// <summary>
    /// Gets or sets the edge background color.
    /// </summary>
    [Property(NdapiConstants.D2FP_EDGE_BACK_COLOR)]
    public string EdgeBackgroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the edge foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_EDGE_FORE_COLOR)]
    public string EdgeForegroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the edge foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_EDGE_PAT)]
    public string EdgePattern
    {
        get => GetStringProperty(NdapiConstants.D2FP_EDGE_PAT);
        set => SetStringProperty(NdapiConstants.D2FP_EDGE_PAT, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_FILL_PAT)]
    public string FillPattern
    {
        get => GetStringProperty(NdapiConstants.D2FP_FILL_PAT);
        set => SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should use a fixed size for bounding box.
    /// </summary>
    [Property(NdapiConstants.D2FP_FIXED_BOUNDING_BX)]
    public bool IsFixedSizeForBoundingBox
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX);
        set => SetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX, value);
    }

    /// <summary>
    /// Gets or sets whether point size scales with object.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_SCALEABLE)]
    public bool IsPointSizeScalable
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE);
        set => SetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE, value);
    }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_FORE_COLOR)]
    public string ForegroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_FORE_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the frame alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_ALIGN)]
    public FrameAlignment FrameAlignment
    {
        get => GetNumberProperty<FrameAlignment>(NdapiConstants.D2FP_FRAME_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the frame title.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL)]
    public string FrameTitle
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL, value);
    }

    /// <summary>
    /// Gets or sets the frame title alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_ALIGN)]
    public FrameTitleAlignment FrameTitleAlignment
    {
        get => GetNumberProperty<FrameTitleAlignment>(NdapiConstants.D2FP_FRAME_TTL_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the frame title background color.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR)]
    public string FrameTitleBackgroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the frame's title fill region.
    /// Patterns are rendered in the two colors specified by <see cref="FrameTitleBackgroundColor"/> and <see cref="FrameTitleForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT)]
    public string FrameTitleFillPattern
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the frame's font name.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM)]
    public string FrameTitleFontName
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the frame's font size.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ)]
    public int FrameTitleFontSize
    {
        get => GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the frame font spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING)]
    public FontSpacing FrameTitleFontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the frame font style.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FONT_STY)]
    public FontStyle FrameTitleFontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FRAME_TTL_FONT_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the frame font weight.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT)]
    public FontWeight FrameTitleFontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the frame title foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR)]
    public string FrameTitleForegroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the frame title offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_OFST)]
    public int FrameTitleOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST, value);
    }

    /// <summary>
    /// Gets or sets the frame title spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_SPCING)]
    public int FrameTitleSpacing
    {
        get => GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the frame title visual attribute name.
    /// </summary>
    [Property(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM)]
    public string FrameTitleVisualAttributeName
    {
        get => GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the graphics object type.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRAPHICS_TYP)]
    public GraphicsObjectType GraphicsObjectType
    {
        get => GetNumberProperty<GraphicsObjectType>(NdapiConstants.D2FP_GRAPHICS_TYP);
        set => SetNumberProperty(NdapiConstants.D2FP_GRAPHICS_TYP, value);
    }

    /// <summary>
    /// Gets or sets the graphics font color.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_COLOR)]
    public string GraphicsFontColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the graphic's font name.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_NAM)]
    public string GraphicsFontName
    {
        get => GetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the graphic's font size.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_SIZ)]
    public int GraphicsFontSize
    {
        get => GetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ);
        set => SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the graphics font spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_SPCING)]
    public FontSpacing GraphicsFontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_GRA_FONT_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the graphics font style.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_STY)]
    public FontStyle GraphicsFontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_GRA_FONT_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the graphics font weight.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_FONT_WGHT)]
    public FontWeight GraphicsFontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_GRA_FONT_WGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the graphics text.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRA_TEXT)]
    public string GraphicsText
    {
        get => GetStringProperty(NdapiConstants.D2FP_GRA_TEXT);
        set => SetStringProperty(NdapiConstants.D2FP_GRA_TEXT, value);
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstants.D2FP_HEIGHT)]
    public int Height
    {
        get => GetNumberProperty(NdapiConstants.D2FP_HEIGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value);
    }

    /// <summary>
    /// Gets or sets the horizontal justification.
    /// </summary>
    [Property(NdapiConstants.D2FP_HORZ_JST)]
    public HorizontalJustification HorizontalJustification
    {
        get => GetNumberProperty<HorizontalJustification>(NdapiConstants.D2FP_HORZ_JST);
        set => SetNumberProperty(NdapiConstants.D2FP_HORZ_JST, value);
    }

    /// <summary>
    /// Gets or sets the horizontal margin.
    /// </summary>
    [Property(NdapiConstants.D2FP_HORZ_MARGN)]
    public int HorizontalMargin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN);
        set => SetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN, value);
    }

    /// <summary>
    /// Gets or sets the horizontal object offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_HORZ_OBJ_OFST)]
    public int HorizontalObjectOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST, value);
    }

    /// <summary>
    /// Gets or sets the horizontal position relative to origin.
    /// </summary>
    [Property(NdapiConstants.D2FP_HORZ_ORGN)]
    public int HorizontalPositionRelativeToOrigin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN);
        set => SetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN, value);
    }

    /// <summary>
    /// Gets or sets the internal end angle.
    /// </summary>
    [Property(NdapiConstants.D2FP_INTERNAL_END_ANGLE)]
    public int InternalEndAngle
    {
        get => GetNumberProperty(NdapiConstants.D2FP_INTERNAL_END_ANGLE);
        set => SetNumberProperty(NdapiConstants.D2FP_INTERNAL_END_ANGLE, value);
    }

    /// <summary>
    /// Gets or sets the internal rotation angle.
    /// </summary>
    [Property(NdapiConstants.D2FP_INTERNAL_ROTATION_ANGLE)]
    public int InternalRotationAngle
    {
        get => GetNumberProperty(NdapiConstants.D2FP_INTERNAL_ROTATION_ANGLE);
        set => SetNumberProperty(NdapiConstants.D2FP_INTERNAL_ROTATION_ANGLE, value);
    }

    /// <summary>
    /// Gets or sets the internal line width.
    /// </summary>
    [Property(NdapiConstants.D2FP_INTERNAL_LIN_WID)]
    public int InternalLineWidth
    {
        get => GetNumberProperty(NdapiConstants.D2FP_INTERNAL_LIN_WID);
        set => SetNumberProperty(NdapiConstants.D2FP_INTERNAL_LIN_WID, value);
    }

    /// <summary>
    /// Gets or sets the internal rotation angle.
    /// </summary>
    [Property(NdapiConstants.D2FP_INTERNAL_STRT_ANGLE)]
    public int InternalStartAngle
    {
        get => GetNumberProperty(NdapiConstants.D2FP_INTERNAL_STRT_ANGLE);
        set => SetNumberProperty(NdapiConstants.D2FP_INTERNAL_STRT_ANGLE, value);
    }

    /// <summary>
    /// Gets or sets the joint style.
    /// </summary>
    [Property(NdapiConstants.D2FP_JOIN_STY)]
    public JoinStyle JoinStyle
    {
        get => GetNumberProperty<JoinStyle>(NdapiConstants.D2FP_JOIN_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_JOIN_STY, value);
    }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstants.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value);
    }

    /// <summary>
    /// Gets or sets the layout data block.
    /// </summary>
    [Property(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM)]
    public string LayoutDataBlock
    {
        get => GetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM, value);
    }

    /// <summary>
    /// Gets or sets the layout style.
    /// </summary>
    [Property(NdapiConstants.D2FP_LAYOUT_STY)]
    public LayoutStyle LayoutStyle
    {
        get => GetNumberProperty<LayoutStyle>(NdapiConstants.D2FP_LAYOUT_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_LAYOUT_STY, value);
    }

    /// <summary>
    /// Gets or sets the line spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_LIN_SPCING)]
    public LineSpacing LineSpacing
    {
        get => GetNumberProperty<LineSpacing>(NdapiConstants.D2FP_LIN_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_LIN_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the maximum number of objects per line.
    /// </summary>
    [Property(NdapiConstants.D2FP_MAX_OBJS)]
    public int MaximumObjectsPerLine
    {
        get => GetNumberProperty(NdapiConstants.D2FP_MAX_OBJS);
        set => SetNumberProperty(NdapiConstants.D2FP_MAX_OBJS, value);
    }

    /// <summary>
    /// Gets or sets the number of records displayed.
    /// </summary>
    [Property(NdapiConstants.D2FP_RECS_DISP_COUNT)]
    public int NumberOfRecordsDisplayed
    {
        get => GetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT);
        set => SetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT, value);
    }

    /// <summary>
    /// Gets or sets the scrollbar alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_SCRLBR_ALIGN)]
    public ScrollBarAlignment ScrollBarAlignment
    {
        get => GetNumberProperty<ScrollBarAlignment>(NdapiConstants.D2FP_SCRLBR_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_SCRLBR_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the scrollbar width.
    /// </summary>
    [Property(NdapiConstants.D2FP_SCRLBR_WID)]
    public int ScrollBarWidth
    {
        get => GetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID);
        set => SetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should create a block scrollbar for the graphics.
    /// </summary>
    [Property(NdapiConstants.D2FP_SHOW_SCRLBR)]
    public bool ShowScrollBar
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR);
        set => SetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR, value);
    }

    /// <summary>
    /// Gets or sets whether blank space should be automatically removed from the frame.
    /// </summary>
    [Property(NdapiConstants.D2FP_SHRINKWRAP)]
    public bool Shrinkwrap
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP);
        set => SetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP, value);
    }

    /// <summary>
    /// Gets or sets the single object alignment when the <see cref="FrameAlignment"/> is set to <see cref="FrameAlignment.Fill"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_SNGL_OBJ_ALIGN)]
    public Alignment SingleObjectAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstants.D2FP_SNGL_OBJ_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_SNGL_OBJ_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the start prompt alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_STRT_PRMPT_ALIGN)]
    public Alignment StartPromptAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstants.D2FP_STRT_PRMPT_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the start prompt offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_STRT_PRMPT_OFST)]
    public int StartPromptOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST, value);
    }

    /// <summary>
    /// Gets or sets the top prompt alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_TOP_PRMPT_ALIGN)]
    public Alignment TopPromptAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstants.D2FP_TOP_PRMPT_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the top prompt offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_TOP_PRMPT_OFST)]
    public int TopPromptOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST, value);
    }

    /// <summary>
    /// Gets or sets the title reading order,
    /// </summary>
    [Property(NdapiConstants.D2FP_TTL_READING_ORDR)]
    public ReadingOrder TitleReadingOrder
    {
        get => GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_TTL_READING_ORDR);
        set => SetNumberProperty(NdapiConstants.D2FP_TTL_READING_ORDR, value);
    }

    /// <summary>
    /// Gets or sets the update layout mode.
    /// </summary>
    [Property(NdapiConstants.D2FP_UPDT_LAYOUT)]
    public UpdateLayout UpdateLayout
    {
        get => GetNumberProperty<UpdateLayout>(NdapiConstants.D2FP_UPDT_LAYOUT);
        set => SetNumberProperty(NdapiConstants.D2FP_UPDT_LAYOUT, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstants.D2FP_VAT_NAM)]
    public string VisualAttributeName
    {
        get => GetStringProperty(NdapiConstants.D2FP_VAT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets whether the runtime uses the empty space surrounding an object when the <see cref="LayoutStyle"/> is set to <see cref="LayoutStyle.Form"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_VERT_FILL)]
    public bool VerticalFill
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_VERT_FILL);
        set => SetBooleanProperty(NdapiConstants.D2FP_VERT_FILL, value);
    }

    /// <summary>
    /// Gets or sets the vertical justification.
    /// </summary>
    [Property(NdapiConstants.D2FP_VERT_JST)]
    public VerticalJustification VerticalJustification
    {
        get => GetNumberProperty<VerticalJustification>(NdapiConstants.D2FP_VERT_JST);
        set => SetNumberProperty(NdapiConstants.D2FP_VERT_JST, value);
    }

    /// <summary>
    /// Gets or sets the vertical margin.
    /// </summary>
    [Property(NdapiConstants.D2FP_VERT_MARGN)]
    public int VerticalMargin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_VERT_MARGN);
        set => SetNumberProperty(NdapiConstants.D2FP_VERT_MARGN, value);
    }

    /// <summary>
    /// Gets or sets the vertical object offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_VERT_OBJ_OFST)]
    public int VerticalObjectOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST, value);
    }

    /// <summary>
    /// Gets or sets the vertical position relative to origin.
    /// </summary>
    [Property(NdapiConstants.D2FP_VERT_ORGN)]
    public int VerticalPositionRelativeToOrigin
    {
        get => GetNumberProperty(NdapiConstants.D2FP_VERT_ORGN);
        set => SetNumberProperty(NdapiConstants.D2FP_VERT_ORGN, value);
    }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstants.D2FP_WIDTH)]
    public int Width
    {
        get => GetNumberProperty(NdapiConstants.D2FP_WIDTH);
        set => SetNumberProperty(NdapiConstants.D2FP_WIDTH, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should wrap text.
    /// </summary>
    [Property(NdapiConstants.D2FP_WRAP_TXT)]
    public bool WrapText
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT);
        set => SetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT, value);
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

    /// <summary>
    /// Gets the compound texts.
    /// </summary>
    [Property(NdapiConstants.D2FP_CMPTXT)]
    public NdapiObjectList<CompoundText> CompoundTexts => GetObjectList<CompoundText>(NdapiConstants.D2FP_CMPTXT);

    /// <summary>
    /// Gets the graphics points.
    /// </summary>
    [Property(NdapiConstants.D2FP_POINT)]
    public NdapiObjectList<Point> Points => GetObjectList<Point>(NdapiConstants.D2FP_POINT);

    /// <summary>
    /// Gets or sets the child graphics.
    /// </summary>
    [Property(NdapiConstants.D2FP_GRAPHIC)]
    public NdapiObjectList<Graphics> ChildGraphics => GetObjectList<Graphics>(NdapiConstants.D2FP_GRAPHIC);

    /// <summary>
    /// Imports an image from disk into a graphics image object.
    /// </summary>
    /// <param name="filename">Image path.</param>
    /// <param name="format">Image format.</param>
    public void ImportImage(string filename, ImageFormat format)
    {
        var status = NativeMethods.d2fgraim_importImage(NdapiContext.GetContext(), _handle, filename, format);
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
