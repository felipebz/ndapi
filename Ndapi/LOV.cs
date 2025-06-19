using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a list of values.
/// </summary>
public partial class Lov : NdapiObject<Lov>
{
    /// <summary>
    /// Creates a list of values.
    /// </summary>
    /// <param name="module">List of values owner.</param>
    /// <param name="name">List of values name.</param>
    public Lov(FormModule module, string name) : base(name, ObjectType.Lov, module)
    {
    }

    /// <summary>
    /// Creates a list of values.
    /// </summary>
    /// <param name="group">List of values owner.</param>
    /// <param name="name">List of values name.</param>
    public Lov(ObjectGroup group, string name) : base(name, ObjectType.Lov, group)
    {
    }

    internal Lov(ObjectSafeHandle handle) : base(handle, ObjectType.Lov)
    {
    }

    /// <summary>
    /// Gets or sets whether runtime should adjust the width of columns automatically.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_COL_WID)]
    public partial bool IsAutomaticColumnWidth { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display the LOV automatically when the user or
    /// the application navigates into a text item to which the LOV is attached.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_DISP)]
    public partial bool IsAutomaticDisplay { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should position the LOV automatically near the field from which it was invoked. 
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_POS)]
    public partial bool IsAutomaticPosition { get; set; }

    /// <summary>
    /// Gets or sets whether runtime re-executes the query to populate an LOV that is based on a query record group.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_RFRSH)]
    public partial bool IsAutomaticRefresh { get; set; }

    /// <summary>
    /// Gets or sets whether runtime moves the cursor to the next navigable item when the user makes 
    /// a selection from an LOV to a text item. 
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_SKP)]
    public partial bool IsAutomaticSkip { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should select automatically the row when the result list is reduced to a single choice
    /// (by using auto-reduction or searching). If true, the LOV is dismissed automatically and column values from the 
    /// single row are assigned to their corresponding return items. If false, the LOV remains displayed, giving the user 
    /// the option to explicitly select the remaining choice or dismiss the LOV.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_SLCT)]
    public partial bool IsAutomaticSelect { get; set; }

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
    /// Gets or sets whether runtime allows the user to enter a query criteria before displaying the query results.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLTR_BEFORE_DISP)]
    public partial bool FilterBeforeDisplay { get; set; }

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
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the list type.
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_TYP)]
    public partial ListType ListType { get; set; }

    /// <summary>
    /// Gets or sets the LOV text (included only for compatibility).
    /// </summary>
    [Property(NdapiConstant.D2FP_OLD_LOV_TXT)]
    public partial string OldLovText { get; set; }

    /// <summary>
    /// Gets or sets the record group associated with the LOV.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP_OBJ)]
    public partial RecordGroup RecordGroup { get; set; }

    /// <summary>
    /// Gets or sets the LOV title.
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
    /// Gets all the LOV column mappings.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_MAP)]
    public partial NdapiObjectList<ColumnMapping> ColumnMappings { get; }

    /// <summary>
    /// Creates a column mapping.
    /// </summary>
    /// <param name="name">Name of the column mapping.</param>
    /// <returns>The child object.</returns>
    public ColumnMapping CreateColumnMapping(string name) => new(this, name);
}
