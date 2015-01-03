using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents an item object.
    /// </summary>
    public class Item : NdapiObject
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

        /// <summary>
        /// Creates an item object.
        /// </summary>
        /// <param name="library">Item owner.</param>
        /// <param name="name">Item name.</param>
        public Item(ObjectLibrary library, string name) : base(name, ObjectType.Item, library)
        {
        }

        internal Item(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the access key.
        /// </summary>
        public string AccessKey
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ACCESS_KEY); }
            set { SetStringProperty(NdapiConstants.D2FP_ACCESS_KEY, value); }
        }

        /// <summary>
        /// Gets or sets the audio channels.
        /// </summary>
        public SoundChannels AudioChannels
        {
            get { return GetNumberProperty<SoundChannels>(NdapiConstants.D2FP_AUDIO_CHNNLS); }
            set { SetNumberProperty(NdapiConstants.D2FP_AUDIO_CHNNLS, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display the <see cref="Hint"/> automatically.
        /// </summary>
        public bool DisplayHintAutomatically
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_HINT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_HINT, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should skip to the next item when the user fill the field.
        /// </summary>
        public bool AutoSkip
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP, value); }
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the appearance of the object border.
        /// </summary>
        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }

        /// <summary>
        /// Gets or sets the calculation mode.
        /// </summary>
        public CalculationMode CalculationMode
        {
            get { return GetNumberProperty<CalculationMode>(NdapiConstants.D2FP_CALC_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_CALC_MODE, value); }
        }

        /// <summary>
        /// Gets or sets whether query is case insensitive.
        /// </summary>
        public bool CaseInsensitiveQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CASE_INSENSITIVE_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CASE_INSENSITIVE_QRY, value); }
        }

        /// <summary>
        /// Gets or sets the case restriction.
        /// </summary>
        public CaseRestriction CaseRestriction
        {
            get { return GetNumberProperty<CaseRestriction>(NdapiConstants.D2FP_CASE_RSTRCTION); }
            set { SetNumberProperty(NdapiConstants.D2FP_CASE_RSTRCTION, value); }
        }

        /// <summary>
        /// Gets or sets the checked value.
        /// </summary>
        public string Checked
        {
            get { return GetStringProperty(NdapiConstants.D2FP_CHKED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_CHKED_VAL, value); }
        }

        /// <summary>
        /// Gets or sets the checkbox other values.
        /// </summary>
        public CheckBoxOtherValues CheckBoxOtherValues
        {
            get { return GetNumberProperty<CheckBoxOtherValues>(NdapiConstants.D2FP_CHK_BX_OTHER_VALS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CHK_BX_OTHER_VALS, value); }
        }

        /// <summary>
        /// Gets or sets the audio compression quality.
        /// </summary>
        public CompressionQuality CompressionQuality
        {
            get { return GetNumberProperty<CompressionQuality>(NdapiConstants.D2FP_CMPRSSION_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_CMPRSSION_QLTY, value); }
        }

        /// <summary>
        /// Gets or sets the canvas.
        /// </summary>
        public Canvas Canvas
        {
            get { return GetObjectProperty<Canvas>(NdapiConstants.D2FP_CNV_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_CNV_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the database column name.
        /// </summary>
        public string ColumnName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COL_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_COL_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comments
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the communication mode.
        /// </summary>
        public CommunicationMode CommunicationMode
        {
            get { return GetNumberProperty<CommunicationMode>(NdapiConstants.D2FP_COMM_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_COMM_MODE, value); }
        }

        /// <summary>
        /// Gets or sets the sound compression.
        /// </summary>
        public SoundCompression Compress
        {
            get { return GetNumberProperty<SoundCompression>(NdapiConstants.D2FP_COMPRESS); }
            set { SetNumberProperty(NdapiConstants.D2FP_COMPRESS, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should hide the text entered in the field.
        /// </summary>
        public bool ConcealData
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA, value); }
        }

        /// <summary>
        /// Gets or sets the name of the item to copy value from.
        /// </summary>
        public string CopyValueFromItem
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COPY_VAL_FROM_ITM); }
            set { SetStringProperty(NdapiConstants.D2FP_COPY_VAL_FROM_ITM, value); }
        }

        /// <summary>
        /// Gets or sets the name of the data source block.
        /// </summary>
        public string DataSourceBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK, value); }
        }

        /// <summary>
        /// Gets or sets the data source X axis.
        /// </summary>
        public string DataSourceXAxis
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_X_AXS); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_X_AXS, value); }
        }

        /// <summary>
        /// Gets or sets the data source Y axis.
        /// </summary>
        public string DataSourceYAxis
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_Y_AXS); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_Y_AXS, value); }
        }

        /// <summary>
        /// Gets or sets the data type.
        /// </summary>
        public ItemDataType DataType
        {
            get { return GetNumberProperty<ItemDataType>(NdapiConstants.D2FP_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DAT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets whether the item is a database item.
        /// </summary>
        public bool DatabaseItem
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DB_ITM); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DB_ITM, value); }
        }

        /// <summary>
        /// Gets or sets whther the item should be identified as the default button.
        /// </summary>
        public bool DefaultButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DFLT_BTN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DFLT_BTN, value); }
        }

        /// <summary>
        /// Gets or sets the display quality.
        /// </summary>
        public DisplayQuality DisplayQuality
        {
            get { return GetNumberProperty<DisplayQuality>(NdapiConstants.D2FP_DISP_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DISP_QLTY, value); }
        }

        /// <summary>
        /// Gets or sets the distance between record.
        /// </summary>
        public int DistanceBetweenRecords
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS); }
            set { SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value); }
        }

        /// <summary>
        /// Gets or sets the editor.
        /// </summary>
        public Editor Editor
        {
            get { return GetObjectProperty<Editor>(NdapiConstants.D2FP_EDT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_EDT_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the X position of the editor measured at the upper left corner.
        /// </summary>
        public int EditorXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_EDT_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_EDT_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position of the editor measured at the upper left corner.
        /// </summary>
        public int EditorYPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_EDT_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_EDT_Y_POS, value); }
        }

        /// <summary>
        /// Gets or sets whether item is enabled.
        /// </summary>
        public bool Enabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        /// <summary>
        /// Gets or sets the execution mode.
        /// </summary>
        public ExecutionMode ExecutionMode
        {
            get { return GetNumberProperty<ExecutionMode>(NdapiConstants.D2FP_EXEC_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_EXEC_MODE, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the fixed length.
        /// </summary>
        public bool FixedLength
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN, value); }
        }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        public string FileName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets the format masl.
        /// </summary>
        public string FormatMask
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FMT_MSK); }
            set { SetStringProperty(NdapiConstants.D2FP_FMT_MSK, value); }
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the formula.
        /// </summary>
        public string Formula
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORMULA); }
            set { SetStringProperty(NdapiConstants.D2FP_FORMULA, value); }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        /// <summary>
        /// Gets or sets the help book topic.
        /// </summary>
        public string HelpBookTopic
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC, value); }
        }

        /// <summary>
        /// Gets or sets the highest allowed value.
        /// </summary>
        public string HighestAllowedValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HIGHEST_ALLOWED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_HIGHEST_ALLOWED_VAL, value); }
        }

        /// <summary>
        /// Gets or sets the hint.
        /// </summary>
        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        /// <summary>
        /// Gets or sets whether button is iconic.
        /// </summary>
        public bool Iconic
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ICONIC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ICONIC, value); }
        }

        /// <summary>
        /// Gets or sets the icon file name.
        /// </summary>
        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets the image depth.
        /// </summary>
        public ImageDepth ImageDepth
        {
            get { return GetNumberProperty<ImageDepth>(NdapiConstants.D2FP_IMG_DPTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_IMG_DPTH, value); }
        }

        /// <summary>
        /// Gets or sets the image format.
        /// </summary>
        public ImageFormat ImageFormat
        {
            get { return GetNumberProperty<ImageFormat>(NdapiConstants.D2FP_IMG_FMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_IMG_FMT, value); }
        }

        /// <summary>
        /// Gets or sets the initial keyboard direction.
        /// </summary>
        public InitialKeyboardDirection InitialKeyboardDirection
        {
            get { return GetNumberProperty<InitialKeyboardDirection>(NdapiConstants.D2FP_INIT_KBRD_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_INIT_KBRD_DIR, value); }
        }

        /// <summary>
        /// Gets or sets the initial value.
        /// </summary>
        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_INIT_VAL, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime allows inserting of data.
        /// </summary>
        public bool InsertAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets the number of items displayed.
        /// </summary>
        public int NumberOfItemsDisplayed
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_ITMS_DISP); }
            set { SetNumberProperty(NdapiConstants.D2FP_ITMS_DISP, value); }
        }

        /// <summary>
        /// Gets or sets the item type.
        /// </summary>
        public ItemType ItemType
        {
            get { return GetNumberProperty<ItemType>(NdapiConstants.D2FP_ITM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_ITM_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the justification.
        /// </summary>
        public Justification Justification
        {
            get { return GetNumberProperty<Justification>(NdapiConstants.D2FP_JUSTIFICATION); }
            set { SetNumberProperty(NdapiConstants.D2FP_JUSTIFICATION, value); }
        }

        /// <summary>
        /// Gets or sets whether the field is navigable with keyboard.
        /// </summary>
        public bool KeyboardNavigable
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_KBRD_NAVIGABLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_KBRD_NAVIGABLE, value); }
        }

        /// <summary>
        /// Gets or sets whether field should keep the last cursor position.
        /// </summary>
        public bool KeepCursorPosition
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_KEEP_CRSR_POS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_KEEP_CRSR_POS, value); }
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        /// <summary>
        /// Gets or sets whether item should lock record.
        /// </summary>
        public bool LockRecord
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_LOCK_REC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_LOCK_REC, value); }
        }

        /// <summary>
        /// Gets or sets the list of values.
        /// </summary>
        public LOV LOV
        {
            get { return GetObjectProperty<LOV>(NdapiConstants.D2FP_LOV_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_LOV_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the name of the list of values.
        /// </summary>
        public string LOVName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LOV_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_LOV_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the X position of the list of values measured at the upper left corner.
        /// </summary>
        public int LOVXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LOV_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_LOV_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the X position of the list of values measured at the upper left corner.
        /// </summary>
        public int LOVXYosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LOV_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_LOV_Y_POS, value); }
        }

        /// <summary>
        /// Gets or sets the lowest allowed value.
        /// </summary>
        public string LowestAllowedValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LOWEST_ALLOWED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_LOWEST_ALLOWED_VAL, value); }
        }

        /// <summary>
        /// Gets the list element count.
        /// </summary>
        public int ListElementCount => GetNumberProperty(NdapiConstants.D2FP_LST_ELEMENT_COUNT);

        /// <summary>
        /// Gets or sets the list style.
        /// </summary>
        public ListStyle ListStyle
        {
            get { return GetNumberProperty<ListStyle>(NdapiConstants.D2FP_LST_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_LST_STY, value); }
        }

        /// <summary>
        /// Gets or sets the maximum length.
        /// </summary>
        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        /// <summary>
        /// Gets or sets whether field allows multiple lines.
        /// </summary>
        public bool MultiLine
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MLT_LIN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MLT_LIN, value); }
        }

        /// <summary>
        /// Gets or sets whether item is navigable with mouse.
        /// </summary>
        public bool MouseNavigate
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MOUSE_NAVIGATE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MOUSE_NAVIGATE, value); }
        }

        /// <summary>
        /// Gets or sets the next navigation item.
        /// </summary>
        public Item NextNavigationItem
        {
            get { return GetObjectProperty<Item>(NdapiConstants.D2FP_NXT_NAVIGATION_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_NXT_NAVIGATION_ITM_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the OLE activation style.
        /// </summary>
        public OleActivationStyle OLEActivationStyle
        {
            get { return GetNumberProperty<OleActivationStyle>(NdapiConstants.D2FP_OLE_ACT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_ACT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the OLE class name.
        /// </summary>
        public string OLEClass
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OLE_CLASS); }
            set { SetStringProperty(NdapiConstants.D2FP_OLE_CLASS, value); }
        }

        /// <summary>
        /// Gets or sets if OLE in-place activation is used for editing embedded OLE objects.
        /// </summary>
        public bool OLEInsideOutSupport
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_INSD_OUT_SUPPORT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_INSD_OUT_SUPPORT, value); }
        }

        /// <summary>
        /// Gets or sets if the OLE server of the embedded object allows inside-out object support during in-place activation.
        /// </summary>
        public bool OLEInPlaceActivation
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_IN_PLACE_ACT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_IN_PLACE_ACT, value); }
        }

        /// <summary>
        /// Gets or sets which OLE popup menu commands are displayed and enabled when the mouse cursor is on the OLE 
        /// object and and the right mouse button is pressed.
        /// </summary>
        public int OLEPopUpMenuItems
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_OLE_POPUP_MNU_ITMS); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_POPUP_MNU_ITMS, value); }
        }

        /// <summary>
        /// Gets or sets the OLE resize style.
        /// </summary>
        public OleResizeStyle OLEResizeStyle
        {
            get { return GetNumberProperty<OleResizeStyle>(NdapiConstants.D2FP_OLE_RESIZ_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_RESIZ_STY, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display the OLE tenant type.
        /// </summary>
        public bool ShowOLETenantType
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_SHOW_TNNT_TYP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_SHOW_TNNT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the OLE tenant aspect.
        /// </summary>
        public OleTenantAspect OLETenantAspect
        {
            get { return GetNumberProperty<OleTenantAspect>(NdapiConstants.D2FP_OLE_TNNT_ASPCT); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_TNNT_ASPCT, value); }
        }

        /// <summary>
        /// Gets or sets the OLE tentat type.
        /// </summary>
        public OleTenantTypes OLETenantType
        {
            get { return GetNumberProperty<OleTenantTypes>(NdapiConstants.D2FP_OLE_TNNT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_TNNT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the mapping of other values.
        /// </summary>
        public string MappingOfOtherValues
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OTHER_VALS); }
            set { SetStringProperty(NdapiConstants.D2FP_OTHER_VALS, value); }
        }

        /// <summary>
        /// Gets or sets the popup menu name.
        /// </summary>
        public string PopupMenuName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the popup menu.
        /// </summary>
        public Menu PopupMenu
        {
            get { return GetObjectProperty<Menu>(NdapiConstants.D2FP_POPUP_MNU_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_POPUP_MNU_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the popup visual attribute.
        /// </summary>
        public VisualAttribute PopUpVisualAttribute
        {
            get { return GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_POPUP_VA_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_POPUP_VA_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the previous navigation item.
        /// </summary>
        public Item PreviousNavigationItem
        {
            get { return GetObjectProperty<Item>(NdapiConstants.D2FP_PREV_NAVIGATION_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_PREV_NAVIGATION_ITM_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the prompt.
        /// </summary>
        public string Prompt
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT, value); }
        }

        /// <summary>
        /// Gets or sets the prompt alignment.
        /// </summary>
        public Alignment PromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the prompt alignment offset.
        /// </summary>
        public int PromptAlignmentOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the prompt attachment edge.
        /// </summary>
        public EdgeAtachmentType PromptAttachmentEdge
        {
            get { return GetNumberProperty<EdgeAtachmentType>(NdapiConstants.D2FP_PRMPT_ATT_EDGE); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_EDGE, value); }
        }

        /// <summary>
        /// Gets or sets the prompt attachment offset.
        /// </summary>
        public int PromptAttachementOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the prompt background color.
        /// </summary>
        public string PromptBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the prompt display style.
        /// </summary>
        public PromptDisplayStyle PromptDisplayStyle
        {
            get { return GetNumberProperty<PromptDisplayStyle>(NdapiConstants.D2FP_PRMPT_DISP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_DISP_STY, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the prompt's fill region.
        /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
        /// </summary>
        public string PromptFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font name.
        /// </summary>
        public string PromptFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font size.
        /// </summary>
        public int PromptFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font spacing.
        /// </summary>
        public FontSpacing PromptFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_PRMPT_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font style.
        /// </summary>
        public FontStyle PromptFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_PRMPT_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font weight.
        /// </summary>
        public FontWeight PromptFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_PRMPT_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font foreground color.
        /// </summary>
        public string PromptForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font justification.
        /// </summary>
        public Justification PromptJustification
        {
            get { return GetNumberProperty<Justification>(NdapiConstants.D2FP_PRMPT_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_JST, value); }
        }

        /// <summary>
        /// Gets or sets the prompt reading order.
        /// </summary>
        public ReadingOrder PromptReadingOrder
        {
            get { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_PRMPT_READING_ORDR); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_READING_ORDR, value); }
        }

        /// <summary>
        /// Gets or sets the prompt visual attribute name.
        /// </summary>
        public string PromptVisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the prompt visual attribute.
        /// </summary>
        public VisualAttribute PromptVisualAttribute
        {
            get { return GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_PRMPT_VAT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_PRMPT_VAT_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets whether the item is part of the primary key.
        /// </summary>
        public bool PrimaryKey
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_PRMRY_KEY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_PRMRY_KEY, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should allow the end user to execute a query in the item.
        /// </summary>
        public bool QueryAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets the length for entering queries.
        /// </summary>
        public int QueryLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_QRY_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_QRY_LEN, value); }
        }

        /// <summary>
        /// Gets or sets whether the item is query only.
        /// </summary>
        public bool QueryOnly
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ONLY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ONLY, value); }
        }

        /// <summary>
        /// Gets or sets the reading order.
        /// </summary>
        public ReadingOrder ReadingOrder
        {
            get { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_READING_ORDR); }
            set { SetNumberProperty(NdapiConstants.D2FP_READING_ORDR, value); }
        }

        /// <summary>
        /// Gets or sets the name of the visual attribute used when an item is part of the current record.
        /// </summary>
        public string CurrentRecordVisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute used when an item is part of the current record.
        /// </summary>
        public VisualAttribute CurrentRecordVisualAttribute
        {
            get { return GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_REC_VAT_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_VAT_GRP_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets whether item is to be displayed as a rendered object when it does not have focus. 
        /// </summary>
        public bool Rendered
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RENDERED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RENDERED, value); }
        }

        /// <summary>
        /// Gets or sets whether item is required.
        /// </summary>
        public bool Required
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_REQUIRED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_REQUIRED, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a fast forward button.
        /// </summary>
        public bool ShowFastForwardButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_FAST_FWD); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_FAST_FWD, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a horizontal toolbar.
        /// </summary>
        public bool ShowHorizonatalScrollbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a color palette.
        /// </summary>
        public bool ShowPalette
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_PALETTE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_PALETTE, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a play button.
        /// </summary>
        public bool ShowPlayButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_PLAY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_PLAY, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a record button.
        /// </summary>
        public bool ShowRecordButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_REC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_REC, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a rewind button.
        /// </summary>
        public bool ShowRewindButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_REWIND); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_REWIND, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a time slider.
        /// </summary>
        public bool ShowSlider
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_SLIDER); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_SLIDER, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a time indicator.
        /// </summary>
        public bool ShowTimeIndicator
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_TIME); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_TIME, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a vertical scrollbar.
        /// </summary>
        public bool ShowVerticalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display a volume control.
        /// </summary>
        public bool ShowVolumeControl
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VOLUME); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VOLUME, value); }
        }

        /// <summary>
        /// Gets or sets the sizing style.
        /// </summary>
        public ImageSizingStyle SizingStyle
        {
            get { return GetNumberProperty<ImageSizingStyle>(NdapiConstants.D2FP_SIZING_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_SIZING_STY, value); }
        }

        /// <summary>
        /// Gets or sets the sound format.
        /// </summary>
        public SoundFormat SoundFormat
        {
            get { return GetNumberProperty<SoundFormat>(NdapiConstants.D2FP_SND_FMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_SND_FMT, value); }
        }

        /// <summary>
        /// Gets or sets the sound quality.
        /// </summary>
        public SoundQuality SoundQuality
        {
            get { return GetNumberProperty<SoundQuality>(NdapiConstants.D2FP_SND_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_SND_QLTY, value); }
        }

        /// <summary>
        /// Gets or sets the name of the block to summarize.
        /// </summary>
        public string SummarizedBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUMM_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SUMM_BLK_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the summary function.
        /// </summary>
        public SummaryFunction SummarizedFunction
        {
            get { return GetNumberProperty<SummaryFunction>(NdapiConstants.D2FP_SUMM_FUNC); }
            set { SetNumberProperty(NdapiConstants.D2FP_SUMM_FUNC, value); }
        }

        /// <summary>
        /// Gets or sets the name of the item to summarize.
        /// </summary>
        public string SummarizedItem
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUMM_ITM_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SUMM_ITM_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the item to synchronize with;
        /// </summary>
        public Item SynchronizeWithItem
        {
            get { return GetObjectProperty<Item>(NdapiConstants.D2FP_SYNC_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_SYNC_ITM_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the tab page.
        /// </summary>
        public TabPage TabPage
        {
            get { return GetObjectProperty<TabPage>(NdapiConstants.D2FP_TBP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_TBP_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        public string Tooltip
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TOOLTIP); }
            set { SetStringProperty(NdapiConstants.D2FP_TOOLTIP, value); }
        }

        /// <summary>
        /// Gets or sets the tooltip visual attribute name.
        /// </summary>
        public string TooltipVisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TOOLTIP_VAT_GRP); }
            set { SetStringProperty(NdapiConstants.D2FP_TOOLTIP_VAT_GRP, value); }
        }

        /// <summary>
        /// Gets or sets the value when unchecked.
        /// </summary>
        public string ValueWhenUnchecked
        {
            get { return GetStringProperty(NdapiConstants.D2FP_UNCHKED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_UNCHKED_VAL, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime allows the item to be updated.
        /// </summary>
        public bool UpdateAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED, value); }
        }

        /// <summary>
        /// Gets or sets whether a chart item is updated to reflect changes made by committing new or updated records to its source block.
        /// </summary>
        public bool UpdateCommit
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_COMMIT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_COMMIT, value); }
        }

        /// <summary>
        /// Gets or sets whether user can modify the value of the item only when the current value of the item is NULL. 
        /// </summary>
        public bool UpdateOnlyIfNull
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_IF_NULL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_IF_NULL, value); }
        }

        /// <summary>
        /// Gets or sets whether a chart item is updated to reflect changes made by querying records in its source block.
        /// </summary>
        public bool UpdateQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_QRY, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime shoud validate the data entered using the values of the associated <see cref="LOV"/>.
        /// </summary>
        public bool ValidateFromList
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VALIDATE_FROM_LST); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VALIDATE_FROM_LST, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute.
        /// </summary>
        public VisualAttribute VisualAttribute
        {
            get { return GetObjectProperty<VisualAttribute>(NdapiConstants.D2FP_VAT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_VAT_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets whether item is visible.
        /// </summary>
        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        /// <summary>
        /// Gets or sets the wrap style.
        /// </summary>
        public WrapStyle WrapStyle
        {
            get { return GetNumberProperty<WrapStyle>(NdapiConstants.D2FP_WRAP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_WRAP_STY, value); }
        }

        /// <summary>
        /// Gets or sets the X position measured at the upper left corner.
        /// </summary>
        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position measured at the upper left corner.
        /// </summary>
        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }

        /// <summary>
        /// Gets the radio button items.
        /// </summary>
        public NdapiObject RadioButtons => GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_RAD_BUT);

        /// <summary>
        /// Gets the item-level triggers.
        /// </summary>
        public IEnumerable<Trigger> Triggers => GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER);

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
            var status = NativeMethods.d2fitmco_CompileObj(NdapiContext.Context, _handle);
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
            var status = NativeMethods.d2fitmile_InsertListElem(NdapiContext.Context, _handle, index, label, value);
            Ensure.Success(status);
        }

        /// <summary>
        /// Deletes the list element in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which item should be removed.</param>
        public void DeleteListElementAt(int index)
        {
            var status = NativeMethods.d2fitmdle_DeleteListElem(NdapiContext.Context, _handle, index);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the list element in the specified index.
        /// </summary>
        /// <param name="index">The one-based index of the element.</param>
        /// <returns>The label and the value of the list element.</returns>
        public KeyValuePair<string, string> GetListElementAt(int index)
        {
            string label, value;
            var status = NativeMethods.d2fitmgle_GetListElem(NdapiContext.Context, _handle, index, out label, out value);
            Ensure.Success(status);
            return new KeyValuePair<string, string>(label, value);
        }
    }
}
