using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an item object.
/// </summary>
public partial class Item : NdapiObject<Item>
{
    /// <summary>
    /// Creates an item object.
    /// </summary>
    /// <param name="block">Item owner.</param>
    /// <param name="name">Item name.</param>
    public Item(Block block, string name) : base(name, ObjectType.Item, block)
    {
    }

    /// <summary>
    /// Creates an item object.
    /// </summary>
    /// <param name="group">Item owner.</param>
    /// <param name="name">Item name.</param>
    public Item(ObjectGroup group, string name) : base(name, ObjectType.Item, group)
    {
    }

    internal Item(ObjectSafeHandle handle) : base(handle, ObjectType.Item)
    {
    }

    /// <summary>
    /// Gets or sets the access key.
    /// </summary>
    [Property(NdapiConstant.D2FP_ACCESS_KEY)]
    public partial string AccessKey { get; set; }

    /// <summary>
    /// Gets or sets the audio channels.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUDIO_CHNNLS)]
    public partial SoundChannels AudioChannels { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display the <see cref="Hint"/> automatically.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_HINT)]
    public partial bool DisplayHintAutomatically { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should skip to the next item when the user fill the field.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_SKP)]
    public partial bool AutoSkip { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public partial string BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstant.D2FP_BEVEL)]
    public partial Bevel Bevel { get; set; }

    /// <summary>
    /// Gets or sets the calculation mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_CALC_MODE)]
    public partial CalculationMode CalculationMode { get; set; }

    /// <summary>
    /// Gets or sets whether query is case insensitive.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_INSENSITIVE_QRY)]
    public partial bool IsCaseInsensitiveQuery { get; set; }

    /// <summary>
    /// Gets or sets the case restriction.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_RSTRCTION)]
    public partial CaseRestriction CaseRestriction { get; set; }

    /// <summary>
    /// Gets or sets the checked value.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHKED_VAL)]
    public partial string Checked { get; set; }

    /// <summary>
    /// Gets or sets the checkbox other values.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHK_BX_OTHER_VALS)]
    public partial CheckBoxOtherValues CheckBoxOtherValues { get; set; }

    /// <summary>
    /// Gets or sets the audio compression quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_CMPRSSION_QLTY)]
    public partial CompressionQuality CompressionQuality { get; set; }

    /// <summary>
    /// Gets or sets the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_CNV_OBJ)]
    public partial Canvas Canvas { get; set; }

    /// <summary>
    /// Gets or sets the database column name.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_NAM)]
    public partial string ColumnName { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comments { get; set; }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMM_MODE)]
    public partial CommunicationMode CommunicationMode { get; set; }

    /// <summary>
    /// Gets or sets the sound compression.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMPRESS)]
    public partial SoundCompression Compress { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should hide the text entered in the field.
    /// </summary>
    [Property(NdapiConstant.D2FP_CONCEAL_DATA)]
    public partial bool ConcealData { get; set; }

    /// <summary>
    /// Gets or sets the name of the item to copy value from.
    /// </summary>
    [Property(NdapiConstant.D2FP_COPY_VAL_FROM_ITM)]
    public partial string CopyValueFromItem { get; set; }

    /// <summary>
    /// Gets or sets the name of the data source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_BLK)]
    public partial string DataSourceBlock { get; set; }

    /// <summary>
    /// Gets or sets the data source X axis.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_X_AXS)]
    public partial string DataSourceXAxis { get; set; }

    /// <summary>
    /// Gets or sets the data source Y axis.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_Y_AXS)]
    public partial string DataSourceYAxis { get; set; }

    /// <summary>
    /// Gets or sets the data type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_TYP)]
    public partial ItemDataType DataType { get; set; }

    /// <summary>
    /// Gets or sets whether the item is a database item.
    /// </summary>
    [Property(NdapiConstant.D2FP_DB_ITM)]
    public partial bool IsDatabaseItem { get; set; }

    /// <summary>
    /// Gets or sets whther the item should be identified as the default button.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_BTN)]
    public partial bool IsDefaultButton { get; set; }

    /// <summary>
    /// Gets or sets the display quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_QLTY)]
    public partial DisplayQuality DisplayQuality { get; set; }

    /// <summary>
    /// Gets or sets the distance between record.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIST_BTWN_RECS)]
    public partial int DistanceBetweenRecords { get; set; }

    /// <summary>
    /// Gets or sets the editor.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_OBJ)]
    public partial Editor Editor { get; set; }

    /// <summary>
    /// Gets or sets the X position of the editor measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_X_POS)]
    public partial int EditorXPosition { get; set; }

    /// <summary>
    /// Gets or sets the Y position of the editor measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_Y_POS)]
    public partial int EditorYPosition { get; set; }

    /// <summary>
    /// Gets or sets whether item is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public partial bool IsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the execution mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_MODE)]
    public partial ExecutionMode ExecutionMode { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public partial string FillPattern { get; set; }

    /// <summary>
    /// Gets or sets the fixed length.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIXED_LEN)]
    public partial bool IsFixedLength { get; set; }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLNAM)]
    public partial string FileName { get; set; }

    /// <summary>
    /// Gets or sets the format masl.
    /// </summary>
    [Property(NdapiConstant.D2FP_FMT_MSK)]
    public partial string FormatMask { get; set; }

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
    /// Gets or sets the formula.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORMULA)]
    public partial string Formula { get; set; }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstant.D2FP_HEIGHT)]
    public partial int Height { get; set; }

    /// <summary>
    /// Gets or sets the help book topic.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TOPIC)]
    public partial string HelpBookTopic { get; set; }

    /// <summary>
    /// Gets or sets the highest allowed value.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIGHEST_ALLOWED_VAL)]
    public partial string HighestAllowedValue { get; set; }

    /// <summary>
    /// Gets or sets the hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT)]
    public partial string Hint { get; set; }

    /// <summary>
    /// Gets or sets whether button is iconic.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICONIC)]
    public partial bool IsIconic { get; set; }

    /// <summary>
    /// Gets or sets the icon file name.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public partial string IconFilename { get; set; }

    /// <summary>
    /// Gets or sets the image depth.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMG_DPTH)]
    public partial ImageDepth ImageDepth { get; set; }

    /// <summary>
    /// Gets or sets the image format.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMG_FMT)]
    public partial ImageFormat ImageFormat { get; set; }

    /// <summary>
    /// Gets or sets the implementation class.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMPL_CLASS)]
    public partial string ImplementationClass { get; set; }

    /// <summary>
    /// Gets or sets the initial keyboard direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_KBRD_DIR)]
    public partial InitialKeyboardDirection InitialKeyboardDirection { get; set; }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_VAL)]
    public partial string InitialValue { get; set; }

    /// <summary>
    /// Gets or sets whether runtime allows inserting of data.
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_ALLOWED)]
    public partial bool IsInsertAllowed { get; set; }

    /// <summary>
    /// Gets or sets the number of items displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITMS_DISP)]
    public partial int NumberOfItemsDisplayed { get; set; }

    /// <summary>
    /// Gets or sets the item type.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITM_TYP)]
    public partial ItemType ItemType { get; set; }

    /// <summary>
    /// Gets or sets the justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_JUSTIFICATION)]
    public partial Justification Justification { get; set; }

    /// <summary>
    /// Gets or sets whether the field is navigable with keyboard.
    /// </summary>
    [Property(NdapiConstant.D2FP_KBRD_NAVIGABLE)]
    public partial bool IsKeyboardNavigable { get; set; }

    /// <summary>
    /// Gets or sets whether field should keep the last cursor position.
    /// </summary>
    [Property(NdapiConstant.D2FP_KEEP_CRSR_POS)]
    public partial bool KeepCursorPosition { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string Label { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets whether item should lock record.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_REC)]
    public partial bool LockRecord { get; set; }

    /// <summary>
    /// Gets or sets the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_OBJ)]
    public partial Lov Lov { get; set; }

    /// <summary>
    /// Gets or sets the name of the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_NAM)]
    public partial string LovName { get; set; }

    /// <summary>
    /// Gets or sets the X position of the list of values measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_X_POS)]
    public partial int LovXPosition { get; set; }

    /// <summary>
    /// Gets or sets the X position of the list of values measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_Y_POS)]
    public partial int LovYPosition { get; set; }

    /// <summary>
    /// Gets or sets the lowest allowed value.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOWEST_ALLOWED_VAL)]
    public partial string LowestAllowedValue { get; set; }

    /// <summary>
    /// Gets the list element count.
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_ELEMENT_COUNT)]
    public partial int ListElementCount { get; }

    /// <summary>
    /// Gets or sets the list style.
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_STY)]
    public partial ListStyle ListStyle { get; set; }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public partial int MaximumLength { get; set; }

    /// <summary>
    /// Gets or sets whether field allows multiple lines.
    /// </summary>
    [Property(NdapiConstant.D2FP_MLT_LIN)]
    public partial bool IsMultiLine { get; set; }

    /// <summary>
    /// Gets or sets whether item is navigable with mouse.
    /// </summary>
    [Property(NdapiConstant.D2FP_MOUSE_NAVIGATE)]
    public partial bool IsMouseNavigate { get; set; }

    /// <summary>
    /// Gets or sets the next navigation item.
    /// </summary>
    [Property(NdapiConstant.D2FP_NXT_NAVIGATION_ITM_OBJ)]
    public partial Item NextNavigationItem { get; set; }

    /// <summary>
    /// Gets or sets the OLE activation style.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_ACT_STY)]
    public partial OleActivationStyle OleActivationStyle { get; set; }

    /// <summary>
    /// Gets or sets the OLE class name.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_CLASS)]
    public partial string OleClass { get; set; }

    /// <summary>
    /// Gets or sets if OLE in-place activation is used for editing embedded OLE objects.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_INSD_OUT_SUPPORT)]
    public partial bool OleInsideOutSupport { get; set; }

    /// <summary>
    /// Gets or sets if the OLE server of the embedded object allows inside-out object support during in-place activation.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_IN_PLACE_ACT)]
    public partial bool OleInPlaceActivation { get; set; }

    /// <summary>
    /// Gets or sets which OLE popup menu commands are displayed and enabled when the mouse cursor is on the OLE 
    /// object and and the right mouse button is pressed.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_POPUP_MNU_ITMS)]
    public partial int OlePopUpMenuItems { get; set; }

    /// <summary>
    /// Gets or sets the OLE resize style.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_RESIZ_STY)]
    public partial OleResizeStyle OleResizeStyle { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display the OLE tenant type.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_SHOW_TNNT_TYP)]
    public partial bool ShowOleTenantType { get; set; }

    /// <summary>
    /// Gets or sets the OLE tenant aspect.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_TNNT_ASPCT)]
    public partial OleTenantAspect OleTenantAspect { get; set; }

    /// <summary>
    /// Gets or sets the OLE tentat type.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_TNNT_TYP)]
    public partial OleTenantTypes OleTenantType { get; set; }

    /// <summary>
    /// Gets or sets the mapping of other values.
    /// </summary>
    [Property(NdapiConstant.D2FP_OTHER_VALS)]
    public partial string MappingOfOtherValues { get; set; }

    /// <summary>
    /// Gets or sets the popup menu name.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_NAM)]
    public partial string PopupMenuName { get; set; }

    /// <summary>
    /// Gets or sets the popup menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_OBJ)]
    public partial Menu PopupMenu { get; set; }

    /// <summary>
    /// Gets or sets the popup visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_VA_OBJ)]
    public partial VisualAttribute PopUpVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the previous navigation item.
    /// </summary>
    [Property(NdapiConstant.D2FP_PREV_NAVIGATION_ITM_OBJ)]
    public partial Item PreviousNavigationItem { get; set; }

    /// <summary>
    /// Gets or sets the prompt.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT)]
    public partial string Prompt { get; set; }

    /// <summary>
    /// Gets or sets the prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN)]
    public partial Alignment PromptAlignment { get; set; }

    /// <summary>
    /// Gets or sets the prompt alignment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN_OFST)]
    public partial int PromptAlignmentOffset { get; set; }

    /// <summary>
    /// Gets or sets the prompt attachment edge.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_EDGE)]
    public partial EdgeAtachmentType PromptAttachmentEdge { get; set; }

    /// <summary>
    /// Gets or sets the prompt attachment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_OFST)]
    public partial int PromptAttachmentOffset { get; set; }

    /// <summary>
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public partial string PromptBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the prompt display style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_DISP_STY)]
    public partial PromptDisplayStyle PromptDisplayStyle { get; set; }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public partial string PromptFillPattern { get; set; }

    /// <summary>
    /// Gets or sets the prompt font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public partial string PromptFontName { get; set; }

    /// <summary>
    /// Gets or sets the prompt font size.
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
    /// Gets or sets the prompt font foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public partial string PromptForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets the prompt font justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_JST)]
    public partial Justification PromptJustification { get; set; }

    /// <summary>
    /// Gets or sets the prompt reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_READING_ORDR)]
    public partial ReadingOrder PromptReadingOrder { get; set; }

    /// <summary>
    /// Gets or sets the prompt visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_NAM)]
    public partial string PromptVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the prompt visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_OBJ)]
    public partial VisualAttribute PromptVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether the item is part of the primary key.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMRY_KEY)]
    public partial bool IsPrimaryKey { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should allow the end user to execute a query in the item.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALLOWED)]
    public partial bool IsQueryAllowed { get; set; }

    /// <summary>
    /// Gets or sets the length for entering queries.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_LEN)]
    public partial int QueryLength { get; set; }

    /// <summary>
    /// Gets or sets whether the item is query only.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ONLY)]
    public partial bool IsQueryOnly { get; set; }

    /// <summary>
    /// Gets or sets the reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_READING_ORDR)]
    public partial ReadingOrder ReadingOrder { get; set; }

    /// <summary>
    /// Gets or sets the name of the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_NAM)]
    public partial string CurrentRecordVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public partial VisualAttribute CurrentRecordVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether item is to be displayed as a rendered object when it does not have focus. 
    /// </summary>
    [Property(NdapiConstant.D2FP_RENDERED)]
    public partial bool IsRendered { get; set; }

    /// <summary>
    /// Gets or sets whether item is required.
    /// </summary>
    [Property(NdapiConstant.D2FP_REQUIRED)]
    public partial bool IsRequired { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a fast forward button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_FAST_FWD)]
    public partial bool ShowFastForwardButton { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR)]
    public partial bool ShowHorizonatalScrollbar { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a color palette.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_PALETTE)]
    public partial bool ShowPalette { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a play button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_PLAY)]
    public partial bool ShowPlayButton { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a record button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_REC)]
    public partial bool ShowRecordButton { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a rewind button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_REWIND)]
    public partial bool ShowRewindButton { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a time slider.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_SLIDER)]
    public partial bool ShowSlider { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a time indicator.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_TIME)]
    public partial bool ShowTimeIndicator { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a vertical scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VERT_SCRLBR)]
    public partial bool ShowVerticalScrollBar { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display a volume control.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VOLUME)]
    public partial bool ShowVolumeControl { get; set; }

    /// <summary>
    /// Gets or sets the sizing style.
    /// </summary>
    [Property(NdapiConstant.D2FP_SIZING_STY)]
    public partial ImageSizingStyle SizingStyle { get; set; }

    /// <summary>
    /// Gets or sets the sound format.
    /// </summary>
    [Property(NdapiConstant.D2FP_SND_FMT)]
    public partial SoundFormat SoundFormat { get; set; }

    /// <summary>
    /// Gets or sets the sound quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_SND_QLTY)]
    public partial SoundQuality SoundQuality { get; set; }

    /// <summary>
    /// Gets or sets the name of the block to summarize.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_BLK_NAM)]
    public partial string SummarizedBlock { get; set; }

    /// <summary>
    /// Gets or sets the summary function.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_FUNC)]
    public partial SummaryFunction SummarizedFunction { get; set; }

    /// <summary>
    /// Gets or sets the name of the item to summarize.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_ITM_NAM)]
    public partial string SummarizedItem { get; set; }

    /// <summary>
    /// Gets or sets the item to synchronize with;
    /// </summary>
    [Property(NdapiConstant.D2FP_SYNC_ITM_OBJ)]
    public partial Item SynchronizeWithItem { get; set; }

    /// <summary>
    /// Gets or sets the tab page.
    /// </summary>
    [Property(NdapiConstant.D2FP_TBP_OBJ)]
    public partial TabPage TabPage { get; set; }

    /// <summary>
    /// Gets or sets the tooltip.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOOLTIP)]
    public partial string Tooltip { get; set; }

    /// <summary>
    /// Gets or sets the tooltip visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOOLTIP_VAT_GRP)]
    public partial string TooltipVisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the value when unchecked.
    /// </summary>
    [Property(NdapiConstant.D2FP_UNCHKED_VAL)]
    public partial string ValueWhenUnchecked { get; set; }

    /// <summary>
    /// Gets or sets whether runtime allows the item to be updated.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_ALLOWED)]
    public partial bool IsUpdateAllowed { get; set; }

    /// <summary>
    /// Gets or sets whether a chart item is updated to reflect changes made by committing new or updated records to its source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_COMMIT)]
    public partial bool IsUpdateCommit { get; set; }

    /// <summary>
    /// Gets or sets whether user can modify the value of the item only when the current value of the item is NULL. 
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_IF_NULL)]
    public partial bool UpdateOnlyIfNull { get; set; }

    /// <summary>
    /// Gets or sets whether a chart item is updated to reflect changes made by querying records in its source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_QRY)]
    public partial bool UpdateQuery { get; set; }

    /// <summary>
    /// Gets or sets whether runtime shoud validate the data entered using the values of the associated <see cref="Lov"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VALIDATE_FROM_LST)]
    public partial bool ValidateFromList { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public partial VisualAttribute VisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets whether item is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public partial bool IsVisible { get; set; }

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
    /// Gets or sets the wrap style.
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
    /// Gets or sets the mouse cursor style that is displayed while hovering over that object.
    /// </summary>
    [Property(NdapiConstant.D2FP_CURSOR_STYLE)]
    public partial CursorStyle CursorStyle { get; set; }

    /// <summary>
    /// Gets or sets the row banding frequency. When row banding is set, every n-th instance of
    /// the item would appear in a different background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_ROW_BANDING_FREQ)]
    public partial int RowBandingFrequency { get; set; }

    /// <summary>
    /// Gets the radio button items.
    /// </summary>
    [Property(NdapiConstant.D2FP_RAD_BUT)]
    public partial NdapiObjectList<RadioButton> RadioButtons { get; }

    /// <summary>
    /// Gets the item-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public partial NdapiObjectList<Trigger> Triggers { get; }

    /// <summary>
    /// Gets the list elements. Valid only when <see cref="ItemType"/> is <see cref="ItemType.ListItem"/>.
    /// </summary>
    public IEnumerable<KeyValuePair<string, string>> ListElements
    {
        get
        {
            for (var i = 1; i <= ListElementCount; i++) // objects index is one-based
            {
                yield return GetListElementAt(i);
            }
        }
    }

    /// <summary>
    /// Compile the item-level triggers.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2fitmco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Inserts a list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which item should be inserted.</param>
    /// <param name="label">Element label.</param>
    /// <param name="value">Element value.</param>
    public void InsertListElementAt(int index, string label, string value)
    {
        var status = NativeMethods.d2fitmile_InsertListElem(NdapiContext.GetContext(), Handle, index, label, value);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which item should be removed.</param>
    public void DeleteListElementAt(int index)
    {
        var status = NativeMethods.d2fitmdle_DeleteListElem(NdapiContext.GetContext(), Handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the element.</param>
    /// <returns>The label and the value of the list element.</returns>
    public KeyValuePair<string, string> GetListElementAt(int index)
    {
        var status =
            NativeMethods.d2fitmgle_GetListElem(NdapiContext.GetContext(), Handle, index, out var label,
                out var value);
        Ensure.Success(status);
        return new KeyValuePair<string, string>(label, value);
    }

    /// <summary>
    /// Creates a radio button.
    /// </summary>
    /// <param name="name">Name of the radio button.</param>
    /// <returns>The child object.</returns>
    public RadioButton CreateRadioButton(string name) => new(this, name);

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="name">Name of the trigger.</param>
    /// <returns>The child object.</returns>
    public Trigger CreateTrigger(string name) => new(this, name);
}
