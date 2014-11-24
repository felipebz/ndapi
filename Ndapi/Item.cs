using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class Item : NdapiObject
    {
        public Item()
        {
        }

        public Item(string name)
        {
            Create(name, NdapiConstants.D2FFO_ITEM);
        }

        internal Item(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string AccessKey
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ACCESS_KEY); }
            set { SetStringProperty(NdapiConstants.D2FP_ACCESS_KEY, value); }
        }

        public SoundChannels AudioChannels
        {
            get { return GetNumberProperty<SoundChannels>(NdapiConstants.D2FP_AUDIO_CHNNLS); }
            set { SetNumberProperty(NdapiConstants.D2FP_AUDIO_CHNNLS, value); }
        }

        public bool DisplayHintAutomatically
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_HINT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_HINT, value); }
        }

        public bool AutoSkip
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP, value); }
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }

        public CalculationMode CalculationMode
        {
            get { return GetNumberProperty<CalculationMode>(NdapiConstants.D2FP_CALC_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_CALC_MODE, value); }
        }

        public bool CaseInsensitiveQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CASE_INSENSITIVE_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CASE_INSENSITIVE_QRY, value); }
        }

        public CaseRestriction CaseRestriction
        {
            get { return GetNumberProperty<CaseRestriction>(NdapiConstants.D2FP_CASE_RSTRCTION); }
            set { SetNumberProperty(NdapiConstants.D2FP_CASE_RSTRCTION, value); }
        }

        public string Checked
        {
            get { return GetStringProperty(NdapiConstants.D2FP_CHKED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_CHKED_VAL, value); }
        }

        public CheckBoxOtherValues CheckBoxOtherValues
        {
            get { return GetNumberProperty<CheckBoxOtherValues>(NdapiConstants.D2FP_CHK_BX_OTHER_VALS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CHK_BX_OTHER_VALS, value); }
        }

        public CompressionQuality CompressionQuality
        {
            get { return GetNumberProperty<CompressionQuality>(NdapiConstants.D2FP_CMPRSSION_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_CMPRSSION_QLTY, value); }
        }

        public NdapiObject Canvas
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_CNV_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_CNV_OBJ, value); }
        }

        public string ColumnName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COL_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_COL_NAM, value); }
        }

        public string Comments
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public CommunicationMode CommunicationMode
        {
            get { return GetNumberProperty<CommunicationMode>(NdapiConstants.D2FP_COMM_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_COMM_MODE, value); }
        }

        public SoundCompression Compress
        {
            get { return GetNumberProperty<SoundCompression>(NdapiConstants.D2FP_COMPRESS); }
            set { SetNumberProperty(NdapiConstants.D2FP_COMPRESS, value); }
        }

        public bool ConcealData
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CONCEAL_DATA, value); }
        }

        public string CopyValueFromItem
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COPY_VAL_FROM_ITM); }
            set { SetStringProperty(NdapiConstants.D2FP_COPY_VAL_FROM_ITM, value); }
        }

        public string DataSourceBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_BLK, value); }
        }

        public string DataSourceXAxis
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_X_AXS); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_X_AXS, value); }
        }

        public string DataSourceYAxis
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DAT_SRC_Y_AXS); }
            set { SetStringProperty(NdapiConstants.D2FP_DAT_SRC_Y_AXS, value); }
        }

        public ItemDataType DataType
        {
            get { return GetNumberProperty<ItemDataType>(NdapiConstants.D2FP_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DAT_TYP, value); }
        }

        public bool DatabaseItem
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DB_ITM); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DB_ITM, value); }
        }

        public bool DefaultButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DFLT_BTN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DFLT_BTN, value); }
        }

        public DisplayQuality DisplayQuality
        {
            get { return GetNumberProperty<DisplayQuality>(NdapiConstants.D2FP_DISP_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DISP_QLTY, value); }
        }

        public int DistanceBetweenRecords
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS); }
            set { SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value); }
        }

        public NdapiObject Editor
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_EDT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_EDT_OBJ, value); }
        }

        public int EditorXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_EDT_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_EDT_X_POS, value); }
        }

        public int EditorYPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_EDT_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_EDT_Y_POS, value); }
        }

        public bool Enabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        public ExecutionMode ExecutionMode
        {
            get { return GetNumberProperty<ExecutionMode>(NdapiConstants.D2FP_EXEC_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_EXEC_MODE, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        public bool FixedLength
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_LEN, value); }
        }

        public string FileName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FLNAM, value); }
        }

        public string FormatMask
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FMT_MSK); }
            set { SetStringProperty(NdapiConstants.D2FP_FMT_MSK, value); }
        }

        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        public string Formula
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORMULA); }
            set { SetStringProperty(NdapiConstants.D2FP_FORMULA, value); }
        }

        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        public string HelpBookTopic
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC, value); }
        }

        public string HighestAllowedValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HIGHEST_ALLOWED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_HIGHEST_ALLOWED_VAL, value); }
        }

        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        public bool Iconic
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ICONIC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ICONIC, value); }
        }

        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        public ImageDepth ImageDepth
        {
            get { return GetNumberProperty<ImageDepth>(NdapiConstants.D2FP_IMG_DPTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_IMG_DPTH, value); }
        }

        public ImageStorageFormat ImageFormat
        {
            get { return GetNumberProperty<ImageStorageFormat>(NdapiConstants.D2FP_IMG_FMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_IMG_FMT, value); }
        }

        public InitialKeyboardDirection InitialKeyboardDirection
        {
            get { return GetNumberProperty<InitialKeyboardDirection>(NdapiConstants.D2FP_INIT_KBRD_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_INIT_KBRD_DIR, value); }
        }

        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_INIT_VAL, value); }
        }

        public bool InsertAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED, value); }
        }

        public int NumberOfItemsDisplayed
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_ITMS_DISP); }
            set { SetNumberProperty(NdapiConstants.D2FP_ITMS_DISP, value); }
        }

        public ItemType ItemType
        {
            get { return GetNumberProperty<ItemType>(NdapiConstants.D2FP_ITM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_ITM_TYP, value); }
        }

        public Justification Justification
        {
            get { return GetNumberProperty<Justification>(NdapiConstants.D2FP_JUSTIFICATION); }
            set { SetNumberProperty(NdapiConstants.D2FP_JUSTIFICATION, value); }
        }

        public bool KeyboardNavigable
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_KBRD_NAVIGABLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_KBRD_NAVIGABLE, value); }
        }

        public bool KeepCursorPosition
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_KEEP_CRSR_POS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_KEEP_CRSR_POS, value); }
        }

        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public bool LockRecord
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_LOCK_REC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_LOCK_REC, value); }
        }

        public LOV LOV
        {
            get { return GetObjectProperty<LOV>(NdapiConstants.D2FP_LOV_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_LOV_OBJ, value); }
        }

        public string LOVName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LOV_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_LOV_NAM, value); }
        }

        public int LOVXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LOV_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_LOV_X_POS, value); }
        }

        public int LOVXYosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LOV_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_LOV_Y_POS, value); }
        }

        public string LowestAllowedValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LOWEST_ALLOWED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_LOWEST_ALLOWED_VAL, value); }
        }

        public int ListElementCount
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_LST_ELEMENT_COUNT); }
        }

        public ListStyle ListStyle
            {
                get   { return GetNumberProperty<ListStyle>(NdapiConstants.D2FP_LST_STY); }
                set   { SetNumberProperty(NdapiConstants.D2FP_LST_STY, value); }
            }

            public  int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        public bool MultiLine
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MLT_LIN); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MLT_LIN, value); }
        }

        public bool MouseNavigate
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_MOUSE_NAVIGATE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_MOUSE_NAVIGATE, value); }
        }

        public NdapiObject NextNavigationItem
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_NXT_NAVIGATION_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_NXT_NAVIGATION_ITM_OBJ, value); }
        }

        public int OLEActivationStyle
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_OLE_ACT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_ACT_STY, value); }
        }

        public string OLEClass
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OLE_CLASS); }
            set { SetStringProperty(NdapiConstants.D2FP_OLE_CLASS, value); }
        }

        public bool OLEInsideOutSupport
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_INSD_OUT_SUPPORT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_INSD_OUT_SUPPORT, value); }
        }

        public bool OLEInPlaceActivation
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_IN_PLACE_ACT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_IN_PLACE_ACT, value); }
        }

        public int OLEPopUpMenuItems
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_OLE_POPUP_MNU_ITMS); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_POPUP_MNU_ITMS, value); }
        }

        public OleResizeStyle OLEResizeStyle
        {
            get { return GetNumberProperty<OleResizeStyle>(NdapiConstants.D2FP_OLE_RESIZ_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_RESIZ_STY, value); }
        }

        public bool ShowOLETenantType
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_OLE_SHOW_TNNT_TYP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_OLE_SHOW_TNNT_TYP, value); }
        }

        public OleTenantAspect OLETenantAspect
        {
            get { return GetNumberProperty<OleTenantAspect>(NdapiConstants.D2FP_OLE_TNNT_ASPCT); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_TNNT_ASPCT, value); }
        }

        public OleTenantTypes OLETenantTypes
        {
            get { return GetNumberProperty<OleTenantTypes>(NdapiConstants.D2FP_OLE_TNNT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_OLE_TNNT_TYP, value); }
        }

        public string MappingOfOtherValues
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OTHER_VALS); }
            set { SetStringProperty(NdapiConstants.D2FP_OTHER_VALS, value); }
        }

        public string PopupMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM, value); }
        }

        public string PopUpMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_POPUP_MNU_OBJ); }
            set { SetStringProperty(NdapiConstants.D2FP_POPUP_MNU_OBJ, value); }
        }

        public NdapiObject PopUpVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_POPUP_VA_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_POPUP_VA_OBJ, value); }
        }

        public NdapiObject PreviousNavigationItem
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_PREV_NAVIGATION_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_PREV_NAVIGATION_ITM_OBJ, value); }
        }

        public string Prompt
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT, value); }
        }

        public Alignment PromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN, value); }
        }

        public int PromptAlignmentOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ALIGN_OFST, value); }
        }

        public EdgeAtachmentType PromptAttachmentEdge
        {
            get { return GetNumberProperty<EdgeAtachmentType>(NdapiConstants.D2FP_PRMPT_ATT_EDGE); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_EDGE, value); }
        }

        public int PromptAttachementOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_ATT_OFST, value); }
        }

        public string PromptBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR, value); }
        }

        public PromptDisplayStyle PromptDisplayStyle
        {
            get { return GetNumberProperty<PromptDisplayStyle>(NdapiConstants.D2FP_PRMPT_DISP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_DISP_STY, value); }
        }

        public string PromptFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT, value); }
        }

        public string PromptFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM, value); }
        }

        public int PromptFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ, value); }
        }

        public FontSpacing PromptFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_PRMPT_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SPCING, value); }
        }

        public FontStyle PromptFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_PRMPT_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_STY, value); }
        }

        public FontWeight PromptFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_PRMPT_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_WGHT, value); }
        }

        public string PromptForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR, value); }
        }

        public Justification PromptJustification
        {
            get { return GetNumberProperty<Justification>(NdapiConstants.D2FP_PRMPT_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_JST, value); }
        }

        public ReadingOrder PromptReadingOrder
        {
            get { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_PRMPT_READING_ORDR); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_READING_ORDR, value); }
        }

        public string PromptVisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_VAT_NAM, value); }
        }

        public NdapiObject PromptVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_PRMPT_VAT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_PRMPT_VAT_OBJ, value); }
        }

        public bool PrimaryKey
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_PRMRY_KEY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_PRMRY_KEY, value); }
        }

        public bool QueryAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED, value); }
        }

        public int QueryLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_QRY_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_QRY_LEN, value); }
        }

        public bool QueryOnly
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ONLY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ONLY, value); }
        }

        public NdapiObject RadioButtons
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_RAD_BUT); }
        }

        public ReadingOrder ReadingOrder
            {
                get     { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_READING_ORDR); }
                set   { SetNumberProperty(NdapiConstants.D2FP_READING_ORDR, value); }
            }

            public  string CurrentRecordVisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM, value); }
        }

        public NdapiObject CurrentRecordVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_REC_VAT_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_VAT_GRP_OBJ, value); }
        }

        public bool Rendered
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RENDERED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RENDERED, value); }
        }

        public bool Required
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_REQUIRED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_REQUIRED, value); }
        }

        public bool ShowFastForwardButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_FAST_FWD); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_FAST_FWD, value); }
        }

        public bool ShowHorizonatalScrollbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR, value); }
        }

        public bool ShowPalette
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_PALETTE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_PALETTE, value); }
        }

        public bool ShowPlayButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_PLAY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_PLAY, value); }
        }

        public bool ShowRecordButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_REC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_REC, value); }
        }

        public bool ShowRewindButton
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_REWIND); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_REWIND, value); }
        }

        public bool ShowSlider
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_SLIDER); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_SLIDER, value); }
        }

        public bool ShowTimeIndicator
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_TIME); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_TIME, value); }
        }

        public bool ShowVerticalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR, value); }
        }

        public bool ShowVolumeControl
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VOLUME); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VOLUME, value); }
        }

        public ImageSizingStyle SizingStyle
        {
            get { return GetNumberProperty<ImageSizingStyle>(NdapiConstants.D2FP_SIZING_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_SIZING_STY, value); }
        }

        public SoundFormat SoundFormat
        {
            get { return GetNumberProperty<SoundFormat>(NdapiConstants.D2FP_SND_FMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_SND_FMT, value); }
        }

        public SoundQuality SoundQuality
        {
            get { return GetNumberProperty<SoundQuality>(NdapiConstants.D2FP_SND_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_SND_QLTY, value); }
        }

        public string SummarizedBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUMM_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SUMM_BLK_NAM, value); }
        }

        public SummaryFunction SummarizedFunction
        {
            get { return GetNumberProperty<SummaryFunction>(NdapiConstants.D2FP_SUMM_FUNC); }
            set { SetNumberProperty(NdapiConstants.D2FP_SUMM_FUNC, value); }
        }

        public string SummarizedItem
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUMM_ITM_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SUMM_ITM_NAM, value); }
        }

        public NdapiObject SynchronizeWithItem
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_SYNC_ITM_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_SYNC_ITM_OBJ, value); }
        }

        public NdapiObject TabPage
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_TBP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_TBP_OBJ, value); }
        }

        public string Tooltip
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TOOLTIP); }
            set { SetStringProperty(NdapiConstants.D2FP_TOOLTIP, value); }
        }

        public string TooltipVisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TOOLTIP_VAT_GRP); }
            set { SetStringProperty(NdapiConstants.D2FP_TOOLTIP_VAT_GRP, value); }
        }

        public string ValueWhenUnchecked
        {
            get { return GetStringProperty(NdapiConstants.D2FP_UNCHKED_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_UNCHKED_VAL, value); }
        }

        public bool UpdateAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED, value); }
        }

        public bool UpdateCommit
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_COMMIT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_COMMIT, value); }
        }

        public bool UpdateOnlyIfNull
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_IF_NULL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_IF_NULL, value); }
        }

        public bool UpdateQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_QRY, value); }
        }

        public bool ValidateFromList
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VALIDATE_FROM_LST); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VALIDATE_FROM_LST, value); }
        }

        public string VisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public NdapiObject VisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_VAT_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_VAT_OBJ, value); }
        }

        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        public WrapStyle WrapStyle
        {
            get { return GetNumberProperty<WrapStyle>(NdapiConstants.D2FP_WRAP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_WRAP_STY, value); }
        }

        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }

        public IEnumerable<Trigger> Triggers
        {
            get { return GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER); }
        }
    }
}
