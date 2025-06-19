using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a radio button object.
/// </summary>
public partial class RadioButton : NdapiObject<RadioButton>
{
    /// <summary>
    /// Creates a radio button.
    /// </summary>
    /// <param name="item">Radio button group item.</param>
    /// <param name="name">Radio button name.</param>
    public RadioButton(Item item, string name) : base(name, ObjectType.RadioButton, item)
    {
    }

    internal RadioButton(ObjectSafeHandle handle) : base(handle, ObjectType.RadioButton)
    {
    }

    /// <summary>
    /// Gets or sets the access key, allowing the user to select or execute an item by pressing a key combination, such as Alt-C.
    /// </summary>
    [Property(NdapiConstant.D2FP_ACCESS_KEY)]
    public partial string AccessKey { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the distance between record.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIST_BTWN_RECS)]
    public partial int DistanceBetweenRecords { get; set; }

    /// <summary>
    /// Gets or sets whether item is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public partial bool IsEnabled { get; set; }

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
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string Label { get; set; }

    /// <summary>
    /// Gets or sets the prompt.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT)]
    public partial string Prompt { get; set; }

    /// <summary>
    /// Gets or sets the prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN)]
    public partial Alignment PromptAlignment { get; set; }

    /// <summary>
    /// Gets or sets the prompt alignment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN_OFST)]
    public partial int PromptAlignmentOffset { get; set; }

    /// <summary>
    /// Gets or sets the prompt attachment edge.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_EDGE)]
    public partial EdgeAtachmentType PromptAttachmentEdge { get; set; }

    /// <summary>
    /// Gets or sets the prompt attachment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_OFST)]
    public partial int PromptAttachmentOffset { get; set; }

    /// <summary>
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public partial string PromptBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the prompt display style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_DISP_STY)]
    public partial PromptDisplayStyle PromptDisplayStyle { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public partial string PromptFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the prompt font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public partial string PromptFontName { get; set; }

    /// <summary>
    /// Gets or sets the prompt font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SIZ)]
    public partial int PromptFontSize { get; set; }

    /// <summary>
    /// Gets or sets the prompt font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SPCING)]
    public partial FontSpacing PromptFontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the prompt font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_STY)]
    public partial FontStyle PromptFontStyle { get; set; }

    /// <summary>
    /// Gets or sets the prompt font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_WGHT)]
    public partial FontWeight PromptFontWeight { get; set; }

    /// <summary>
    /// Gets or sets the prompt font foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public partial string PromptForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the prompt font justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_JST)]
    public partial int PromptJustification { get; set; }

    /// <summary>
    /// Gets or sets the prompt reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_READING_ORDR)]
    public partial ReadingOrder PromptReadingOrder { get; set; }

    /// <summary>
    /// Gets or sets the prompt visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_NAM)]
    public partial string PromptVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the prompt visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_OBJ)]
    public partial VisualAttribute PromptVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the radio button value.
    /// </summary>
    [Property(NdapiConstant.D2FP_RDB_VAL)]
    public partial string Value { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether item is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public partial bool IsVisible { get; set; }

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
