using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class LOV : NdapiObject
    {
        public LOV(FormModule module, string name)
        {
            Create(name, ObjectType.LOV, module);
        }

        internal LOV(ObjectSafeHandle handle) : base(handle)
        {
        }

        public bool AutomaticColumnWidth
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_COL_WID); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_COL_WID, value); }
        }

        public bool AutomaticDisplay
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_DISP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_DISP, value); }
        }

        public bool AutomaticPosition
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_POS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_POS, value); }
        }

        public bool AutomaticRefresh
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_RFRSH); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_RFRSH, value); }
        }

        public bool AutomaticSkip
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP, value); }
        }

        public bool AutomaticSelect
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_SLCT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_SLCT, value); }
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        public bool FilterBeforeDisplay
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FLTR_BEFORE_DISP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FLTR_BEFORE_DISP, value); }
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

        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public ListType ListType
        {
            get { return GetNumberProperty<ListType>(NdapiConstants.D2FP_LST_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_LST_TYP, value); }
        }

        public string OldLOVText
        {
            get { return GetStringProperty(NdapiConstants.D2FP_OLD_LOV_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_OLD_LOV_TXT, value); }
        }

        public RecordGroup RecordGroup
        {
            get { return GetObjectProperty<RecordGroup>(NdapiConstants.D2FP_REC_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_GRP_OBJ, value); }
        }

        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
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

        public IEnumerable<ColumnMapping> ColumnMappingProperties => GetObjectList<ColumnMapping>(NdapiConstants.D2FP_COL_MAP);
    }
}
