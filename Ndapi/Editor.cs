using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an editor object.
/// </summary>
public partial class Editor : NdapiObject<Editor>
{
    /// <summary>
    /// Creates an editor.
    /// </summary>
    /// <param name="module">Editor owner.</param>
    /// <param name="name">Editor name.</param>
    public Editor(FormModule module, string name) : base(name, ObjectType.Editor, module)
    {
    }

    /// <summary>
    /// Creates an editor.
    /// </summary>
    /// <param name="group">Editor owner.</param>
    /// <param name="name">Editor name.</param>
    public Editor(ObjectGroup group, string name) : base(name, ObjectType.Editor, group)
    {
    }

    internal Editor(ObjectSafeHandle handle) : base(handle, ObjectType.Editor)
    {
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the bottom title.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTM_TTL)]
    public partial string BottomTitle { get; set; }

    /// <summary>
    /// Gets or sets  whether this object should display a character counter beneath the text input area. If the counter
    /// is displayed, it will show the current number of characters followed by the maximum length allowed.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_COUNTER)]
    public partial bool DisplayCharacterCounter { get; set; }

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
    /// Gets or sets the content's wrap style.
    /// </summary>
    [Property(NdapiConstant.D2FP_WRAP_STY)]
    public partial WrapStyle WrapStyle { get; set; }

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

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string CharacterModeLogicalAttribute { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE_STRID)]
    public partial int TitleStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the bottom title.
    /// </summary>
    [Property(NdapiConstant.D2FP_BTM_TTL_STRID)]
    public partial int BottomTitleStringId { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject Source { get; }

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
