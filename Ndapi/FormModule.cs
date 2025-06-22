using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a form module.
/// </summary>
public partial class FormModule : NdapiModule
{
    /// <summary>
    /// Creates a form module.
    /// </summary>
    /// <param name="name">Form module name.</param>
    public FormModule(string name) : base(name, ObjectType.FormModule)
    {
    }

    internal FormModule(ObjectSafeHandle handle) : base(handle, ObjectType.FormModule)
    {
    }

    /// <summary>
    /// Gets or sets the application name of which this module is associated. 
    /// </summary>
    [Property(NdapiConstant.D2FP_APPNAME)]
    public partial string ApplicationName { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the name of the default window.
    /// </summary>
    [Property(NdapiConstant.D2FP_CONSOLE_WIN)]
    public partial string ConsoleWindow { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should defer enforcement of the Required item attribute until the record is validated.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEFER_REQ_ENF)]
    public partial bool DeferRequiredEnforcement { get; set; }

    /// <summary>
    /// Gets or sets the first navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRST_NAVIGATION_BLK_OBJ)]
    public partial Block FirstNavigationBlock { get; set; }

    /// <summary>
    /// Gets or sets the help book title.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TITLE)]
    public partial string HelpBookTitle { get; set; }

    /// <summary>
    /// Gets or sets the canvas name of the horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_TLBR_CNV)]
    public partial string HorizontalToolbarCanvas { get; set; }

    /// <summary>
    /// Gets or sets the name of the menu in the menu module that runtime should use as the main, or top-level, menu for this invocation.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_MNU)]
    public partial string InitialMenu { get; set; }

    /// <summary>
    /// Gets or sets the intenteraction mode. Interaction mode dictates how a user can interact with a form during a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERACTION_MODE)]
    public partial InteractionMode InteractionMode { get; set; }

    /// <summary>
    /// Gets or sets whether or not transactions in a session will be serializable.
    /// </summary>
    [Property(NdapiConstant.D2FP_ISOLATION_MODE)]
    public partial IsolationMode IsolationMode { get; set; }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public partial LanguageDirection LanguageDirection { get; set; }

    /// <summary>
    /// Gets or sets the timeout to abort a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_QRY_TIME)]
    public partial int MaximumQueryTime { get; set; }

    /// <summary>
    /// Gets or sets the number of records fetched before the query is aborted.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_RECS_FETCHED)]
    public partial int MaxRecordsFetched { get; set; }

    /// <summary>
    /// Gets or sets the name of the menu module associated.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_MOD)]
    public partial string MenuModule { get; set; }

    /// <summary>
    /// Gets or sets the menu role.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ROLE)]
    public partial string MenuRole { get; set; }

    /// <summary>
    /// Gets or sets the menu source.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_SRC)]
    public partial MenuSource MenuSource { get; set; }

    /// <summary>
    /// Gets or sets the menu style.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_STY)]
    public partial MenuStyle MenuStyle { get; set; }

