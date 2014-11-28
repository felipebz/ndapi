using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class Canvas : NdapiObject
    {
        public Canvas(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_CANVAS, module);
        }

        internal Canvas(ObjectSafeHandle handle) : base(handle)
        {
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

        public CanvasType CanvasType
        {
            get { return GetNumberProperty<CanvasType>(NdapiConstants.D2FP_CNV_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_CNV_TYP, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        public string HelpBookTopic
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC, value); }
        }

        public int LanguageDirection
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public string PopupMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM, value); }
        }

        public bool RaiseOnEntry
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RAISE_ON_ENT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RAISE_ON_ENT, value); }
        }

        public TabAttachmentEdge TabAttachmentEdge
        {
            get { return GetNumberProperty<TabAttachmentEdge>(NdapiConstants.D2FP_TAB_ATT_EDGE); }
            set { SetNumberProperty(NdapiConstants.D2FP_TAB_ATT_EDGE, value); }
        }

        public TabStyle TabStyle
        {
            get { return GetNumberProperty<TabStyle>(NdapiConstants.D2FP_TAB_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_TAB_STY, value); }
        }

        public string VisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        public int ViewportHeight
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_HGT); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_HGT, value); }
        }

        public int ViewportWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_WID, value); }
        }

        public int ViewportXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS, value); }
        }

        public int ViewportXPositionOnCanvas
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS_ON_CNV); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS_ON_CNV, value); }
        }

        public int ViewportYPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS, value); }
        }

        public int ViewportYPositionOnCanvas
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS_ON_CNV); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS_ON_CNV, value); }
        }

        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        public Window Window
        {
            get { return GetObjectProperty<Window>(NdapiConstants.D2FP_WND_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_WND_OBJ, value); }
        }

        public string WindowName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_WND_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_WND_NAM, value); }
        }

        public IEnumerable<Graphic> Graphics
        {
            get { return GetObjectList<Graphic>(NdapiConstants.D2FP_GRAPHIC); }
        }
    }
}
