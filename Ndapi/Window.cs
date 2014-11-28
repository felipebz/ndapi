using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class Window : NdapiObject
    {
        public Window(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_WINDOW, module);
        }

        internal Window(ObjectSafeHandle handle) : base(handle)
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

        public bool CloseAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CLS_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CLS_ALLOWED, value); }
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

        public bool HideOnExit
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_HIDE_ON_EXIT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_HIDE_ON_EXIT, value); }
        }

        public string HorizontalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HTB_CNV_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_HTB_CNV_NAME, value); }
        }

        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        public bool InheritMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_INHRT_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_INHRT_MNU, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public bool MaximizeAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MAXIMIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MAXIMIZE_ALLOWED, value); }
        }

        public bool MinimizedAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MINIMIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MINIMIZE_ALLOWED, value); }
        }

        public string MinimizeTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MINIMIZE_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_MINIMIZE_TTL, value); }
        }

        public bool Modal
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MODAL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MODAL, value); }
        }

        public bool MoveAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MV_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MV_ALLOWED, value); }
        }

        public string PrimaryCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMRY_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMRY_CNV, value); }
        }

        public bool ResizeAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RESIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RESIZE_ALLOWED, value); }
        }

        public bool ShowHorizontalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR, value); }
        }

        public bool ShowVerticalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR, value); }
        }

        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        public string VisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public string VerticalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VTB_CNV_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_VTB_CNV_NAME, value); }
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

        public WindowStyle WindowStyle
        {
            get { return GetNumberProperty<WindowStyle>(NdapiConstants.D2FP_WIN_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIN_STY, value); }
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
    }
}
