using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a visual attribute.
/// </summary>
public partial class VisualAttribute : NdapiObject<VisualAttribute>
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
    public partial string BackgroundColor { get; set; }

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
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public partial string PromptBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public partial string PromptFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the prompt's font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public partial string PromptFontName { get; set; }

    /// <summary>
    /// Gets or sets the prompt's font size.
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
    /// Gets or sets the prompt foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public partial string PromptForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute type.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_TYP)]
    public partial VisualAttributeType Type { get; set; }

    /// <summary>
    /// Gets or sets the white-on-black property.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public partial bool IsWhiteOnBlack { get; set; }
}
