using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an alert object.
/// </summary>
public class Alert : NdapiObject<Alert>
{
    /// <summary>
    /// Creates an alert object.
    /// </summary>
    /// <param name="module">Alert owner.</param>
    /// <param name="name">Alert name.</param>
    public Alert(FormModule module, string name) : base(name, ObjectType.Alert, module)
    {
    }

    /// <summary>
    /// Creates an alert object.
    /// </summary>
    /// <param name="group">Alert owner.</param>
    /// <param name="name">Alert name.</param>
    public Alert(ObjectGroup group, string name) : base(name, ObjectType.Alert, group)
    {
    }

    internal Alert(ObjectSafeHandle handle) : base(handle, ObjectType.Alert)
    {
    }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALT_MSG)]
    public string Message
    {
        get => GetStringProperty(NdapiConstant.D2FP_ALT_MSG);
        set => SetStringProperty(NdapiConstant.D2FP_ALT_MSG, value);
    }

    /// <summary>
    /// Gets or sets the alert style.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALT_STY)]
    public AlertStyle AlertStyle
    {
        get => GetNumberProperty<AlertStyle>(NdapiConstant.D2FP_ALT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_ALT_STY, value);
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
    /// Gets or sets the first button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_1_LBL)]
    public string Button1Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_BTN_1_LBL);
        set => SetStringProperty(NdapiConstant.D2FP_BTN_1_LBL, value);
    }

    /// <summary>
    /// Gets or sets the second button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_2_LBL)]
    public string Button2Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_BTN_2_LBL);
        set => SetStringProperty(NdapiConstant.D2FP_BTN_2_LBL, value);
    }

    /// <summary>
    /// Gets or sets the third button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_3_LBL)]
    public string Button3Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_BTN_3_LBL);
        set => SetStringProperty(NdapiConstant.D2FP_BTN_3_LBL, value);
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
    /// Gets or sets the default alert button.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_ALT_BTN)]
    public AlertButton DefaultAlertButton
    {
        get => GetNumberProperty<AlertButton>(NdapiConstant.D2FP_DFLT_ALT_BTN);
        set => SetNumberProperty(NdapiConstant.D2FP_DFLT_ALT_BTN, value);
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
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstant.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_LANG_DIR, value);
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
}
