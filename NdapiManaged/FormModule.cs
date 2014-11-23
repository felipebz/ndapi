using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System.Collections.Generic;

namespace NdapiManaged
{
    public class FormModule : NdapiObject
    {
        public FormModule(string name)
        {
            Create(name, NdapiConstants.D2FFO_FORM_MODULE);
        }

        internal FormModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        string ConsoleWindow
        {
            get { return GetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN); }
            set { SetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN, value); }
        }

        bool DeferRequiredEnforcement
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF, value); }
        }

        NdapiObject FirstNavigationBlock
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ, value); }
        }

        string HelpBookTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE, value); }
        }

        string HorizontalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV, value); }
        }

        string InitialMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INIT_MNU); }
            set { SetStringProperty(NdapiConstants.D2FP_INIT_MNU, value); }
        }

        InteractionMode InteractionMode
        {
            get { return GetNumberProperty<InteractionMode>(NdapiConstants.D2FP_INTERACTION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_INTERACTION_MODE, value); }
        }

        IsolationMode IsolationMode
        {
            get { return GetNumberProperty<IsolationMode>(NdapiConstants.D2FP_ISOLATION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_ISOLATION_MODE, value); }
        }

        LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        int MaximumQueryTime
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME, value); }
        }

        int MaxRecordsFetched
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED, value); }
        }

        string MenuModule
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_MOD); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_MOD, value); }
        }

        string MenuRole
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ROLE); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ROLE, value); }
        }

        MenuSource MenuSource
        {
            get { return GetNumberProperty<MenuSource>(NdapiConstants.D2FP_MNU_SRC); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_SRC, value); }
        }

        MenuStyle MenuStyle
        {
            get { return GetNumberProperty<MenuStyle>(NdapiConstants.D2FP_MNU_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_STY, value); }
        }

        MouseNavigationLimit MouseNavigationLimit
        {
            get { return GetNumberProperty<MouseNavigationLimit>(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT, value); }
        }

        NdapiObject CurrentRecordVisualAttribute
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_REC_VAT_GRP_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_REC_VAT_GRP_OBJ, value); }
        }

        RuntimeCompatibility RuntimeCompatibility
        {
            get { return GetNumberProperty<RuntimeCompatibility>(NdapiConstants.D2FP_RUNTIME_COMP); }
            set { SetNumberProperty(NdapiConstants.D2FP_RUNTIME_COMP, value); }
        }

        string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        bool Use3DControls
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS, value); }
        }

        ValidationUnit ValidationUnit
        {
            get { return GetNumberProperty<ValidationUnit>(NdapiConstants.D2FP_VALIDATION_UNIT); }
            set { SetNumberProperty(NdapiConstants.D2FP_VALIDATION_UNIT, value); }
        }

        string VerticalToolbarCanvas
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

        public IEnumerable<Block> Blocks
        {
            get { return GetObjectList<Block>(NdapiConstants.D2FP_BLOCK); }
        }

        public IEnumerable<ProgramUnit> ProgramUnits
        {
            get { return GetObjectList<ProgramUnit>(NdapiConstants.D2FP_PROG_UNIT); }
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