using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an alert object.
/// </summary>
public partial class Alert : NdapiObject<Alert>
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
    public partial string? Message { get; set; }

    /// <summary>
    /// Gets or sets the alert style.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALT_STY)]
    public partial AlertStyle AlertStyle { get; set; }


    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string? BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the first button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_1_LBL)]
    public partial string? Button1Label { get; set; }

    /// <summary>
    /// Gets or sets the second button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_2_LBL)]
    public partial string? Button2Label { get; set; }

    /// <summary>
    /// Gets or sets the third button label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_3_LBL)]
    public partial string? Button3Label { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets the default alert button.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_ALT_BTN)]
    public partial AlertButton DefaultAlertButton { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string? FillPattern { get; set; }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public partial string? FontName { get; set; }

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
    public partial string? ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the icon file name. Forms 14 and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public partial string? IconFilename { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public partial string? Title { get; set; }

    /// <summary>
    /// Gets or sets the white-on-black property.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public partial bool IsWhiteOnBlack { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string? VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute? VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string? CharacterModeLogicalAttribute { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the message.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALT_MSG_STRID)]
    public partial int MessageStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the button1 label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_1_LBL_STRID)]
    public partial int Button1LabelStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the button2 label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_2_LBL_STRID)]
    public partial int Button2LabelStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the button3 label.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTN_3_LBL_STRID)]
    public partial int Button3LabelStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE_STRID)]
    public partial int TitleStringId { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject? Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject? Source { get; }

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
}
