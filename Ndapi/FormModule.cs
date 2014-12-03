using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class FormModule : NdapiObject
    {
        public FormModule(string name)
        {
            Create(name, ObjectType.FormModule);
        }

        internal FormModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string ConsoleWindow
        {
            get { return GetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN); }
            set { SetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN, value); }
        }

        public bool DeferRequiredEnforcement
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF, value); }
        }

        public NdapiObject FirstNavigationBlock
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ, value); }
        }

        public string HelpBookTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE, value); }
        }

        public string HorizontalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV, value); }
        }

        public string InitialMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INIT_MNU); }
            set { SetStringProperty(NdapiConstants.D2FP_INIT_MNU, value); }
        }

        public InteractionMode InteractionMode
        {
            get { return GetNumberProperty<InteractionMode>(NdapiConstants.D2FP_INTERACTION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_INTERACTION_MODE, value); }
        }

        public IsolationMode IsolationMode
        {
            get { return GetNumberProperty<IsolationMode>(NdapiConstants.D2FP_ISOLATION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_ISOLATION_MODE, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
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

        public string MenuModule
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_MOD); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_MOD, value); }
        }

        public string MenuRole
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ROLE); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ROLE, value); }
        }

        public MenuSource MenuSource
        {
            get { return GetNumberProperty<MenuSource>(NdapiConstants.D2FP_MNU_SRC); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_SRC, value); }
        }

        public MenuStyle MenuStyle
        {
            get { return GetNumberProperty<MenuStyle>(NdapiConstants.D2FP_MNU_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_STY, value); }
        }

        public MouseNavigationLimit MouseNavigationLimit
        {
            get { return GetNumberProperty<MouseNavigationLimit>(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT, value); }
        }

        public NdapiObject CurrentRecordVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_REC_VAT_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_VAT_GRP_OBJ, value); }
        }

        public RuntimeCompatibility RuntimeCompatibility
        {
            get { return GetNumberProperty<RuntimeCompatibility>(NdapiConstants.D2FP_RUNTIME_COMP); }
            set { SetNumberProperty(NdapiConstants.D2FP_RUNTIME_COMP, value); }
        }

        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        public bool Use3DControls
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS, value); }
        }

        public ValidationUnit ValidationUnit
        {
            get { return GetNumberProperty<ValidationUnit>(NdapiConstants.D2FP_VALIDATION_UNIT); }
            set { SetNumberProperty(NdapiConstants.D2FP_VALIDATION_UNIT, value); }
        }

        public string VerticalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VERT_TLBR_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_VERT_TLBR_CNV, value); }
        }

        public IEnumerable<Alert> Alerts
        {
            get { return GetObjectList<Alert>(NdapiConstants.D2FP_ALERT); }
        }

        public IEnumerable<AttachedLibrary> AttachedLibraries
        {
            get { return GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB); }
        }

        public IEnumerable<Canvas> Canvases
        {
            get { return GetObjectList<Canvas>(NdapiConstants.D2FP_CANVAS); }
        }

        public IEnumerable<Block> Blocks
        {
            get { return GetObjectList<Block>(NdapiConstants.D2FP_BLOCK); }
        }

        public IEnumerable<Editor> Editors
        {
            get { return GetObjectList<Editor>(NdapiConstants.D2FP_EDITOR); }
        }

        public IEnumerable<LOV> LOVs
        {
            get { return GetObjectList<LOV>(NdapiConstants.D2FP_LOV); }
        }

        public IEnumerable<FormParameter> Parameters
        {
            get { return GetObjectList<FormParameter>(NdapiConstants.D2FP_FORM_PARAM); }
        }

        public IEnumerable<ProgramUnit> ProgramUnits
        {
            get { return GetObjectList<ProgramUnit>(NdapiConstants.D2FP_PROG_UNIT); }
        }

        public IEnumerable<RecordGroup> RecordGroups
        {
            get { return GetObjectList<RecordGroup>(NdapiConstants.D2FP_REC_GRP); }
        }

        public IEnumerable<Trigger> Triggers
        {
            get { return GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER); }
        }

        public IEnumerable<Window> Windows
        {
            get { return GetObjectList<Window>(NdapiConstants.D2FP_WINDOW); }
        }

        public static FormModule Open(string filename)
        {
            ObjectSafeHandle form;

            var status = NativeMethods.d2ffmdld_Load(NdapiContext.Context, out form, filename, false);
            Ensure.Success(status);

            return new FormModule(form);
        }

        public void Save(string path = null, bool saveInDatabase = false)
        {
            var status = NativeMethods.d2ffmdsv_Save(NdapiContext.Context, _handle, path, saveInDatabase);
            Ensure.Success(status);
        }

        public void CompileFile()
        {
            var status = NativeMethods.d2ffmdcf_CompileFile(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        public void CompileObjects()
        {
            var status = NativeMethods.d2ffmdco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}