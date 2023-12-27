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
    [Property(NdapiConstants.D2FP_ACCESS_KEY)]
    public string AccessKey
    {
        get => GetStringProperty(NdapiConstants.D2FP_ACCESS_KEY);
        set => SetStringProperty(NdapiConstants.D2FP_ACCESS_KEY, value);
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstants.D2FP_BACK_COLOR)]
    public string BackgroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_BACK_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstants.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstants.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstants.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the distance between record.
    /// </summary>
    [Property(NdapiConstants.D2FP_DIST_BTWN_RECS)]
    public int DistanceBetweenRecords
    {
        get => GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS);
        set => SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value);
    }

    /// <summary>
    /// Gets or sets whether item is enabled.
    /// </summary>
    [Property(NdapiConstants.D2FP_ENABLED)]
    public bool IsEnabled
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_ENABLED);
        set => SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_FILL_PAT)]
    public string FillPattern
    {
        get => GetStringProperty(NdapiConstants.D2FP_FILL_PAT);
        set => SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_NAM)]
    public string FontName
    {
        get => GetStringProperty(NdapiConstants.D2FP_FONT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_SIZ)]
    public int FontSize
    {
        get => GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ);
        set => SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_SPCING)]
    public FontSpacing FontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_STY)]
    public FontStyle FontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstants.D2FP_FONT_WGHT)]
    public FontWeight FontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_FORE_COLOR)]
    public string ForegroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_FORE_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstants.D2FP_HEIGHT)]
    public int Height
    {
        get => GetNumberProperty(NdapiConstants.D2FP_HEIGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value);
    }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstants.D2FP_LABEL)]
    public string Label
    {
        get => GetStringProperty(NdapiConstants.D2FP_LABEL);
        set => SetStringProperty(NdapiConstants.D2FP_LABEL, value);
    }

    /// <summary>
    /// Gets or sets the prompt.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT)]
    public string Prompt
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_ALIGN)]
    public Alignment PromptAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstants.D2FP_PRMPT_ALIGN);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_ALIGN_OFST)]
    public int PromptAlignmentOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment edge.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_ATT_EDGE)]
    public EdgeAtachmentType PromptAttachmentEdge
    {
        get => GetNumberProperty<EdgeAtachmentType>(NdapiConstants.D2FP_PRMPT_ATT_EDGE);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_EDGE, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment offset.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_ATT_OFST)]
    public int PromptAttachmentOffset
    {
        get => GetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_BACK_COLOR)]
    public string PromptBackgroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt display style.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_DISP_STY)]
    public PromptDisplayStyle PromptDisplayStyle
    {
        get => GetNumberProperty<PromptDisplayStyle>(NdapiConstants.D2FP_PRMPT_DISP_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_DISP_STY, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FILL_PAT)]
    public string PromptFillPattern
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font name.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FONT_NAM)]
    public string PromptFontName
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt font size.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FONT_SIZ)]
    public int PromptFontSize
    {
        get => GetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the prompt font spacing.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FONT_SPCING)]
    public FontSpacing PromptFontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_PRMPT_FONT_SPCING);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the prompt font style.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FONT_STY)]
    public FontStyle PromptFontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_PRMPT_FONT_STY);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the prompt font weight.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FONT_WGHT)]
    public FontWeight PromptFontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_PRMPT_FONT_WGHT);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font foreground color.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_FORE_COLOR)]
    public string PromptForegroundColor
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt font justification.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_JST)]
    public int PromptJustification
    {
        get => GetNumberProperty(NdapiConstants.D2FP_PRMPT_JST);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_JST, value);
    }

    /// <summary>
    /// Gets or sets the prompt reading order.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_READING_ORDR)]
    public ReadingOrder PromptReadingOrder
    {
        get => GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_PRMPT_READING_ORDR);
        set => SetNumberProperty(NdapiConstants.D2FP_PRMPT_READING_ORDR, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute name.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_VAT_NAM)]
    public string PromptVisualAttributeName
    {
        get => GetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute.
    /// </summary>
    [Property(NdapiConstants.D2FP_PRMPT_VAT_OBJ)]
    public VisualAttribute PromptVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_PRMPT_VAT_OBJ);
        set => SetObjectProperty(NdapiConstants.D2FP_PRMPT_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the radio button value.
    /// </summary>
    [Property(NdapiConstants.D2FP_RDB_VAL)]
    public string Value
    {
        get => GetStringProperty(NdapiConstants.D2FP_RDB_VAL);
        set => SetStringProperty(NdapiConstants.D2FP_RDB_VAL, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstants.D2FP_VAT_NAM)]
    public string VisualAttributeName
    {
        get => GetStringProperty(NdapiConstants.D2FP_VAT_NAM);
        set => SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstants.D2FP_VAT_OBJ)]
    public VisualAttribute VisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_VAT_OBJ);
        set => SetObjectProperty(NdapiConstants.D2FP_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets whether item is visible.
    /// </summary>
    [Property(NdapiConstants.D2FP_VISIBLE)]
    public bool IsVisible
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_VISIBLE);
        set => SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value);
    }

#if FORMS_6
        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstants.D2FP_WHITE_ON_BLACK)]
        public bool IsWhiteOnBlack
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK);
            set => SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value);
        }
#endif

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstants.D2FP_WIDTH)]
    public int Width
    {
        get => GetNumberProperty(NdapiConstants.D2FP_WIDTH);
        set => SetNumberProperty(NdapiConstants.D2FP_WIDTH, value);
    }

    /// <summary>
    /// Gets or sets the X position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstants.D2FP_X_POS)]
    public int XPosition
    {
        get => GetNumberProperty(NdapiConstants.D2FP_X_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstants.D2FP_Y_POS)]
    public int YPosition
    {
        get => GetNumberProperty(NdapiConstants.D2FP_Y_POS);
        set => SetNumberProperty(NdapiConstants.D2FP_Y_POS, value);
    }
}
