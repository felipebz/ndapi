using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a block object.
/// </summary>
public partial class Block : NdapiObject<Block>
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
    /// Gets or sets whether the number of visible rows in a multi-record block should increase or decrease as the
    /// number of records in the block changes.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_SIZE_BLOCK)]
    public partial bool AutoSize { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string? BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [Property(NdapiConstant.D2FP_BLK_DESCRIPTION)]
    public partial string? Description { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets whether the block is a database block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DB_BLK)]
    public partial bool IsDatabaseBlock { get; set; }

    /// <summary>
    /// Gets or sets whether records can be deleted from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_ALLOWED)]
    public partial bool IsDeleteAllowed { get; set; }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for deleting data.
    /// This property is valid only when the <see cref="DmlDataTargetType"/> is set to <see cref="Enums.DmlDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_PROC_NAM)]
    public partial string? DeleteProcedureName { get; set; }

    /// <summary>
    /// Gets or sets the maximum array size for database operations at one time.
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_ARY_SIZ)]
    public partial int DmlArraySize { get; set; }

    /// <summary>
    /// Gets or sets the name of the block's DML data target. 
    /// This property is valid only when the <see cref="DmlDataTargetType"/> is set to <see cref="Enums.DmlDataTargetType.Table"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_DAT_NAM)]
    public partial string? DmlDataTargetName { get; set; }

    /// <summary>
    /// Gets or sets the DML data target type;
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_DAT_TYP)]
    public partial DmlDataTargetType DmlDataTargetType { get; set; }

    /// <summary>
    /// Gets or sets whether the runtime should enforce update privileges on a column-by-column basis for the block's base table.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENFRC_COL_SECURITY)]
    public partial bool EnforceColumnSecurity { get; set; }

    /// <summary>
    /// Gets or sets whether any record inserted or updated in the block must have a unique key in order to avoid committing duplicate rows to the block's base table. 
    /// </summary>
    [Property(NdapiConstant.D2FP_ENFRC_PRMRY_KEY)]
    public partial bool EnforcePrimaryKey { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string? FillPattern { get; set; }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public partial string? ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets whether records can be inserted from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_ALLOWED)]
    public partial bool IsInsertAllowed { get; set; }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for inserting data.
    /// This property is valid only when the <see cref="DmlDataTargetType"/> is set to <see cref="Enums.DmlDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_PROC_NAM)]
    public partial string? InsertProcedureName { get; set; }

    /// <summary>
    /// Gets or sets the key mode. This affects who the runtime uniquely identifies rows in the database.
    /// </summary>
    [Property(NdapiConstant.D2FP_KEY_MODE)]
    public partial KeyMode KeyMode { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the locking mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_MODE)]
    public partial LockingMode LockingMode { get; set; }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for locking data.
    /// This property is valid only when the <see cref="DmlDataTargetType"/> is set to <see cref="Enums.DmlDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_PROC_NAM)]
    public partial string? LockProcedureName { get; set; }

    /// <summary>
    /// Gets or sets whether the block should be listed in the block menu. 
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_IN_BLK_MNU)]
    public partial bool IsListedInBlockMenu { get; set; }

    /// <summary>
    /// Gets or sets the timeout to abort a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_QRY_TIME)]
    public partial int MaximumQueryTime { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of records the block can display at one time. The default is 0, which means it
    /// will use the (initial) value of the Number of Records Displayed Property.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_RECS_DISP)]
    public partial int MaximumRecordsDisplayed { get; set; }

    /// <summary>
    /// Gets or sets the number of records fetched before the query is aborted.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_RECS_FETCHED)]
    public partial int MaximumRecordsFetched { get; set; }

    /// <summary>
    /// Gets or sets the navigation style.
    /// </summary>
    [Property(NdapiConstant.D2FP_NAVIGATION_STY)]
    public partial NavigationStyle NavigationStyle { get; set; }

    /// <summary>
    /// Gets or sets the next navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_NXT_NAVIGATION_BLK_NAM)]
    public partial string? NextNavigationBlockName { get; set; }

    /// <summary>
    /// Gets or sets a hint string that runtime passes on to the RDBMS when constructing queries.
    /// </summary>
    [Property(NdapiConstant.D2FP_OPT_HINT)]
    public partial string? OptimizerHint { get; set; }

    /// <summary>
    /// Gets or sets the previous navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_PREV_NAVIGATION_BLK_NAM)]
    public partial string? PreviousNavigationBlockName { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should allow the end user to execute a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALLOWED)]
    public partial bool IsQueryAllowed { get; set; }

    /// <summary>
    /// Gets or sets whether all the records matching the query criteria should be fetched.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALL_RECS)]
    public partial bool IsQueryAllRecords { get; set; }

    /// <summary>
    /// Gets or sets the name of the block's query data source.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_NAM)]
    public partial string? QueryDataSourceName { get; set; }

    /// <summary>
    /// Gets or sets the query data source type.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_TYP)]
    public partial QueryDataSourceType QueryDataSourceType { get; set; }

    /// <summary>
    /// Gets or sets the minimum number of records buffered in memory during a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_BUFFERED_COUNT)]
    public partial int NumberOfRecordsBuffered { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of records that the block can display at one time.
    /// Setting this property greater than 1 creates a multi-record block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_DISP_COUNT)]
    public partial int NumberOfRecordsDisplayed { get; set; }

    /// <summary>
    /// Gets or sets the ORDER BY clause to be appended to the SELECT statement that runtime constructs whenever the
    /// user or the application executes a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_ORDR_BY_CLAUSE)]
    public partial string? OrderByClause { get; set; }

    /// <summary>
    /// Gets or sets the number of records that runtime expects an On-Fetch trigger to fetch.
    /// </summary>
    [Property(NdapiConstant.D2FP_RECS_FETCHED_COUNT)]
    public partial int RecordsToFetch { get; set; }

    /// <summary>
    /// Gets or sets the record orientation.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_ORNT)]
    public partial RecordOrientation RecordOrientation { get; set; }

    /// <summary>
    /// Gets or sets the name of the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_NAM)]
    public partial string? CurrentRecordVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public partial VisualAttribute? CurrentRecordVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the reverse direction property.
    /// </summary>
    [Property(NdapiConstant.D2FP_REV_DIR)]
    public partial bool IsReverseDirection { get; set; }

    /// <summary>
    /// Gets or sets the canvas on which the block's scrollbar should be displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_CNV_NAM)]
    public partial string? ScrollBarCanvasName { get; set; }

    /// <summary>
    /// Gets or sets whether the block scrollbar should be displayed horizontally or vertically.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_ORNT)]
    public partial ScrollBarOrientation ScrollBarOrientation { get; set; }

    /// <summary>
    /// Gets or sets the tab page on which the block's scrollbar should be displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_TBP_NAM)]
    public partial string? ScrollBarTabPageName { get; set; }

    /// <summary>
    /// Gets or sets the width of a block scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_LEN)]
    public partial int ScrollBarLength { get; set; }

    /// <summary>
    /// Gets or sets the width of a block scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_WID)]
    public partial int ScrollBarWidth { get; set; }

    /// <summary>
    /// Gets or sets the X position of the scrollbar measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_X_POS)]
    public partial int ScrollBarXPosition { get; set; }

    /// <summary>
    /// Gets or sets the Y position of the scrollbar measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_Y_POS)]
    public partial int ScrollBarYPosition { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should create a block scrollbar for the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_SCRLBR)]
    public partial bool ShowScrollBar { get; set; }

    /// <summary>
    /// Gets or sets whether block always should contain one record. 
    /// </summary>
    [Property(NdapiConstant.D2FP_SNGL_REC)]
    public partial bool IsSingleRecord { get; set; }

    /// <summary>
    /// Gets or sets the distance between tiles in a tiled group. For blocks with a Record Orientation of "Vertical"
    /// the group is laid out horizontally. Therefore, this property represents the horizonal distance between records
    /// in the group. For blocks with a Record Orientation of "Horizontal" the group is laid out vertically. Therefore,
    /// this property represents the vertical distance between records in the group.
    /// </summary>
    [Property(NdapiConstant.D2FP_TILE_DIST)]
    public partial int TileGroupDistance { get; set; }

    /// <summary>
    /// Gets or sets the number of records that should be displayed for each tile group.
    /// </summary>
    [Property(NdapiConstant.D2FP_TILE_RECS)]
    public partial int RecordsPerTileGroup { get; set; }

    /// <summary>
    /// Gets or sets whether records can be updated from the block. 
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_ALLOWED)]
    public partial bool IsUpdateAllowed { get; set; }

    /// <summary>
    /// Gets or sets whether only columns whose values were actually changed should be included in the SQL UPDATE
    /// statement that is sent to the database during a COMMIT.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_CHANGED_COLS)]
    public partial bool UpdateChangedColumnsOnly { get; set; }

    /// <summary>
    /// Gets or sets the name of the procedure to be used for updating data.
    /// This property is valid only when the <see cref="DmlDataTargetType"/> is set to <see cref="Enums.DmlDataTargetType.Procedure"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_PROC_NAM)]
    public partial string? UpdateProcedureName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string? VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the WHERE clause to be appended to the SELECT statement that runtime constructs whenever the
    /// user or the application executes a query in the block.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHERE_CLAUSE)]
    public partial string? WhereClause { get; set; }

    /// <summary>
    /// Gets or sets the white-on-black property.
    /// </summary>
    [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
    public partial bool IsWhiteOnBlack { get; set; }

    /// <summary>
    /// Gets or sets the row banding frequency. When row banding is set, every n-th instance of
    /// the record would appear in a different background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_ROW_BANDING_FREQ)]
    public partial int RowBandingFrequency { get; set; }

    /// <summary>
    /// Gets the delete data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_DAT_SRC_ARG)]
    public partial NdapiObjectList<DataSourceArgument> DeleteDataSourceArguments { get; }

    /// <summary>
    /// Gets the delete data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_DAT_SRC_COL)]
    public partial NdapiObjectList<DataSourceColumn> DeleteDataSourceColumns { get; }

    /// <summary>
    /// Gets the insert data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_INS_DAT_SRC_ARG)]
    public partial NdapiObjectList<DataSourceArgument> InsertDataSourceArguments { get; }

    /// <summary>
    /// Gets the insert data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_INS_DAT_SRC_COL)]
    public partial NdapiObjectList<DataSourceColumn> InsertDataSourceColumns { get; }

    /// <summary>
    /// Gets the child itens.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITEM)]
    public partial NdapiObjectList<Item> Items { get; }

    /// <summary>
    /// Gets the query data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_ARG)]
    public partial NdapiObjectList<DataSourceArgument> QueryDataSourceArguments { get; }

    /// <summary>
    /// Gets the query data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_DAT_SRC_COL)]
    public partial NdapiObjectList<DataSourceColumn> QueryDataSourceColumns { get; }

    /// <summary>
    /// Gets the block relations.
    /// </summary>
    [Property(NdapiConstant.D2FP_REL)]
    public partial NdapiObjectList<BlockRelation> Relations { get; }

    /// <summary>
    /// Gets the block-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public partial NdapiObjectList<Trigger> Triggers { get; }

    /// <summary>
    /// Gets the update data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPD_DAT_SRC_ARG)]
    public partial NdapiObjectList<DataSourceArgument> UpdateDataSourceArguments { get; }

    /// <summary>
    /// Gets the update data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPD_DAT_SRC_COL)]
    public partial NdapiObjectList<DataSourceColumn> UpdateDataSourceColumns { get; }

    /// <summary>
    /// Gets or sets the alias used in the SELECT statement for the table.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALIAS)]
    public partial string? Alias { get; set; }

    /// <summary>
    /// Gets or sets whether DML statements use the RETURNING clause.
    /// </summary>
    [Property(NdapiConstant.D2FP_DML_RET_VAL)]
    public partial bool DmlReturningValue { get; set; }

    /// <summary>
    /// Gets or sets whether the block includes the REF item of an object table.
    /// </summary>
    [Property(NdapiConstant.D2FP_INCLUDE_REFITEM)]
    public partial bool IncludeRefItem { get; set; }

    /// <summary>
    /// Gets or sets whether summaries are precomputed.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRECOMP_SUMM)]
    public partial bool PrecomputeSummaries { get; set; }

    /// <summary>
    /// Gets or sets the next navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_NXT_NAVIGATION_BLK_OBJ)]
    public partial Block? NextNavigationBlock { get; set; }

    /// <summary>
    /// Gets or sets the previous navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_PREV_NAVIGATION_BLK_OBJ)]
    public partial Block? PreviousNavigationBlock { get; set; }

    /// <summary>
    /// Gets or sets the canvas of the scroll bar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_CNV_OBJ)]
    public partial Canvas? ScrollBarCanvas { get; set; }

    /// <summary>
    /// Gets or sets the tab page of the scroll bar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SCRLBR_TBP_OBJ)]
    public partial TabPage? ScrollBarTabPage { get; set; }

    /// <summary>
    /// Gets the lock data source arguments.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_DAT_SRC_ARG)]
    public partial NdapiObjectList<DataSourceArgument> LockDataSourceArguments { get; }

    /// <summary>
    /// Gets the lock data source columns.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_DAT_SRC_COL)]
    public partial NdapiObjectList<DataSourceColumn> LockDataSourceColumns { get; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute? VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether the object is hidden.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIDE)]
    public partial bool IsHidden { get; set; }

    /// <summary>
    /// Gets or sets the logical attribute used in character mode. Forms 6i only.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHAR_MODE_LOGICAL_ATTR)]
    public partial string? CharacterModeLogicalAttribute { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the description.
    /// </summary>
    [Property(NdapiConstant.D2FP_BLK_DSCRP_STRID)]
    public partial int DescriptionStringId { get; set; }

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

    /// <summary>
    /// Compiles all of the PL/SQL code associated with the specified block. This includes all of 
    /// the trigger objects attached to the block, and all of the trigger objects attached to all items in the block.
    /// </summary>
    public void CompileObjects()
    {
        var status = NativeMethods.d2fblkco_CompileObj(NdapiContext.GetContext(), Handle);
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
