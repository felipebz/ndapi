using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged
{
    public class Block : NdapiObject
    {
        public Block()
        {
        }

        public Block(string name)
        {
            Create(name, NdapiConstants.D2FFO_BLOCK);
        }

        internal Block(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        public string Description
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BLK_DESCRIPTION); }
            set { SetStringProperty(NdapiConstants.D2FP_BLK_DESCRIPTION, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public bool DeleteAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEL_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEL_ALLOWED, value); }
        }

        public string DeleteProcedureName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DEL_PROC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DEL_PROC_NAM, value); }
        }

        public int DMLArraySize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DML_ARY_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_DML_ARY_SIZ, value); }
        }

        public string DMLDataTargetName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DML_DAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DML_DAT_NAM, value); }
        }

        public DMLDataTargetType DMLDataTargetType
        {
            get { return GetNumberProperty<DMLDataTargetType>(NdapiConstants.D2FP_DML_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DML_DAT_TYP, value); }
        }

        public bool EnforceColumnSecurity
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENFRC_COL_SECURITY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENFRC_COL_SECURITY, value); }
        }

        public bool EnforcePrimaryKey
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENFRC_PRMRY_KEY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENFRC_PRMRY_KEY, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
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

        public bool InsertAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_INSRT_ALLOWED, value); }
        }

        public string InsertProcedureName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INSRT_PROC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_INSRT_PROC_NAM, value); }
        }

        public KeyMode KeyMode
        {
            get { return GetNumberProperty<KeyMode>(NdapiConstants.D2FP_KEY_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_KEY_MODE, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public LockingMode LockingMode
        {
            get { return GetNumberProperty<LockingMode>(NdapiConstants.D2FP_LOCK_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_LOCK_MODE, value); }
        }

        public string LockProcedureName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LOCK_PROC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_LOCK_PROC_NAM, value); }
        }

        public bool ListedInBlockMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_LST_IN_BLK_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_LST_IN_BLK_MNU, value); }
        }

        public int MaximumQueryTime
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME, value); }
        }

        public int MaxRecordsFetched
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED, value); }
        }

        public NavigationStyle NavigationStyle
        {
            get { return GetNumberProperty<NavigationStyle>(NdapiConstants.D2FP_NAVIGATION_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_NAVIGATION_STY, value); }
        }

        public string NextNavigationBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_NXT_NAVIGATION_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_NXT_NAVIGATION_BLK_NAM, value); }
        }

        public string OptimizerHint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OPT_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_OPT_HINT, value); }
        }

        public string PreviousNavigationBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PREV_NAVIGATION_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PREV_NAVIGATION_BLK_NAM, value); }
        }

        public bool QueryAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ALLOWED, value); }
        }

        public bool QueryAllRecord
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_QRY_ALL_RECS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_QRY_ALL_RECS, value); }
        }

        public string QueryDataSourceName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_QRY_DAT_SRC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_QRY_DAT_SRC_NAM, value); }
        }

        public int QueryDataSourceType
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_QRY_DAT_SRC_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_QRY_DAT_SRC_TYP, value); }
        }

        public int NumberorRecordsBuffered
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_RECS_BUFFERED_COUNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_RECS_BUFFERED_COUNT, value); }
        }

        public int NumberOfRecordsDisplayed
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT, value); }
        }

        public int RecordsToFetch
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_RECS_FETCHED_COUNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_RECS_FETCHED_COUNT, value); }
        }

        public RecordOrientation RecordOrientation
        {
            get { return GetNumberProperty<RecordOrientation>(NdapiConstants.D2FP_REC_ORNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_REC_ORNT, value); }
        }

        public string CurrentRecordVisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_REC_VAT_GRP_NAM, value); }
        }

        public NdapiObject CurrentRecordVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_REC_VAT_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_VAT_GRP_OBJ, value); }
        }

        public bool ReverseDirection
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_REV_DIR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_REV_DIR, value); }
        }

        public string ScrollBarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SCRLBR_CNV_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SCRLBR_CNV_NAM, value); }
        }

        public ScrollBarOrientation ScrollBarOrientation
        {
            get { return GetNumberProperty<ScrollBarOrientation>(NdapiConstants.D2FP_SCRLBR_ORNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_ORNT, value); }
        }

        public string ScrollBarTabPage
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SCRLBR_TBP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_SCRLBR_TBP_NAM, value); }
        }

        public int ScrollBarWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID, value); }
        }

        public int ScrollBarXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_SCRLBR_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_X_POS, value); }
        }

        public int ScrollBarYPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_SCRLBR_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_Y_POS, value); }
        }

        public bool ShowScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR, value); }
        }

        public bool SingleRecord
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SNGL_REC); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SNGL_REC, value); }
        }

        public bool UpdateAllowed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_ALLOWED, value); }
        }

        public bool UpdateChangedColumnsOnly
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_UPDT_CHANGED_COLS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_UPDT_CHANGED_COLS, value); }
        }

        public string UpdateProcedureName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_UPDT_PROC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_UPDT_PROC_NAM, value); }
        }

        public string VisualAttributeGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public string WhereClause
        {
            get { return GetStringProperty(NdapiConstants.D2FP_WHERE_CLAUSE); }
            set { SetStringProperty(NdapiConstants.D2FP_WHERE_CLAUSE, value); }
        }

        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        public IEnumerable<Item> Items
        {
            get { return GetObjectList<Item>(NdapiConstants.D2FP_ITEM); }
        }

        public IEnumerable<BlockRelation> Relations
        {
            get { return GetObjectList<BlockRelation>(NdapiConstants.D2FP_REL); }
        }
        public IEnumerable<Trigger> Triggers
        {
            get { return GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER); }
        }

    }
}
