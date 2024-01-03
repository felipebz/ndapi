using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a window object.
/// </summary>
public class Window : NdapiObject<Window>
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

    internal Window(ObjectSafeHandle handle) : base(handle, ObjectType.Window)
    {
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public string BackgroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_BACK_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstant.D2FP_BEVEL)]
    public Bevel Bevel
    {
        get => GetNumberProperty<Bevel>(NdapiConstant.D2FP_BEVEL);
        set => SetNumberProperty(NdapiConstant.D2FP_BEVEL, value);
    }

    /// <summary>
    /// Gets or sets whether window can be closed.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLS_ALLOWED)]
    public bool IsCloseAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_CLS_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_CLS_ALLOWED, value);
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
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public string FillPattern
    {
        get => GetStringProperty(NdapiConstant.D2FP_FILL_PAT);
        set => SetStringProperty(NdapiConstant.D2FP_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public string FontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public int FontSize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_FONT_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public FontSpacing FontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstant.D2FP_FONT_SPCING);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public FontStyle FontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstant.D2FP_FONT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public FontWeight FontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstant.D2FP_FONT_WGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public string ForegroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_FORE_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstant.D2FP_HEIGHT)]
    public int Height
    {
        get => GetNumberProperty(NdapiConstant.D2FP_HEIGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_HEIGHT, value);
    }

    /// <summary>
    /// Gets or sets the help book title.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TOPIC)]
    public string HelpBookTopic
    {
        get => GetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TOPIC);
        set => SetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TOPIC, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should hide the window when the user navigates to an item in another window.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIDE_ON_EXIT)]
    public bool HideOnExit
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_HIDE_ON_EXIT);
        set => SetBooleanProperty(NdapiConstant.D2FP_HIDE_ON_EXIT, value);
    }

    /// <summary>
    /// Gets or sets the canvas name of the horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_HTB_CNV_NAME)]
    public string HorizontalToolbarCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_HTB_CNV_NAME);
        set => SetStringProperty(NdapiConstant.D2FP_HTB_CNV_NAME, value);
    }

    /// <summary>
    /// Gets or sets the icon filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public string IconFilename
    {
        get => GetStringProperty(NdapiConstant.D2FP_ICON_FLNAM);
        set => SetStringProperty(NdapiConstant.D2FP_ICON_FLNAM, value);
    }

    /// <summary>
    /// Gets or sets whether the window should display the current form menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_INHRT_MNU)]
    public bool InheritMenu
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_INHRT_MNU);
        set => SetBooleanProperty(NdapiConstant.D2FP_INHRT_MNU, value);
    }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstant.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_LANG_DIR, value);
    }

    /// <summary>
    /// Gets or sets whether window can be maximized.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAXIMIZE_ALLOWED)]
    public bool IsMaximizeAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MAXIMIZE_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_MAXIMIZE_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets whether window can be minimized.
    /// </summary>
    [Property(NdapiConstant.D2FP_MINIMIZE_ALLOWED)]
    public bool IsMinimizedAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MINIMIZE_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_MINIMIZE_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the text string that will appear below an iconified window. 
    /// </summary>
    [Property(NdapiConstant.D2FP_MINIMIZE_TTL)]
    public string MinimizeTitle
    {
        get => GetStringProperty(NdapiConstant.D2FP_MINIMIZE_TTL);
        set => SetStringProperty(NdapiConstant.D2FP_MINIMIZE_TTL, value);
    }

    /// <summary>
    /// Gets or sets whether window is modal or not.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODAL)]
    public bool IsModal
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MODAL);
        set => SetBooleanProperty(NdapiConstant.D2FP_MODAL, value);
    }

    /// <summary>
    /// Gets or sets whether window can be moved.
    /// </summary>
    [Property(NdapiConstant.D2FP_MV_ALLOWED)]
    public bool IsMoveAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MV_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_MV_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the name of the primary canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMRY_CNV)]
    public string PrimaryCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMRY_CNV);
        set => SetStringProperty(NdapiConstant.D2FP_PRMRY_CNV, value);
    }

    /// <summary>
    /// Gets or sets whether window can be resized.
    /// </summary>
    [Property(NdapiConstant.D2FP_RESIZE_ALLOWED)]
    public bool IsResizeAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_RESIZE_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_RESIZE_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should show a horizontal scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR)]
    public bool ShowHorizontalScrollBar
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should show a vertical scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VERT_SCRLBR)]
    public bool ShowVerticalScrollBar
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_VERT_SCRLBR);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_VERT_SCRLBR, value);
    }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public string Title
    {
        get => GetStringProperty(NdapiConstant.D2FP_TITLE);
        set => SetStringProperty(NdapiConstant.D2FP_TITLE, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public string VisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_VAT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the canvas name of the vertical toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VTB_CNV_NAME)]
    public string VerticalToolbarCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_VTB_CNV_NAME);
        set => SetStringProperty(NdapiConstant.D2FP_VTB_CNV_NAME, value);
    }

#if FORMS_6
        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
        public bool IsWhiteOnBlack
        {
            get => GetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK);
            set => SetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK, value);
        }
#endif

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIDTH)]
    public int Width
    {
        get => GetNumberProperty(NdapiConstant.D2FP_WIDTH);
        set => SetNumberProperty(NdapiConstant.D2FP_WIDTH, value);
    }

    /// <summary>
    /// Gets or sets the window style.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIN_STY)]
    public WindowStyle WindowStyle
    {
        get => GetNumberProperty<WindowStyle>(NdapiConstant.D2FP_WIN_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_WIN_STY, value);
    }

    /// <summary>
    /// Gets or sets the X position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_X_POS)]
    public int XPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_X_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_Y_POS)]
    public int YPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_Y_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_Y_POS, value);
    }
}
