using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a window object.
/// </summary>
public partial class Window : NdapiObject<Window>
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
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstant.D2FP_BEVEL)]
    public partial Bevel Bevel { get; set; }

    /// <summary>
    /// Gets or sets whether window can be closed.
    /// </summary>
    [Property(NdapiConstant.D2FP_CLS_ALLOWED)]
    public partial bool IsCloseAllowed { get; set; }

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
    /// Gets or sets the help book title.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TOPIC)]
    public partial string HelpBookTopic { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should hide the window when the user navigates to an item in another window.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIDE_ON_EXIT)]
    public partial bool HideOnExit { get; set; }

    /// <summary>
    /// Gets or sets the canvas name of the horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_HTB_CNV_NAME)]
    public partial string HorizontalToolbarCanvas { get; set; }

    /// <summary>
    /// Gets or sets the icon filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public partial string IconFilename { get; set; }

    /// <summary>
    /// Gets or sets whether the window should display the current form menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_INHRT_MNU)]
    public partial bool InheritMenu { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets whether window can be maximized.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAXIMIZE_ALLOWED)]
    public partial bool IsMaximizeAllowed { get; set; }

    /// <summary>
    /// Gets or sets whether window can be minimized.
    /// </summary>
    [Property(NdapiConstant.D2FP_MINIMIZE_ALLOWED)]
    public partial bool IsMinimizedAllowed { get; set; }

    /// <summary>
    /// Gets or sets the text string that will appear below an iconified window. 
    /// </summary>
    [Property(NdapiConstant.D2FP_MINIMIZE_TTL)]
    public partial string MinimizeTitle { get; set; }

    /// <summary>
    /// Gets or sets whether window is modal or not.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODAL)]
    public partial bool IsModal { get; set; }

    /// <summary>
    /// Gets or sets whether window can be moved.
    /// </summary>
    [Property(NdapiConstant.D2FP_MV_ALLOWED)]
    public partial bool IsMoveAllowed { get; set; }

    /// <summary>
    /// Gets or sets the name of the primary canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMRY_CNV)]
    public partial string PrimaryCanvas { get; set; }

    /// <summary>
    /// Gets or sets whether window can be resized.
    /// </summary>
    [Property(NdapiConstant.D2FP_RESIZE_ALLOWED)]
    public partial bool IsResizeAllowed { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should show a horizontal scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR)]
    public partial bool ShowHorizontalScrollBar { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should show a vertical scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VERT_SCRLBR)]
    public partial bool ShowVerticalScrollBar { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public partial string Title { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the canvas name of the vertical toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VTB_CNV_NAME)]
    public partial string VerticalToolbarCanvas { get; set; }

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
    /// Gets or sets the window style.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIN_STY)]
    public partial WindowStyle WindowStyle { get; set; }

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
}
