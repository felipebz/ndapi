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
    public partial string? BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

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
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public partial string? PromptBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public partial string? PromptFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the prompt's font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public partial string? PromptFontName { get; set; }

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
    public partial string? PromptForegroundColor { get; set; }

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

    /// <summary>
    /// Gets or sets the frame title background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_BACK_COLOR)]
    public partial string? FrameTitleBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the frame title fill pattern.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FILL_PAT)]
    public partial string? FrameTitleFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the frame title font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_NAM)]
    public partial string? FrameTitleFontName { get; set; }

    /// <summary>
    /// Gets or sets the frame title font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_SIZ)]
    public partial int FrameTitleFontSize { get; set; }

    /// <summary>
    /// Gets or sets the frame title font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_SPCING)]
    public partial FontSpacing FrameTitleFontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the frame title font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_STY)]
    public partial FontStyle FrameTitleFontStyle { get; set; }

    /// <summary>
    /// Gets or sets the frame title font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FONT_WGHT)]
    public partial FontWeight FrameTitleFontWeight { get; set; }

    /// <summary>
    /// Gets or sets the frame title foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRAME_TTL_FORE_COLOR)]
    public partial string? FrameTitleForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string? CharacterModeLogicalAttribute { get; set; }

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
