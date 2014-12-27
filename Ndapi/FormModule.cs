using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a form module.
    /// </summary>
    public class FormModule : NdapiModule
    {
        /// <summary>
        /// Creates a form module.
        /// </summary>
        /// <param name="name">Form module name.</param>
        public FormModule(string name) : base(name, ObjectType.FormModule)
        {
        }

        internal FormModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the name of the default window.
        /// </summary>
        public string ConsoleWindow
        {
            get { return GetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN); }
            set { SetStringProperty(NdapiConstants.D2FP_CONSOLE_WIN, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should defer enforcement of the Required item attribute until the record is validated.
        /// </summary>
        public bool DeferRequiredEnforcement
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEFER_REQ_ENF, value); }
        }

        /// <summary>
        /// Gets or sets the first navigation block.
        /// </summary>
        public Block FirstNavigationBlock
        {
            get { return GetObjectProperty<Block>(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_FRST_NAVIGATION_BLK_OBJ, value); }
        }
        
        /// <summary>
        /// Gets or sets the help book title.
        /// </summary>
        public string HelpBookTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TITLE, value); }
        }

        /// <summary>
        /// Gets or sets the canvas name of the horizontal toolbar.
        /// </summary>
        public string HorizontalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_HORZ_TLBR_CNV, value); }
        }

        /// <summary>
        /// Gets or sets the name of the menu in the menu module that runtime should use as the main, or top-level, menu for this invocation.
        /// </summary>
        public string InitialMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_INIT_MNU); }
            set { SetStringProperty(NdapiConstants.D2FP_INIT_MNU, value); }
        }

        /// <summary>
        /// Gets or sets the intenteraction mode. Interaction mode dictates how a user can interact with a form during a query.
        /// </summary>
        public InteractionMode InteractionMode
        {
            get { return GetNumberProperty<InteractionMode>(NdapiConstants.D2FP_INTERACTION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_INTERACTION_MODE, value); }
        }

        /// <summary>
        /// Gets or sets whether or not transactions in a session will be serializable.
        /// </summary>
        public IsolationMode IsolationMode
        {
            get { return GetNumberProperty<IsolationMode>(NdapiConstants.D2FP_ISOLATION_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_ISOLATION_MODE, value); }
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
        /// Gets or sets the timeout to abort a query.
        /// </summary>
        public int MaximumQueryTime
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_QRY_TIME, value); }
        }

        /// <summary>
        /// Gets or sets the number of records fetched before the query is aborted.
        /// </summary>
        public int MaxRecordsFetched
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_RECS_FETCHED, value); }
        }

        /// <summary>
        /// Gets or sets the name of the menu module associated.
        /// </summary>
        public string MenuModule
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_MOD); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_MOD, value); }
        }

        /// <summary>
        /// Gets or sets the menu role.
        /// </summary>
        public string MenuRole
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ROLE); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ROLE, value); }
        }

        /// <summary>
        /// Gets or sets the menu source.
        /// </summary>
        public MenuSource MenuSource
        {
            get { return GetNumberProperty<MenuSource>(NdapiConstants.D2FP_MNU_SRC); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_SRC, value); }
        }

        /// <summary>
        /// Gets or sets the menu style.
        /// </summary>
        public MenuStyle MenuStyle
        {
            get { return GetNumberProperty<MenuStyle>(NdapiConstants.D2FP_MNU_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_STY, value); }
        }

        /// <summary>
        /// Gets or sets the mouse navigation limit.
        /// </summary>
        public MouseNavigationLimit MouseNavigationLimit
        {
            get { return GetNumberProperty<MouseNavigationLimit>(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT); }
            set { SetNumberProperty(NdapiConstants.D2FP_MOUSE_NAVIGATION_LMT, value); }
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
        /// Gets or sets the runtime compatibility.
        /// </summary>
        public RuntimeCompatibility RuntimeCompatibility
        {
            get { return GetNumberProperty<RuntimeCompatibility>(NdapiConstants.D2FP_RUNTIME_COMP); }
            set { SetNumberProperty(NdapiConstants.D2FP_RUNTIME_COMP, value); }
        }

        /// <summary>
        /// Gets or sets the form title.
        /// </summary>
        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display 3D controls.
        /// </summary>
        public bool Use3DControls
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_USE_3D_CNTRLS, value); }
        }

        /// <summary>
        /// Gets or sets the maximum amount of data that an operator can enter in the form before runtime initiates validation.
        /// </summary>
        public ValidationUnit ValidationUnit
        {
            get { return GetNumberProperty<ValidationUnit>(NdapiConstants.D2FP_VALIDATION_UNIT); }
            set { SetNumberProperty(NdapiConstants.D2FP_VALIDATION_UNIT, value); }
        }

        /// <summary>
        /// Gets or sets the canvas name of the vertical toolbar.
        /// </summary>
        public string VerticalToolbarCanvas
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VERT_TLBR_CNV); }
            set { SetStringProperty(NdapiConstants.D2FP_VERT_TLBR_CNV, value); }
        }

        /// <summary>
        /// Gets all the alerts.
        /// </summary>
        public IEnumerable<Alert> Alerts => 
            GetObjectList<Alert>(NdapiConstants.D2FP_ALERT);

        /// <summary>
        /// Gets all the attached libraries.
        /// </summary>
        public IEnumerable<AttachedLibrary> AttachedLibraries => 
            GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB);

        /// <summary>
        /// Gets all the canvases.
        /// </summary>
        public IEnumerable<Canvas> Canvases => 
            GetObjectList<Canvas>(NdapiConstants.D2FP_CANVAS);

        /// <summary>
        /// Gets all the blocks.
        /// </summary>
        public IEnumerable<Block> Blocks => 
            GetObjectList<Block>(NdapiConstants.D2FP_BLOCK);

        /// <summary>
        /// Gets all the editors.
        /// </summary>
        public IEnumerable<Editor> Editors => 
            GetObjectList<Editor>(NdapiConstants.D2FP_EDITOR);

        /// <summary>
        /// Gets all the list of values.
        /// </summary>
        public IEnumerable<LOV> LOVs => 
            GetObjectList<LOV>(NdapiConstants.D2FP_LOV);

        /// <summary>
        /// Gets all the menus.
        /// </summary>
        public IEnumerable<Menu> Menus => 
            GetObjectList<Menu>(NdapiConstants.D2FP_MENU);

        /// <summary>
        /// Gets all the object groups.
        /// </summary>
        public IEnumerable<ObjectGroup> ObjectGroups => 
            GetObjectList<ObjectGroup>(NdapiConstants.D2FP_OBJ_GRP);

        /// <summary>
        /// Gets all the form parameters.
        /// </summary>
        public IEnumerable<FormParameter> Parameters => 
            GetObjectList<FormParameter>(NdapiConstants.D2FP_FORM_PARAM);

        /// <summary>
        /// Gets all the program units.
        /// </summary>
        public IEnumerable<ProgramUnit> ProgramUnits => 
            GetObjectList<ProgramUnit>(NdapiConstants.D2FP_PROG_UNIT);

        /// <summary>
        /// Gets all the property classes.
        /// </summary>
        public IEnumerable<PropertyClass> PropertyClasses =>
            GetObjectList<PropertyClass>(NdapiConstants.D2FP_PROP_CLASS);

        /// <summary>
        /// Gets all the record groups.
        /// </summary>
        public IEnumerable<RecordGroup> RecordGroups => 
            GetObjectList<RecordGroup>(NdapiConstants.D2FP_REC_GRP);

        /// <summary>
        /// Gets all the reports.
        /// </summary>
        public IEnumerable<Report> Reports =>
            GetObjectList<Report>(NdapiConstants.D2FP_REPORT);

        /// <summary>
        /// Gets all the form-level triggers.
        /// </summary>
        public IEnumerable<Trigger> Triggers => 
            GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER);

        /// <summary>
        /// Gets all the visual attributes.
        /// </summary>
        public IEnumerable<VisualAttribute> VisualAttributes =>
            GetObjectList<VisualAttribute>(NdapiConstants.D2FP_VIS_ATTR);

        /// <summary>
        /// Gets all the windows.
        /// </summary>
        public IEnumerable<Window> Windows =>
            GetObjectList<Window>(NdapiConstants.D2FP_WINDOW);

        /// <summary>
        /// Load the form module into memory.
        /// </summary>
        /// <param name="filename">Form module location (.fmb file)</param>
        /// <returns>Loaded form module reference.</returns>
        public new static FormModule Open(string filename)
        {
            ObjectSafeHandle form;

            var status = NativeMethods.d2ffmdld_Load(NdapiContext.Context, out form, filename, false);
            Ensure.Success(status);

            return new FormModule(form);
        }

        /// <summary>
        /// Save the form module to disk.
        /// </summary>
        /// <param name="path">Location to save.</param>
        /// <param name="saveInDatabase">Should save module in database.</param>
        public override void Save(string path = null, bool saveInDatabase = false)
        {
            var status = NativeMethods.d2ffmdsv_Save(NdapiContext.Context, _handle, path, saveInDatabase);
            Ensure.Success(status);
        }

        /// <summary>
        /// Compile the form module creating an .fmx.
        /// </summary>
        public override void CompileFile()
        {
            var status = NativeMethods.d2ffmdcf_CompileFile(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Compile PL/SQL code in the form module.
        /// </summary>
        public override void CompileObjects()
        {
            var status = NativeMethods.d2ffmdco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the version of the last Form Builder that loaded the module.
        /// </summary>
        /// <param name="file">Form module location (.fmb file)</param>
        /// <param name="loadFromDb">Module should be loaded from database.</param>
        /// <returns></returns>
        public static int GetFileVersion(string file, bool loadFromDb = false)
        {
            int version;
            var status = NativeMethods.d2ffmdfv_FileVersion(NdapiContext.Context, file, loadFromDb, out version);
            Ensure.Success(status);
            return version;
        }

        /// <summary>
        /// Attaches a new library to the current module.
        /// </summary>
        /// <param name="location">Library location.</param>
        /// <returns>Instance of the attached library.</returns>
        public AttachedLibrary AttachLibrary(string location) => new AttachedLibrary(this, location);
    }
}