    /// <summary>
    /// Gets or sets the mouse navigation limit.
    /// </summary>
    [Property(NdapiConstant.D2FP_MOUSE_NAVIGATION_LMT)]
    public partial MouseNavigationLimit MouseNavigationLimit { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public partial VisualAttribute CurrentRecordVisualAttribute { get; set; }

    /// <summary>
    /// Gets or sets the runtime compatibility.
    /// </summary>
    [Property(NdapiConstant.D2FP_RUNTIME_COMP)]
    public partial RuntimeCompatibility RuntimeCompatibility { get; set; }

    /// <summary>
    /// Gets or sets the form title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public partial string Title { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display 3D controls.
    /// </summary>
    [Property(NdapiConstant.D2FP_USE_3D_CNTRLS)]
    public partial bool Use3DControls { get; set; }

    /// <summary>
    /// Gets or sets the maximum amount of data that an operator can enter in the form before runtime initiates validation.
    /// </summary>
    [Property(NdapiConstant.D2FP_VALIDATION_UNIT)]
    public partial ValidationUnit ValidationUnit { get; set; }

    /// <summary>
    /// Gets or sets the canvas name of the vertical toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_TLBR_CNV)]
    public partial string VerticalToolbarCanvas { get; set; }

    /// <summary>
    /// Gets all the alerts.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALERT)]
    public partial NdapiObjectList<Alert> Alerts { get; }

    /// <summary>
    /// Gets all the attached libraries.
    /// </summary>
    [Property(NdapiConstant.D2FP_ATT_LIB)]
    public partial NdapiObjectList<AttachedLibrary> AttachedLibraries { get; }

    /// <summary>
    /// Gets all the canvases.
    /// </summary>
    [Property(NdapiConstant.D2FP_CANVAS)]
    public partial NdapiObjectList<Canvas> Canvases { get; }

    /// <summary>
    /// Gets all the blocks.
    /// </summary>
    [Property(NdapiConstant.D2FP_BLOCK)]
    public partial NdapiObjectList<Block> Blocks { get; }

    /// <summary>
    /// Gets all the editors.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDITOR)]
    public partial NdapiObjectList<Editor> Editors { get; }

    /// <summary>
    /// Gets all the events.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT)]
    public partial NdapiObjectList<Event> Events { get; }

    /// <summary>
    /// Gets all the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV)]
    public partial NdapiObjectList<Lov> Lovs { get; }

    /// <summary>
    /// Gets all the menus.
    /// </summary>
    [Property(NdapiConstant.D2FP_MENU)]
    public partial NdapiObjectList<Menu> Menus { get; }

    /// <summary>
    /// Gets all the object groups.
    /// </summary>
    [Property(NdapiConstant.D2FP_OBJ_GRP)]
    public partial NdapiObjectList<ObjectGroup> ObjectGroups { get; }

    /// <summary>
    /// Gets all the form parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORM_PARAM)]
    public partial NdapiObjectList<FormParameter> Parameters { get; }

    /// <summary>
    /// Gets all the program units.
    /// </summary>
    [Property(NdapiConstant.D2FP_PROG_UNIT)]
    public partial NdapiObjectList<ProgramUnit> ProgramUnits { get; }

    /// <summary>
    /// Gets all the property classes.
    /// </summary>
    [Property(NdapiConstant.D2FP_PROP_CLASS)]
    public partial NdapiObjectList<PropertyClass> PropertyClasses { get; }

    /// <summary>
    /// Gets all the record groups.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP)]
    public partial NdapiObjectList<RecordGroup> RecordGroups { get; }

    /// <summary>
    /// Gets all the reports.
    /// </summary>
    [Property(NdapiConstant.D2FP_REPORT)]
    public partial NdapiObjectList<Report> Reports { get; }

    /// <summary>
    /// Gets all the form-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public partial NdapiObjectList<Trigger> Triggers { get; }

    /// <summary>
    /// Gets all the visual attributes.
    /// </summary>
    [Property(NdapiConstant.D2FP_VIS_ATTR)]
    public partial NdapiObjectList<VisualAttribute> VisualAttributes { get; }

    /// <summary>
    /// Gets all the windows.
    /// </summary>
    [Property(NdapiConstant.D2FP_WINDOW)]
    public partial NdapiObjectList<Window> Windows { get; }

    /// <summary>
    /// Load the form module into memory.
    /// </summary>
    /// <param name="filename">Form module location (.fmb file)</param>
    /// <returns>Loaded form module reference.</returns>
    public new static FormModule Open(string filename)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2ffmdld_Load(NdapiContext.GetContext(), out var form, filename, false)
            : NativeMethods.d2ffmdld_Load(NdapiContext.GetContext(), out form, filename);

        Ensure.Success(status);

        return new FormModule(form);
    }

    /// <summary>
    /// Save the form module to disk.
    /// </summary>
    public override void Save()
    {
        Save(null, false);
    }

    /// <summary>
    /// Save the form module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    public override void Save(string path)
    {
        Save(path, false);
    }

    /// <summary>
    /// Save the form module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    /// <param name="saveInDatabase">Should save module in database.</param>
    public override void Save(string path, bool saveInDatabase)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2ffmdsv_Save(NdapiContext.GetContext(), Handle, path, saveInDatabase)
            : NativeMethods.d2ffmdsv_Save(NdapiContext.GetContext(), Handle, path);

