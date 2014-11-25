using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class Graphic : NdapiObject
    {
        public Graphic()
        {
        }

        public Graphic(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_GRAPHIC, module);
        }

        internal Graphic(ObjectSafeHandle handle) : base(handle)
        {
        }

        public bool AllowExpansion
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION, value); }
        }

        public bool AllowMultilinePrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS, value); }
        }

        public bool AllowStartAttachedPrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS, value); }
        }

        public bool AllowTopAttachedPrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS, value); }
        }

        public LineArrowStyle LineArrowStyle
        {
            get { return GetNumberProperty<LineArrowStyle>(NdapiConstants.D2FP_ARROW_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_ARROW_STY, value); }
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }

        public ObjectEdgeCapStyle ObjectEdgeCapStyle
        {
            get { return GetNumberProperty<ObjectEdgeCapStyle>(NdapiConstants.D2FP_CAP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_CAP_STY, value); }
        }

        public int ClippingHeight
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_HGT); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_HGT, value); }
        }

        public int ClippingWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_WID, value); }
        }

        public int ClippingXOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS, value); }
        }

        public int ClippingYOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS, value); }
        }

        public bool Closed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CLOSED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CLOSED, value); }
        }

        public int XCornerRadius
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X); }
            set { SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X, value); }
        }

        public int YCornerRadius
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y); }
            set { SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y, value); }
        }

        public int CustomSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING, value); }
        }

        public DashStyle DashStyle
        {
            get { return GetNumberProperty<DashStyle>(NdapiConstants.D2FP_DASH_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DASH_STY, value); }
        }

        public DisplayQuality DisplayQuality
        {
            get { return GetNumberProperty<DisplayQuality>(NdapiConstants.D2FP_DISP_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DISP_QLTY, value); }
        }

        public int DistanceBetweenRecords
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS); }
            set { SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value); }
        }

        public bool GraphicsDithersImage
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DITHER); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DITHER, value); }
        }

        public string EdgeBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR, value); }
        }

        public string EdgeForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        public bool FixedSizeForBoundingBox
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX, value); }
        }

        public bool PointSizeScalable
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE, value); }
        }

        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        public FrameAlignment FrameAlignment
        {
            get { return GetNumberProperty<FrameAlignment>(NdapiConstants.D2FP_FRAME_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_ALIGN, value); }
        }

        public string FrameTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL, value); }
        }

        public FrameTitleAlignment FrameTitleAlignment
        {
            get { return GetNumberProperty<FrameTitleAlignment>(NdapiConstants.D2FP_FRAME_TTL_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_ALIGN, value); }
        }

        public string FrameTitleBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR, value); }
        }

        public string FrameTitleFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT, value); }
        }

        public string FrameTitleFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM, value); }
        }

        public int FrameTitleFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ, value); }
        }

        public FontSpacing FrameTitleFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING, value); }
        }

        public FontStyle FrameTitleFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FRAME_TTL_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_STY, value); }
        }

        public FontWeight FrameTitleFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT, value); }
        }

        public string FrameTitleForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR, value); }
        }

        public int FrameTitleOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST, value); }
        }

        public int FrameTitleSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING, value); }
        }

        public string FrameTitleVisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM, value); }
        }

        public GraphicsObjectType GraphicsObjectType
        {
            get { return GetNumberProperty<GraphicsObjectType>(NdapiConstants.D2FP_GRAPHICS_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRAPHICS_TYP, value); }
        }

        public string GraphicsFontColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR, value); }
        }

        public string GraphicsFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM, value); }
        }

        public int GraphicsFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ, value); }
        }

        public FontSpacing GraphicsFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_GRA_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SPCING, value); }
        }

        public FontStyle GraphicsFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_GRA_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_STY, value); }
        }

        public FontWeight GraphicsFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_GRA_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_WGHT, value); }
        }

        public string GraphicsText
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_TEXT); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_TEXT, value); }
        }

        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        public HorizontalJustification HorizontalJustification
        {
            get { return GetNumberProperty<HorizontalJustification>(NdapiConstants.D2FP_HORZ_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_JST, value); }
        }

        public int HorizontalMargin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN, value); }
        }

        public int HorizontalObjectOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST, value); }
        }

        public int HorizontalPositionRelativeToOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN, value); }
        }

        public JoinStyle JoinStyle
        {
            get { return GetNumberProperty<JoinStyle>(NdapiConstants.D2FP_JOIN_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_JOIN_STY, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public string LayoutDataBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM, value); }
        }

        public LayoutStyle LayoutStyle
        {
            get { return GetNumberProperty<LayoutStyle>(NdapiConstants.D2FP_LAYOUT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_LAYOUT_STY, value); }
        }

        public LineSpacing LineSpacing
        {
            get { return GetNumberProperty<LineSpacing>(NdapiConstants.D2FP_LIN_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_LIN_SPCING, value); }
        }

        public int MaximumObjectsPerLine
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_OBJS); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_OBJS, value); }
        }

        public NdapiObject FontPointSize
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_POINT); }
        }
            
        public int NumberOfRecordsDisplayed
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT, value); }
        }

        public ScrollBarAlignment ScrollBarAlignment
        {
            get { return GetNumberProperty<ScrollBarAlignment>(NdapiConstants.D2FP_SCRLBR_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_ALIGN, value); }
        }

        public int ScrollBarWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID, value); }
        }

        public bool ShowScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR, value); }
        }

        public bool Shrinkwrap
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP, value); }
        }

        public Alignment SingleObjectAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_SNGL_OBJ_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_SNGL_OBJ_ALIGN, value); }
        }

        public Alignment StartPromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_STRT_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_ALIGN, value); }
        }

        public int StartPromptOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST, value); }
        }

        public Alignment TopPromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_TOP_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_ALIGN, value); }
        }

        public int TopPromptOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST, value); }
        }

        public ReadingOrder TitleReadingOrder
        {
            get { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_TTL_READING_ORDR); }
            set { SetNumberProperty(NdapiConstants.D2FP_TTL_READING_ORDR, value); }
        }

        public UpdateLayout UpdateLayout
        {
            get { return GetNumberProperty<UpdateLayout>(NdapiConstants.D2FP_UPDT_LAYOUT); }
            set { SetNumberProperty(NdapiConstants.D2FP_UPDT_LAYOUT, value); }
        }

        public string VisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public bool VerticalFill
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VERT_FILL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VERT_FILL, value); }
        }

        public VerticalJustification VerticalJustification
        {
            get { return GetNumberProperty<VerticalJustification>(NdapiConstants.D2FP_VERT_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_JST, value); }
        }

        public int VerticalMargin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_MARGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_MARGN, value); }
        }

        public int VerticalObjectOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST, value); }
        }

        public int VerticalPositionRelativeToOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_ORGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_ORGN, value); }
        }

        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        public bool WrapText
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT, value); }
        }

        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }

        public IEnumerable<Graphic> Graphics
        {
            get { return GetObjectList<Graphic>(NdapiConstants.D2FP_GRAPHIC); }
        }
    }
}
