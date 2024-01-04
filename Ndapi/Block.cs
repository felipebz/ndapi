using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a block object.
/// </summary>
public class Block : NdapiObject<Block>
{
    /// <summary>
    /// Creates a block object.
    /// </summary>
    /// <param name="module">Block owner.</param>
    /// <param name="name">Block name.</param>
    public Block(FormModule module, string name) : base(name, ObjectType.Block, module)
    {
    }

    /// <summary>
    /// Creates a block object.
    /// </summary>
    /// <param name="group">Block owner.</param>
    /// <param name="name">Block name.</param>
    public Block(ObjectGroup group, string name) : base(name, ObjectType.Block, group)
    {
    }

    internal Block(ObjectSafeHandle handle) : base(handle, ObjectType.Block)
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
    /// Gets or sets the description.
    /// </summary>
    [Property(NdapiConstant.D2FP_BLK_DESCRIPTION)]
    public string Description
    {
        get => GetStringProperty(NdapiConstant.D2FP_BLK_DESCRIPTION);
        set => SetStringProperty(NdapiConstant.D2FP_BLK_DESCRIPTION, value);
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
    /// Gets or sets whether the block is a database block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DB_BLK)]
    public bool IsDatabaseBlock
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DB_BLK);
        set => SetBooleanProperty(NdapiConstant.D2FP_DB_BLK, value);
    }

    /// <summary>
    /// Gets or sets whether records can be deleted from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_ALLOWED)]
    public bool IsDeleteAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DEL_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_DEL_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for deleting data.
    /// This property is valid only when the <see cref="DMLDataTargetType"/> is set to <see cref="DMLDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_PROC_NAM)]
    public string DeleteProcedureName
    {
        get => GetStringProperty(NdapiConstant.D2FP_DEL_PROC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_DEL_PROC_NAM, value);
    }

    /// <summary>
    /// Gets or sets the maximum array size for database operations at one time.
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_ARY_SIZ)]
    public int DMLArraySize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DML_ARY_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_DML_ARY_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the name of the block's DML data target. 
    /// This property is valid only when the <see cref="DMLDataTargetType"/> is set to <see cref="DMLDataTargetType.Table"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_DAT_NAM)]
    public string DMLDataTargetName
    {
        get => GetStringProperty(NdapiConstant.D2FP_DML_DAT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_DML_DAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the DML data target type;
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_DAT_TYP)]
    public DMLDataTargetType DMLDataTargetType
    {
        get => GetNumberProperty<DMLDataTargetType>(NdapiConstant.D2FP_DML_DAT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_DML_DAT_TYP, value);
    }

    /// <summary>
    /// Gets or sets whether the runtime should enforce update privileges on a column-by-column basis for the block's base table.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENFRC_COL_SECURITY)]
    public bool EnforceColumnSecurity
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ENFRC_COL_SECURITY);
        set => SetBooleanProperty(NdapiConstant.D2FP_ENFRC_COL_SECURITY, value);
    }

    /// <summary>
    /// Gets or sets whether any record inserted or updated in the block must have a unique key in order to avoid committing duplicate rows to the block's base table. 
    /// </summary>
    [Property(NdapiConstant.D2FP_ENFRC_PRMRY_KEY)]
    public bool EnforcePrimaryKey
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ENFRC_PRMRY_KEY);
        set => SetBooleanProperty(NdapiConstant.D2FP_ENFRC_PRMRY_KEY, value);
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
    /// Gets or sets whether records can be inserted from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_ALLOWED)]
    public bool IsInsertAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_INSRT_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_INSRT_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for inserting data.
    /// This property is valid only when the <see cref="DMLDataTargetType"/> is set to <see cref="DMLDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_PROC_NAM)]
    public string InsertProcedureName
    {
        get => GetStringProperty(NdapiConstant.D2FP_INSRT_PROC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_INSRT_PROC_NAM, value);
    }

    /// <summary>
    /// Gets or sets the key mode. This affects who the runtime uniquely identifies rows in the database.
    /// </summary>
    [Property(NdapiConstant.D2FP_KEY_MODE)]
    public KeyMode KeyMode
    {
        get => GetNumberProperty<KeyMode>(NdapiConstant.D2FP_KEY_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_KEY_MODE, value);
    }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstant.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_LANG_DIR, value);
    }

    /// <summary>
    /// Gets or sets the locking mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_MODE)]
    public LockingMode LockingMode
    {
        get => GetNumberProperty<LockingMode>(NdapiConstant.D2FP_LOCK_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_LOCK_MODE, value);
    }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for locking data.
    /// This property is valid only when the <see cref="DMLDataTargetType"/> is set to <see cref="DMLDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_PROC_NAM)]
    public string LockProcedureName
    {
        get => GetStringProperty(NdapiConstant.D2FP_LOCK_PROC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_LOCK_PROC_NAM, value);
    }

    /// <summary>
    /// Gets or sets whether the block should be listed in the block menu. 
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_IN_BLK_MNU)]
    public bool IsListedInBlockMenu
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_LST_IN_BLK_MNU);
        set => SetBooleanProperty(NdapiConstant.D2FP_LST_IN_BLK_MNU, value);
    }

    /// <summary>
    /// Gets or sets the timeout to abort a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_QRY_TIME)]
    public int MaximumQueryTime
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_QRY_TIME);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_QRY_TIME, value);
    }

    /// <summary>
    /// Gets or sets the number of records fetched before the query is aborted.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_RECS_FETCHED)]
    public int MaximumRecordsFetched
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_RECS_FETCHED);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_RECS_FETCHED, value);
    }

    /// <summary>
    /// Gets or sets the navigation style.
    /// </summary>
    [Property(NdapiConstant.D2FP_NAVIGATION_STY)]
    public NavigationStyle NavigationStyle
    {
        get => GetNumberProperty<NavigationStyle>(NdapiConstant.D2FP_NAVIGATION_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_NAVIGATION_STY, value);
    }

    /// <summary>
    /// Gets or sets the next navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_NXT_NAVIGATION_BLK_NAM)]
    public string NextNavigationBlock
    {
        get => GetStringProperty(NdapiConstant.D2FP_NXT_NAVIGATION_BLK_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_NXT_NAVIGATION_BLK_NAM, value);
    }

    /// <summary>
    /// Gets or sets a hint string that runtime passes on to the RDBMS when constructing queries.
    /// </summary>
    [Property(NdapiConstant.D2FP_OPT_HINT)]
    public string OptimizerHint
    {
        get => GetStringProperty(NdapiConstant.D2FP_OPT_HINT);
        set => SetStringProperty(NdapiConstant.D2FP_OPT_HINT, value);
    }

    /// <summary>
    /// Gets or sets the previous navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_PREV_NAVIGATION_BLK_NAM)]
    public string PreviousNavigationBlock
    {
        get => GetStringProperty(NdapiConstant.D2FP_PREV_NAVIGATION_BLK_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PREV_NAVIGATION_BLK_NAM, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should allow the end user to execute a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALLOWED)]
    public bool IsQueryAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_QRY_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_QRY_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets whether all the records matching the query criteria should be fetched.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALL_RECS)]
    public bool IsQueryAllRecords
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_QRY_ALL_RECS);
        set => SetBooleanProperty(NdapiConstant.D2FP_QRY_ALL_RECS, value);
    }

    /// <summary>
    /// Gets or sets the name of the block's query data source.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_NAM)]
    public string QueryDataSourceName
    {
        get => GetStringProperty(NdapiConstant.D2FP_QRY_DAT_SRC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_QRY_DAT_SRC_NAM, value);
    }

    /// <summary>
    /// Gets or sets the query data source type.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_TYP)]
    public QueryDataSourceType QueryDataSourceType
    {
        get => GetNumberProperty<QueryDataSourceType>(NdapiConstant.D2FP_QRY_DAT_SRC_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_QRY_DAT_SRC_TYP, value);
    }

    /// <summary>
    /// Gets or sets the minimum number of records buffered in memory during a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_BUFFERED_COUNT)]
    public int NumberOfRecordsBuffered
    {
        get => GetNumberProperty(NdapiConstant.D2FP_RECS_BUFFERED_COUNT);
        set => SetNumberProperty(NdapiConstant.D2FP_RECS_BUFFERED_COUNT, value);
    }

    /// <summary>
    /// Gets or sets the maximum number of records that the block can display at one time.
    /// Setting this property greater than 1 creates a multi-record block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_DISP_COUNT)]
    public int NumberOfRecordsDisplayed
    {
        get => GetNumberProperty(NdapiConstant.D2FP_RECS_DISP_COUNT);
        set => SetNumberProperty(NdapiConstant.D2FP_RECS_DISP_COUNT, value);
    }

    /// <summary>
    /// Gets or sets the ORDER BY clause to be appended to the SELECT statement that runtime constructs whenever the
    /// user or the application executes a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_ORDR_BY_CLAUSE)]
    public string OrderByClause
    {
        get => GetStringProperty(NdapiConstant.D2FP_ORDR_BY_CLAUSE);
        set => SetStringProperty(NdapiConstant.D2FP_ORDR_BY_CLAUSE, value);
    }

    /// <summary>
    /// Gets or sets the number of records that runtime expects an On-Fetch trigger to fetch.
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_FETCHED_COUNT)]
    public int RecordsToFetch
    {
        get => GetNumberProperty(NdapiConstant.D2FP_RECS_FETCHED_COUNT);
        set => SetNumberProperty(NdapiConstant.D2FP_RECS_FETCHED_COUNT, value);
    }

    /// <summary>
    /// Gets or sets the record orientation.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_ORNT)]
    public RecordOrientation RecordOrientation
    {
        get => GetNumberProperty<RecordOrientation>(NdapiConstant.D2FP_REC_ORNT);
        set => SetNumberProperty(NdapiConstant.D2FP_REC_ORNT, value);
    }

    /// <summary>
    /// Gets or sets the name of the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_NAM)]
    public string CurrentRecordVisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_REC_VAT_GRP_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_REC_VAT_GRP_NAM, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public VisualAttribute CurrentRecordVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_REC_VAT_GRP_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_REC_VAT_GRP_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the reverse direction property.
    /// </summary>
    [Property(NdapiConstant.D2FP_REV_DIR)]
    public bool IsReverseDirection
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_REV_DIR);
        set => SetBooleanProperty(NdapiConstant.D2FP_REV_DIR, value);
    }

    /// <summary>
    /// Gets or sets the canvas on which the block's scrollbar should be displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_CNV_NAM)]
    public string ScrollBarCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_SCRLBR_CNV_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_SCRLBR_CNV_NAM, value);
    }

    /// <summary>
    /// Gets or sets whether the block scrollbar should be displayed horizontally or vertically.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_ORNT)]
    public ScrollBarOrientation ScrollBarOrientation
    {
        get => GetNumberProperty<ScrollBarOrientation>(NdapiConstant.D2FP_SCRLBR_ORNT);
        set => SetNumberProperty(NdapiConstant.D2FP_SCRLBR_ORNT, value);
    }

    /// <summary>
    /// Gets or sets the tab page on which the block's scrollbar should be displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_TBP_NAM)]
    public string ScrollBarTabPage
    {
        get => GetStringProperty(NdapiConstant.D2FP_SCRLBR_TBP_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_SCRLBR_TBP_NAM, value);
    }

    /// <summary>
    /// Gets or sets the width of a block scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_LEN)]
    public int ScrollBarLength
    {
        get => GetNumberProperty(NdapiConstant.D2FP_SCRLBR_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_SCRLBR_LEN, value);
    }

    /// <summary>
    /// Gets or sets the width of a block scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_WID)]
    public int ScrollBarWidth
    {
        get => GetNumberProperty(NdapiConstant.D2FP_SCRLBR_WID);
        set => SetNumberProperty(NdapiConstant.D2FP_SCRLBR_WID, value);
    }

    /// <summary>
    /// Gets or sets the X position of the scrollbar measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_X_POS)]
    public int ScrollBarXPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_SCRLBR_X_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_SCRLBR_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position of the scrollbar measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_Y_POS)]
    public int ScrollBarYPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_SCRLBR_Y_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_SCRLBR_Y_POS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should create a block scrollbar for the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_SCRLBR)]
    public bool ShowScrollBar
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_SCRLBR);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_SCRLBR, value);
    }

    /// <summary>
    /// Gets or sets whether block always should contain one record. 
    /// </summary>
    [Property(NdapiConstant.D2FP_SNGL_REC)]
    public bool IsSingleRecord
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SNGL_REC);
        set => SetBooleanProperty(NdapiConstant.D2FP_SNGL_REC, value);
    }

    /// <summary>
    /// Gets or sets whether records can be updated from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_ALLOWED)]
    public bool IsUpdateAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets whether only columns whose values were actually changed should be included in the SQL UPDATE
    /// statement that is sent to the database during a COMMIT.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_CHANGED_COLS)]
    public bool UpdateChangedColumnsOnly
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_CHANGED_COLS);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_CHANGED_COLS, value);
    }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for updating data.
    /// This property is valid only when the <see cref="DMLDataTargetType"/> is set to <see cref="DMLDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_PROC_NAM)]
    public string UpdateProcedureName
    {
        get => GetStringProperty(NdapiConstant.D2FP_UPDT_PROC_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_UPDT_PROC_NAM, value);
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
    /// Gets or sets the WHERE clause to be appended to the SELECT statement that runtime constructs whenever the
    /// user or the application executes a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHERE_CLAUSE)]
    public string WhereClause
    {
        get => GetStringProperty(NdapiConstant.D2FP_WHERE_CLAUSE);
        set => SetStringProperty(NdapiConstant.D2FP_WHERE_CLAUSE, value);
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
    /// Gets or sets the row banding frequency. When row banding is set, every n-th instance of
    /// the record would appear in a different background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_ROW_BANDING_FREQ)]
    public int RowBandingFrequency
    {
        get => GetNumberProperty(NdapiConstant.D2FP_ROW_BANDING_FREQ);
        set => SetNumberProperty(NdapiConstant.D2FP_ROW_BANDING_FREQ, value);
    }

    /// <summary>
    /// Gets the delete data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_DAT_SRC_ARG)]
    public NdapiObjectList<DataSourceArgument> DeleteDataSourceArguments =>
        GetObjectList<DataSourceArgument>(NdapiConstant.D2FP_DEL_DAT_SRC_ARG);

    /// <summary>
    /// Gets the delete data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_DAT_SRC_COL)]
    public NdapiObjectList<DataSourceColumn> DeleteDataSourceColumns =>
        GetObjectList<DataSourceColumn>(NdapiConstant.D2FP_DEL_DAT_SRC_COL);

    /// <summary>
    /// Gets the insert data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_INS_DAT_SRC_ARG)]
    public NdapiObjectList<DataSourceArgument> InsertDataSourceArguments =>
        GetObjectList<DataSourceArgument>(NdapiConstant.D2FP_INS_DAT_SRC_ARG);

    /// <summary>
    /// Gets the insert data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_INS_DAT_SRC_COL)]
    public NdapiObjectList<DataSourceColumn> InsertDataSourceColumns =>
        GetObjectList<DataSourceColumn>(NdapiConstant.D2FP_INS_DAT_SRC_COL);

    /// <summary>
    /// Gets the child itens.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITEM)]
    public NdapiObjectList<Item> Items =>
        GetObjectList<Item>(NdapiConstant.D2FP_ITEM);

    /// <summary>
    /// Gets the query data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_ARG)]
    public NdapiObjectList<DataSourceArgument> QueryDataSourceArguments =>
        GetObjectList<DataSourceArgument>(NdapiConstant.D2FP_QRY_DAT_SRC_ARG);

    /// <summary>
    /// Gets the query data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_COL)]
    public NdapiObjectList<DataSourceColumn> QueryDataSourceColumns =>
        GetObjectList<DataSourceColumn>(NdapiConstant.D2FP_QRY_DAT_SRC_COL);

    /// <summary>
    /// Gets the block relations.
    /// </summary>
    [Property(NdapiConstant.D2FP_REL)]
    public NdapiObjectList<BlockRelation> Relations =>
        GetObjectList<BlockRelation>(NdapiConstant.D2FP_REL);

    /// <summary>
    /// Gets the block-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public NdapiObjectList<Trigger> Triggers =>
        GetObjectList<Trigger>(NdapiConstant.D2FP_TRIGGER);

    /// <summary>
    /// Gets the update data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPD_DAT_SRC_ARG)]
    public NdapiObjectList<DataSourceArgument> UpdateDataSourceArguments =>
        GetObjectList<DataSourceArgument>(NdapiConstant.D2FP_UPD_DAT_SRC_ARG);

    /// <summary>
    /// Gets the update data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPD_DAT_SRC_COL)]
    public NdapiObjectList<DataSourceColumn> UpdateDataSourceColumns =>
        GetObjectList<DataSourceColumn>(NdapiConstant.D2FP_UPD_DAT_SRC_COL);

    /// <summary>
    /// Compiles all of the PL/SQL code associated with the specified block. This includes all of 
    /// the trigger objects attached to the block, and all of the trigger objects attached to all items in the block.
    /// </summary>
    public void CompileObjects()
    {
        var status = NativeMethods.d2fblkco_CompileObj(NdapiContext.GetContext(), _handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Creates a child item.
    /// </summary>
    /// <param name="name">Name of the child item.</param>
    /// <returns>The child object.</returns>
    public Item CreateItem(string name) => new(this, name);

    /// <summary>
    /// Creates a block relation.
    /// </summary>
    /// <param name="name">Name of the relation.</param>
    /// <returns>The child object.</returns>
    public BlockRelation CreateBlockRelation(string name) => new(this, name);

    /// <summary>
    /// Creates a child trigger.
    /// </summary>
    /// <param name="name">Name of the child trigger.</param>
    /// <returns>The child object.</returns>
    public Trigger CreateTrigger(string name) => new(this, name);
}