        Ensure.Success(status);
    }

    /// <summary>
    /// Compile the form module creating an .fmx.
    /// </summary>
    public override void CompileFile()
    {
        var status = NativeMethods.d2ffmdcf_CompileFile(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Compile PL/SQL code in the form module.
    /// </summary>
    public override void CompileObjects()
    {
        var status = NativeMethods.d2ffmdco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the version of the last Form Builder that loaded the module.
    /// </summary>
    /// <param name="file">Form module location (.fmb file)</param>
    /// <param name="loadFromDb">Module should be loaded from database.</param>
    /// <returns>The Form Builder version</returns>
    public static int GetFileVersion(string file, bool loadFromDb = false)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2ffmdfv_FileVersion(NdapiContext.GetContext(), file, loadFromDb, out var version)
            : NativeMethods.d2ffmdfv_FileVersion(NdapiContext.GetContext(), file, out version);

        Ensure.Success(status);
        return version;
    }

    /// <summary>
    /// Attaches a new library to the current module.
    /// </summary>
    /// <param name="location">Library location.</param>
    /// <returns>Instance of the attached library.</returns>
    public AttachedLibrary AttachLibrary(string location) => new(this, location);

    /// <summary>
    /// Creates an alert.
    /// </summary>
    /// <param name="name">Name of the alert.</param>
    /// <returns>The child object.</returns>
    public Alert CreateAlert(string name) => new(this, name);

    /// <summary>
    /// Creates a canvas.
    /// </summary>
    /// <param name="name">Name of the canvas.</param>
    /// <returns>The child object.</returns>
    public Canvas CreateCanvas(string name) => new(this, name);

    /// <summary>
    /// Creates a block.
    /// </summary>
    /// <param name="name">Name of the block.</param>
    /// <returns>The child object.</returns>
    public Block CreateBlock(string name) => new(this, name);

    /// <summary>
    /// Creates an editor.
    /// </summary>
    /// <param name="name">Name of the editor.</param>
    /// <returns>The child object.</returns>
    public Editor CreateEditor(string name) => new(this, name);

    /// <summary>
    /// Creates a LOV.
    /// </summary>
    /// <param name="name">Name of the LOV.</param>
    /// <returns>The child object.</returns>
    public Lov CreateLov(string name) => new(this, name);

    /// <summary>
    /// Creates a menu.
    /// </summary>
    /// <param name="name">Name of the menu.</param>
    /// <returns>The child object.</returns>
    public Menu CreateMenu(string name) => new(this, name);

    /// <summary>
    /// Creates an object group.
    /// </summary>
    /// <param name="name">Name of the object group.</param>
    /// <returns>The child object.</returns>
    public ObjectGroup CreateObjectGroup(string name) => new(this, name);

    /// <summary>
    /// Creates a form parameter.
    /// </summary>
    /// <param name="name">Name of the form parameter.</param>
    /// <returns>The child object.</returns>
    public FormParameter CreateFormParameter(string name) => new(this, name);

    /// <summary>
    /// Creates a program unit.
    /// </summary>
    /// <param name="name">Name of the program unit.</param>
    /// <returns>The child object.</returns>
    public ProgramUnit CreateProgramUnit(string name) => new(this, name);

    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="name">Name of the property class.</param>
    /// <returns>The child object.</returns>
    public PropertyClass CreatePropertyClass(string name) => new(this, name);

    /// <summary>
    /// Creates a record group.
    /// </summary>
    /// <param name="name">Name of the record group.</param>
    /// <returns>The child object.</returns>
    public RecordGroup CreateRecordGroup(string name) => new(this, name);

    /// <summary>
    /// Creates a report.
    /// </summary>
    /// <param name="name">Name of the report.</param>
    /// <returns>The child object.</returns>
    public Report CreateReport(string name) => new(this, name);

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="name">Name of the trigger.</param>
    /// <returns>The child object.</returns>
    public Trigger CreateTrigger(string name) => new(this, name);

    /// <summary>
    /// Creates a visual attribute.
    /// </summary>
    /// <param name="name">Name of the visual attribute.</param>
    /// <returns>The child object.</returns>
    public VisualAttribute CreateVisualAttribute(string name) => new(this, name);

    /// <summary>
    /// Creates a window.
    /// </summary>
    /// <param name="name">Name of the window.</param>
    /// <returns>The child object.</returns>
    public Window CreateWindow(string name) => new(this, name);

    /// <summary>
    /// Creates an event.
    /// </summary>
    /// <param name="name">Name of the event.</param>
    /// <returns>The child object.</returns>
    public Event CreateEvent(string name) => new(this, name);
}
