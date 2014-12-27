using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a window object.
    /// </summary>
    public class Window : NdapiObject
    {
        /// <summary>
        /// Creates a window object.
        /// </summary>
        /// <param name="module">Window owner</param>
        /// <param name="name">Window name.</param>
        public Window(FormModule module, string name) : base(name, ObjectType.Window, module)
        {
        }

        /// <summary>
        /// Creates a window object.
        /// </summary>
        /// <param name="group">Window owner</param>
        /// <param name="name">Window name.</param>
        public Window(ObjectGroup group, string name) : base(name, ObjectType.Window, group)
        {
        }

        /// <summary>
        /// Creates a window object.
        /// </summary>
        /// <param name="library">Window owner</param>
        /// <param name="name">Window name.</param>
        public Window(ObjectLibrary library, string name) : base(name, ObjectType.Window, library)
        {
        }

        internal Window(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the appearance of the object border.
        /// </summary>
        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }

        /// <summary>
        /// Gets or sets whether window can be closed.
        /// </summary>
        public bool CloseAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CLS_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CLS_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }
        
        /// <summary>
        /// Gets or sets the help book title.
        /// </summary>
        public string HelpBookTopic
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should hide the window when the user navigates to an item in another window.
        /// </summary>
        public bool HideOnExit
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_HIDE_ON_EXIT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_HIDE_ON_EXIT, value); }
        }

        /// <summary>
        /// Gets or sets the canvas name of the horizontal toolbar.
        /// </summary>
        public string HorizontalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HTB_CNV_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_HTB_CNV_NAME, value); }
        }

        /// <summary>
        /// Gets or sets the icon filename.
        /// </summary>
        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the window should display the current form menu.
        /// </summary>
        public bool InheritMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_INHRT_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_INHRT_MNU, value); }
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        /// <summary>
        /// Gets or sets whether window can be maximized.
        /// </summary>
        public bool MaximizeAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MAXIMIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MAXIMIZE_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets whether window can be minimized.
        /// </summary>
        public bool MinimizedAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MINIMIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MINIMIZE_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets the text string that will appear below an iconified window. 
        /// </summary>
        public string MinimizeTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MINIMIZE_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_MINIMIZE_TTL, value); }
        }

        /// <summary>
        /// Gets or sets whether window is modal or not.
        /// </summary>
        public bool Modal
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MODAL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MODAL, value); }
        }

        /// <summary>
        /// Gets or sets whether window can be moved.
        /// </summary>
        public bool MoveAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MV_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MV_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets the name of the primary canvas.
        /// </summary>
        public string PrimaryCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMRY_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMRY_CNV, value); }
        }

        /// <summary>
        /// Gets or sets whether window can be resized.
        /// </summary>
        public bool ResizeAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RESIZE_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RESIZE_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should show a horizontal scrollbar.
        /// </summary>
        public bool ShowHorizontalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should show a vertical scrollbar.
        /// </summary>
        public bool ShowVerticalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the canvas name of the vertical toolbar.
        /// </summary>
        public string VerticalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VTB_CNV_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_VTB_CNV_NAME, value); }
        }

        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        /// <summary>
        /// Gets or sets the window style.
        /// </summary>
        public WindowStyle WindowStyle
        {
            get { return GetNumberProperty<WindowStyle>(NdapiConstants.D2FP_WIN_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIN_STY, value); }
        }

        /// <summary>
        /// Gets or sets the X position measured at the upper left corner.
        /// </summary>
        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position measured at the upper left corner.
        /// </summary>
        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }
    }
}
