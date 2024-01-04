using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a visual attribute.
/// </summary>
public class VisualAttribute : NdapiObject<VisualAttribute>
{
    /// <summary>
    /// Creates a visual attribute.
    /// </summary>
    /// <param name="module">Visual attribute owner.</param>
    /// <param name="name">Visual attribute name.</param>
    public VisualAttribute(FormModule module, string name) : base(name, ObjectType.VisualAttribute, module)
    {
    }

    /// <summary>
    /// Creates a visual attribute.
    /// </summary>
    /// <param name="menu">Visual attribute owner.</param>
    /// <param name="name">Visual attribute name.</param>
    public VisualAttribute(MenuModule menu, string name) : base(name, ObjectType.VisualAttribute, menu)
    {
    }

    /// <summary>
    /// Creates a visual attribute.
    /// </summary>
    /// <param name="group">Visual attribute owner.</param>
    /// <param name="name">Visual attribute name.</param>
    public VisualAttribute(ObjectGroup group, string name) : base(name, ObjectType.VisualAttribute, group)
    {
    }

    internal VisualAttribute(ObjectSafeHandle handle) : base(handle, ObjectType.VisualAttribute)
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
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public string PromptBackgroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR, value);
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
    /// Gets or sets the prompt's font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public string PromptFontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt's font size.
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
    /// Gets or sets the prompt foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public string PromptForegroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute type.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_TYP)]
    public VisualAttributeType Type
    {
        get => GetNumberProperty<VisualAttributeType>(NdapiConstant.D2FP_VAT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_VAT_TYP, value);
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
}
