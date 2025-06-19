using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu module.
/// </summary>
public partial class MenuModule : NdapiModule
{
    /// <summary>
    /// Creates a menu module.
    /// </summary>
    /// <param name="name">Menu name.</param>
    public MenuModule(string name) : base(name, ObjectType.MenuModule)
    {
    }

    internal MenuModule(ObjectSafeHandle handle) : base(handle, ObjectType.MenuModule)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the main menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAIN_MNU)]
    public partial string MainMenu { get; set; }

    /// <summary>
    /// Gets or sets the module directory.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_DRCTRY)]
    public partial string Directory { get; set; }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_FLNAM)]
    public partial string Filename { get; set; }

    /// <summary>
    /// Gets or sets whether the menu module will share it attached libraries with form modules.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHARE_LIB)]
    public partial bool ShareLibraryWithForm { get; set; }

    /// <summary>
    /// Gets or sets the startup code.
    /// </summary>
    [Property(NdapiConstant.D2FP_STRTUP_CODE)]
    public partial string StartupCode { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should enforce the security scheme defined for the menu module.
    /// </summary>
    [Property(NdapiConstant.D2FP_USE_SECURITY)]
    public partial bool UseSecurity { get; set; }

    /// <summary>
    /// Gets all the attached libraries.
    /// </summary>
    [Property(NdapiConstant.D2FP_ATT_LIB)]
    public partial NdapiObjectList<AttachedLibrary> AttachedLibraries { get; }

    /// <summary>
    /// Gets all the menus.
    /// </summary>
    [Property(NdapiConstant.D2FP_MENU)]
    public partial NdapiObjectList<Menu> Menus { get; }

    /// <summary>
    /// Gets all the menu parameters.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_PARAM)]
    public partial NdapiObjectList<MenuParameter> Parameters { get; }

    /// <summary>
    /// Gets all the object groups.
    /// </summary>
    [Property(NdapiConstant.D2FP_OBJ_GRP)]
    public partial NdapiObjectList<ObjectGroup> ObjectGroups { get; }

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
    /// Gets the total number of roles.
    /// </summary>
    [Property(NdapiConstant.D2FP_ROLE_COUNT)]
    public partial int RoleCount { get; }

    /// <summary>
    /// Gets all the visual attributes.
    /// </summary>
    [Property(NdapiConstant.D2FP_VIS_ATTR)]
    public partial NdapiObjectList<VisualAttribute> VisualAttributes { get; }

    /// <summary>
    /// Gets the menu roles.
    /// </summary>
    public IEnumerable<string> Roles
    {
        get
        {
            for (var i = 1; i <= RoleCount; i++) // objects index is one-based
            {
                yield return GetRoleAt(i);
            }
        }
    }

    /// <summary>
    /// Load the menu module into memory.
    /// </summary>
    /// <param name="filename">Menu module location (.mmb file)</param>
    /// <returns>Loaded menu module reference.</returns>
    public new static MenuModule Open(string filename)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2fmmdld_Load(NdapiContext.GetContext(), out var menu, filename, false)
            : NativeMethods.d2fmmdld_Load(NdapiContext.GetContext(), out menu, filename);

        Ensure.Success(status);

        return new MenuModule(menu);
    }

    /// <summary>
    /// Save the menu module to disk.
    /// </summary>
    public override void Save()
    {
        Save(null, false);
    }

    /// <summary>
    /// Save the menu module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    public override void Save(string path)
    {
        Save(path, false);
    }

    /// <summary>
    /// Save the menu module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    /// <param name="saveInDatabase">Should save module in database.</param>
    public override void Save(string path, bool saveInDatabase)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2fmmdsv_Save(NdapiContext.GetContext(), Handle, path, saveInDatabase)
            : NativeMethods.d2fmmdsv_Save(NdapiContext.GetContext(), Handle, path);

        Ensure.Success(status);
    }

    /// <summary>
    /// Compile the menu module creating an .mmx.
    /// </summary>
    public override void CompileFile()
    {
        var status = NativeMethods.d2fmmdcf_CompileFile(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Compile PL/SQL code in the menu module.
    /// </summary>
    public override void CompileObjects()
    {
        var status = NativeMethods.d2fmmdco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the version of the last Form Builder that loaded the module.
    /// </summary>
    /// <param name="file">Menu module location (.mmb file)</param>
    /// <param name="loadFromDb">Module should be loaded from database.</param>
    /// <returns>The Form Builder version</returns>
    public static int GetFileVersion(string file, bool loadFromDb = false)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2fmmdfv_FileVersion(NdapiContext.GetContext(), file, loadFromDb, out var version)
            : NativeMethods.d2fmmdfv_FileVersion(NdapiContext.GetContext(), file, out version);

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
    /// Inserts a role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which role should be inserted.</param>
    /// <param name="role">Role name.</param>
    public void AddRoleAt(int index, string role)
    {
        var status = NativeMethods.d2fmmdar_AddRole(NdapiContext.GetContext(), Handle, index, role);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which role should be removed.</param>
    public void DeleteRoleAt(int index)
    {
        var status = NativeMethods.d2fmmdrr_RemoveRole(NdapiContext.GetContext(), Handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the role.</param>
    /// <returns>The role name.</returns>
    public string GetRoleAt(int index)
    {
        var status = NativeMethods.d2fmmdgr_GetRole(NdapiContext.GetContext(), Handle, index, out var role);
        Ensure.Success(status);
        return role;
    }

    /// <summary>
    /// Creates a menu.
    /// </summary>
    /// <param name="name">Name of the menu.</param>
    /// <returns>The child object.</returns>
    public Menu CreateMenu(string name) => new(this, name);

    /// <summary>
    /// Creates a menu parameter.
    /// </summary>
    /// <param name="name">Name of the menu parameter.</param>
    /// <returns>The child object.</returns>
    public MenuParameter CreateFormParameter(string name) => new(this, name);

    /// <summary>
    /// Creates a program unit.
    /// </summary>
    /// <param name="name">Name of the program unit.</param>
    /// <returns>The child object.</returns>
    public ProgramUnit CreateProgramUnit(string name) => new(this, name);

    /// <summary>
    /// Creates an object group.
    /// </summary>
    /// <param name="name">Name of the object group.</param>
    /// <returns>The child object.</returns>
    public ObjectGroup CreateObjectGroup(string name) => new(this, name);

    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="name">Name of the property class.</param>
    /// <returns>The child object.</returns>
    public PropertyClass CreatePropertyClass(string name) => new(this, name);

    /// <summary>
    /// Creates a visual attribute.
    /// </summary>
    /// <param name="name">Name of the visual attribute.</param>
    /// <returns>The child object.</returns>
    public VisualAttribute CreateVisualAttribute(string name) => new(this, name);
}
