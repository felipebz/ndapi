using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a radio button object.
/// </summary>
public class RadioButton : NdapiObject<RadioButton>
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
    public string AccessKey
    {
        get => GetStringProperty(NdapiConstant.D2FP_ACCESS_KEY);
        set => SetStringProperty(NdapiConstant.D2FP_ACCESS_KEY, value);
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
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the distance between record.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIST_BTWN_RECS)]
    public int DistanceBetweenRecords
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DIST_BTWN_RECS);
        set => SetNumberProperty(NdapiConstant.D2FP_DIST_BTWN_RECS, value);
    }

    /// <summary>
    /// Gets or sets whether item is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public bool IsEnabled
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ENABLED);
        set => SetBooleanProperty(NdapiConstant.D2FP_ENABLED, value);
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
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public string Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_LABEL);
        set => SetStringProperty(NdapiConstant.D2FP_LABEL, value);
    }

    /// <summary>
    /// Gets or sets the prompt.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT)]
    public string Prompt
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN)]
    public Alignment PromptAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstant.D2FP_PRMPT_ALIGN);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN_OFST)]
    public int PromptAlignmentOffset
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN_OFST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment edge.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_EDGE)]
    public EdgeAtachmentType PromptAttachmentEdge
    {
        get => GetNumberProperty<EdgeAtachmentType>(NdapiConstant.D2FP_PRMPT_ATT_EDGE);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_EDGE, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_OFST)]
    public int PromptAttachmentOffset
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_OFST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public string PromptBackgroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt display style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_DISP_STY)]
    public PromptDisplayStyle PromptDisplayStyle
    {
        get => GetNumberProperty<PromptDisplayStyle>(NdapiConstant.D2FP_PRMPT_DISP_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_DISP_STY, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public string PromptFillPattern
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FILL_PAT);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public string PromptFontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SIZ)]
    public int PromptFontSize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the prompt font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SPCING)]
    public FontSpacing PromptFontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstant.D2FP_PRMPT_FONT_SPCING);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the prompt font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_STY)]
    public FontStyle PromptFontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstant.D2FP_PRMPT_FONT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the prompt font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_WGHT)]
    public FontWeight PromptFontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstant.D2FP_PRMPT_FONT_WGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public string PromptForegroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt font justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_JST)]
    public int PromptJustification
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_JST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_JST, value);
    }

    /// <summary>
    /// Gets or sets the prompt reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_READING_ORDR)]
    public ReadingOrder PromptReadingOrder
    {
        get => GetNumberProperty<ReadingOrder>(NdapiConstant.D2FP_PRMPT_READING_ORDR);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_READING_ORDR, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_NAM)]
    public string PromptVisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_VAT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_OBJ)]
    public VisualAttribute PromptVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_PRMPT_VAT_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_PRMPT_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the radio button value.
    /// </summary>
    [Property(NdapiConstant.D2FP_RDB_VAL)]
    public string Value
    {
        get => GetStringProperty(NdapiConstant.D2FP_RDB_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_RDB_VAL, value);
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
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public VisualAttribute VisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_VAT_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets whether item is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public bool IsVisible
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_VISIBLE);
        set => SetBooleanProperty(NdapiConstant.D2FP_VISIBLE, value);
    }

    /// <summary>
    /// Gets or sets the white-on-black property.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public bool IsWhiteOnBlack
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK);
        set => SetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK, value);
    }

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
