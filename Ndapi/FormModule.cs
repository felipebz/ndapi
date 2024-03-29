﻿using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

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

    internal FormModule(ObjectSafeHandle handle) : base(handle, ObjectType.FormModule)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the name of the default window.
    /// </summary>
    [Property(NdapiConstant.D2FP_CONSOLE_WIN)]
    public string ConsoleWindow
    {
        get => GetStringProperty(NdapiConstant.D2FP_CONSOLE_WIN);
        set => SetStringProperty(NdapiConstant.D2FP_CONSOLE_WIN, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should defer enforcement of the Required item attribute until the record is validated.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEFER_REQ_ENF)]
    public bool DeferRequiredEnforcement
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DEFER_REQ_ENF);
        set => SetBooleanProperty(NdapiConstant.D2FP_DEFER_REQ_ENF, value);
    }

    /// <summary>
    /// Gets or sets the first navigation block.
    /// </summary>
    [Property(NdapiConstant.D2FP_FRST_NAVIGATION_BLK_OBJ)]
    public Block FirstNavigationBlock
    {
        get => GetObjectProperty<Block>(NdapiConstant.D2FP_FRST_NAVIGATION_BLK_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_FRST_NAVIGATION_BLK_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the help book title.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TITLE)]
    public string HelpBookTitle
    {
        get => GetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TITLE);
        set => SetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TITLE, value);
    }

    /// <summary>
    /// Gets or sets the canvas name of the horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_HORZ_TLBR_CNV)]
    public string HorizontalToolbarCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_HORZ_TLBR_CNV);
        set => SetStringProperty(NdapiConstant.D2FP_HORZ_TLBR_CNV, value);
    }

    /// <summary>
    /// Gets or sets the name of the menu in the menu module that runtime should use as the main, or top-level, menu for this invocation.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_MNU)]
    public string InitialMenu
    {
        get => GetStringProperty(NdapiConstant.D2FP_INIT_MNU);
        set => SetStringProperty(NdapiConstant.D2FP_INIT_MNU, value);
    }

    /// <summary>
    /// Gets or sets the intenteraction mode. Interaction mode dictates how a user can interact with a form during a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_INTERACTION_MODE)]
    public InteractionMode InteractionMode
    {
        get => GetNumberProperty<InteractionMode>(NdapiConstant.D2FP_INTERACTION_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_INTERACTION_MODE, value);
    }

    /// <summary>
    /// Gets or sets whether or not transactions in a session will be serializable.
    /// </summary>
    [Property(NdapiConstant.D2FP_ISOLATION_MODE)]
    public IsolationMode IsolationMode
    {
        get => GetNumberProperty<IsolationMode>(NdapiConstant.D2FP_ISOLATION_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_ISOLATION_MODE, value);
    }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstant.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_LANG_DIR, value);
    }

    /// <summary>
    /// Gets or sets the timeout to abort a query.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_QRY_TIME)]
    public int MaximumQueryTime
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_QRY_TIME);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_QRY_TIME, value);
    }

    /// <summary>
    /// Gets or sets the number of records fetched before the query is aborted.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_RECS_FETCHED)]
    public int MaxRecordsFetched
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_RECS_FETCHED);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_RECS_FETCHED, value);
    }

    /// <summary>
    /// Gets or sets the name of the menu module associated.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_MOD)]
    public string MenuModule
    {
        get => GetStringProperty(NdapiConstant.D2FP_MNU_MOD);
        set => SetStringProperty(NdapiConstant.D2FP_MNU_MOD, value);
    }

    /// <summary>
    /// Gets or sets the menu role.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ROLE)]
    public string MenuRole
    {
        get => GetStringProperty(NdapiConstant.D2FP_MNU_ROLE);
        set => SetStringProperty(NdapiConstant.D2FP_MNU_ROLE, value);
    }

    /// <summary>
    /// Gets or sets the menu source.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_SRC)]
    public MenuSource MenuSource
    {
        get => GetNumberProperty<MenuSource>(NdapiConstant.D2FP_MNU_SRC);
        set => SetNumberProperty(NdapiConstant.D2FP_MNU_SRC, value);
    }

    /// <summary>
    /// Gets or sets the menu style.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_STY)]
    public MenuStyle MenuStyle
    {
        get => GetNumberProperty<MenuStyle>(NdapiConstant.D2FP_MNU_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_MNU_STY, value);
    }

    /// <summary>
    /// Gets or sets the mouse navigation limit.
    /// </summary>
    [Property(NdapiConstant.D2FP_MOUSE_NAVIGATION_LMT)]
    public MouseNavigationLimit MouseNavigationLimit
    {
        get => GetNumberProperty<MouseNavigationLimit>(NdapiConstant.D2FP_MOUSE_NAVIGATION_LMT);
        set => SetNumberProperty(NdapiConstant.D2FP_MOUSE_NAVIGATION_LMT, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public VisualAttribute CurrentRecordVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_REC_VAT_GRP_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_REC_VAT_GRP_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the runtime compatibility.
    /// </summary>
    [Property(NdapiConstant.D2FP_RUNTIME_COMP)]
    public RuntimeCompatibility RuntimeCompatibility
    {
        get => GetNumberProperty<RuntimeCompatibility>(NdapiConstant.D2FP_RUNTIME_COMP);
        set => SetNumberProperty(NdapiConstant.D2FP_RUNTIME_COMP, value);
    }

    /// <summary>
    /// Gets or sets the form title.
    /// </summary>
    [Property(NdapiConstant.D2FP_TITLE)]
    public string Title
    {
        get => GetStringProperty(NdapiConstant.D2FP_TITLE);
        set => SetStringProperty(NdapiConstant.D2FP_TITLE, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display 3D controls.
    /// </summary>
    [Property(NdapiConstant.D2FP_USE_3D_CNTRLS)]
    public bool Use3DControls
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_USE_3D_CNTRLS);
        set => SetBooleanProperty(NdapiConstant.D2FP_USE_3D_CNTRLS, value);
    }

    /// <summary>
    /// Gets or sets the maximum amount of data that an operator can enter in the form before runtime initiates validation.
    /// </summary>
    [Property(NdapiConstant.D2FP_VALIDATION_UNIT)]
    public ValidationUnit ValidationUnit
    {
        get => GetNumberProperty<ValidationUnit>(NdapiConstant.D2FP_VALIDATION_UNIT);
        set => SetNumberProperty(NdapiConstant.D2FP_VALIDATION_UNIT, value);
    }

    /// <summary>
    /// Gets or sets the canvas name of the vertical toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VERT_TLBR_CNV)]
    public string VerticalToolbarCanvas
    {
        get => GetStringProperty(NdapiConstant.D2FP_VERT_TLBR_CNV);
        set => SetStringProperty(NdapiConstant.D2FP_VERT_TLBR_CNV, value);
    }

    /// <summary>
    /// Gets all the alerts.
    /// </summary>
    [Property(NdapiConstant.D2FP_ALERT)]
    public NdapiObjectList<Alert> Alerts =>
        GetObjectList<Alert>(NdapiConstant.D2FP_ALERT);

    /// <summary>
    /// Gets all the attached libraries.
    /// </summary>
    [Property(NdapiConstant.D2FP_ATT_LIB)]
    public NdapiObjectList<AttachedLibrary> AttachedLibraries =>
        GetObjectList<AttachedLibrary>(NdapiConstant.D2FP_ATT_LIB);

    /// <summary>
    /// Gets all the canvases.
    /// </summary>
    [Property(NdapiConstant.D2FP_CANVAS)]
    public NdapiObjectList<Canvas> Canvases =>
        GetObjectList<Canvas>(NdapiConstant.D2FP_CANVAS);

    /// <summary>
    /// Gets all the blocks.
    /// </summary>
    [Property(NdapiConstant.D2FP_BLOCK)]
    public NdapiObjectList<Block> Blocks =>
        GetObjectList<Block>(NdapiConstant.D2FP_BLOCK);

    /// <summary>
    /// Gets all the editors.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDITOR)]
    public NdapiObjectList<Editor> Editors =>
        GetObjectList<Editor>(NdapiConstant.D2FP_EDITOR);

    /// <summary>
    /// Gets all the events.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT)]
    public NdapiObjectList<Event> Events =>
        GetObjectList<Event>(NdapiConstant.D2FP_EVENT);

    /// <summary>
    /// Gets all the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV)]
    public NdapiObjectList<Lov> Lovs =>
        GetObjectList<Lov>(NdapiConstant.D2FP_LOV);

    /// <summary>
    /// Gets all the menus.
    /// </summary>
    [Property(NdapiConstant.D2FP_MENU)]
    public NdapiObjectList<Menu> Menus =>
        GetObjectList<Menu>(NdapiConstant.D2FP_MENU);

    /// <summary>
    /// Gets all the object groups.
    /// </summary>
    [Property(NdapiConstant.D2FP_OBJ_GRP)]
    public NdapiObjectList<ObjectGroup> ObjectGroups =>
        GetObjectList<ObjectGroup>(NdapiConstant.D2FP_OBJ_GRP);

    /// <summary>
    /// Gets all the form parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORM_PARAM)]
    public NdapiObjectList<FormParameter> Parameters =>
        GetObjectList<FormParameter>(NdapiConstant.D2FP_FORM_PARAM);

    /// <summary>
    /// Gets all the program units.
    /// </summary>
    [Property(NdapiConstant.D2FP_PROG_UNIT)]
    public NdapiObjectList<ProgramUnit> ProgramUnits =>
        GetObjectList<ProgramUnit>(NdapiConstant.D2FP_PROG_UNIT);

    /// <summary>
    /// Gets all the property classes.
    /// </summary>
    [Property(NdapiConstant.D2FP_PROP_CLASS)]
    public NdapiObjectList<PropertyClass> PropertyClasses =>
        GetObjectList<PropertyClass>(NdapiConstant.D2FP_PROP_CLASS);

    /// <summary>
    /// Gets all the record groups.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP)]
    public NdapiObjectList<RecordGroup> RecordGroups =>
        GetObjectList<RecordGroup>(NdapiConstant.D2FP_REC_GRP);

    /// <summary>
    /// Gets all the reports.
    /// </summary>
    [Property(NdapiConstant.D2FP_REPORT)]
    public NdapiObjectList<Report> Reports =>
        GetObjectList<Report>(NdapiConstant.D2FP_REPORT);

    /// <summary>
    /// Gets all the form-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public NdapiObjectList<Trigger> Triggers =>
        GetObjectList<Trigger>(NdapiConstant.D2FP_TRIGGER);

    /// <summary>
    /// Gets all the visual attributes.
    /// </summary>
    [Property(NdapiConstant.D2FP_VIS_ATTR)]
    public NdapiObjectList<VisualAttribute> VisualAttributes =>
        GetObjectList<VisualAttribute>(NdapiConstant.D2FP_VIS_ATTR);

    /// <summary>
    /// Gets all the windows.
    /// </summary>
    [Property(NdapiConstant.D2FP_WINDOW)]
    public NdapiObjectList<Window> Windows =>
        GetObjectList<Window>(NdapiConstant.D2FP_WINDOW);

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
