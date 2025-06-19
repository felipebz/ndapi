using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a text segment.
/// </summary>
public partial class TextSegment : NdapiObject<TextSegment>
{
    /// <summary>
    /// Creates a text segment.
    /// </summary>
    /// <param name="compoundText">Text segment owner.</param>
    /// <param name="name">Text segment name.</param>
    public TextSegment(CompoundText compoundText, string name) : base(name, ObjectType.TextSegment, compoundText)
    {
    }

    internal TextSegment(ObjectSafeHandle handle) : base(handle, ObjectType.TextSegment)
    {
    }

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
    /// Gets or sets the text segment content.
    /// </summary>
    [Property(NdapiConstant.D2FP_TEXT)]
    public partial string Text { get; set; }
}
