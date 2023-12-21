﻿using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a menu module.
    /// </summary>
    public class MenuModule : NdapiModule
    {
        /// <summary>
        /// Creates a menu module.
        /// </summary>
        /// <param name="name">Menu name.</param>
        public MenuModule(string name) : base(name, ObjectType.MenuModule)
        {
        }

        internal MenuModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the main menu.
        /// </summary>
        [Property(NdapiConstants.D2FP_MAIN_MNU)]
        public string MainMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MAIN_MNU); }
            set { SetStringProperty(NdapiConstants.D2FP_MAIN_MNU, value); }
        }

        /// <summary>
        /// Gets or sets the module directory.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_DRCTRY)]
        public string Directory
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_DRCTRY); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_DRCTRY, value); }
        }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_FLNAM)]
        public string Filename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu module will share it attached libraries with form modules.
        /// </summary>
        [Property(NdapiConstants.D2FP_SHARE_LIB)]
        public bool ShareLibraryWithForm
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHARE_LIB); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHARE_LIB, value); }
        }

        /// <summary>
        /// Gets or sets the startup code.
        /// </summary>
        [Property(NdapiConstants.D2FP_STRTUP_CODE)]
        public string StartupCode
        {
            get { return GetStringProperty(NdapiConstants.D2FP_STRTUP_CODE); }
            set { SetStringProperty(NdapiConstants.D2FP_STRTUP_CODE, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should enforce the security scheme defined for the menu module.
        /// </summary>
        [Property(NdapiConstants.D2FP_USE_SECURITY)]
        public bool UseSecurity
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_USE_SECURITY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_USE_SECURITY, value); }
        }

        /// <summary>
        /// Gets all the attached libraries.
        /// </summary>
        [Property(NdapiConstants.D2FP_ATT_LIB)]
        public NdapiObjectList<AttachedLibrary> AttachedLibraries =>
            GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB);

        /// <summary>
        /// Gets all the menus.
        /// </summary>
        [Property(NdapiConstants.D2FP_MENU)]
        public NdapiObjectList<Menu> Menus =>
            GetObjectList<Menu>(NdapiConstants.D2FP_MENU);

#if FORMS_6
        /// <summary>
        /// Gets all the menu parameters.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_PARAM)]
        public NdapiObjectList<MenuParameter> Parameters =>
            GetObjectList<MenuParameter>(NdapiConstants.D2FP_MNU_PARAM);
#endif

        /// <summary>
        /// Gets all the object groups.
        /// </summary>
        [Property(NdapiConstants.D2FP_OBJ_GRP)]
        public NdapiObjectList<ObjectGroup> ObjectGroups =>
            GetObjectList<ObjectGroup>(NdapiConstants.D2FP_OBJ_GRP);

        /// <summary>
        /// Gets all the program units.
        /// </summary>
        [Property(NdapiConstants.D2FP_PROG_UNIT)]
        public NdapiObjectList<ProgramUnit> ProgramUnits =>
            GetObjectList<ProgramUnit>(NdapiConstants.D2FP_PROG_UNIT);

        /// <summary>
        /// Gets all the property classes.
        /// </summary>
        [Property(NdapiConstants.D2FP_PROP_CLASS)]
        public NdapiObjectList<PropertyClass> PropertyClasses =>
            GetObjectList<PropertyClass>(NdapiConstants.D2FP_PROP_CLASS);

        /// <summary>
        /// Gets the total number of roles.
        /// </summary>
        [Property(NdapiConstants.D2FP_ROLE_COUNT)]
        public int RoleCount =>
            GetNumberProperty(NdapiConstants.D2FP_ROLE_COUNT);

        /// <summary>
        /// Gets all the visual attributes.
        /// </summary>
        [Property(NdapiConstants.D2FP_VIS_ATTR)]
        public NdapiObjectList<VisualAttribute> VisualAttributes =>
            GetObjectList<VisualAttribute>(NdapiConstants.D2FP_VIS_ATTR);

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
#if FORMS_6
            var status = NativeMethods.d2fmmdld_Load(NdapiContext.GetContext(), out var menu, filename, false);
#else
            var status = NativeMethods.d2fmmdld_Load(NdapiContext.GetContext(), out var menu, filename);
#endif
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
#if FORMS_6
            var status = NativeMethods.d2fmmdsv_Save(NdapiContext.GetContext(), _handle, path, saveInDatabase);
#else
            var status = NativeMethods.d2fmmdsv_Save(NdapiContext.GetContext(), _handle, path);
#endif
            Ensure.Success(status);
        }

        /// <summary>
        /// Compile the menu module creating an .mmx.
        /// </summary>
        public override void CompileFile()
        {
            var status = NativeMethods.d2fmmdcf_CompileFile(NdapiContext.GetContext(), _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Compile PL/SQL code in the menu module.
        /// </summary>
        public override void CompileObjects()
        {
            var status = NativeMethods.d2fmmdco_CompileObj(NdapiContext.GetContext(), _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the version of the last Form Builder that loaded the module.
        /// </summary>
        /// <param name="file">Menu module location (.mmb file)</param>
        /// <returns>The Form Builder version</returns>
        public static int GetFileVersion(string file)
        {
            return GetFileVersion(file, false);
        }

        /// <summary>
        /// Gets the version of the last Form Builder that loaded the module.
        /// </summary>
        /// <param name="file">Menu module location (.mmb file)</param>
        /// <param name="loadFromDb">Module should be loaded from database.</param>
        /// <returns>The Form Builder version</returns>
        public static int GetFileVersion(string file, bool loadFromDb)
        {
#if FORMS_6
            var status = NativeMethods.d2fmmdfv_FileVersion(NdapiContext.GetContext(), file, loadFromDb, out var version);
#else
            var status = NativeMethods.d2fmmdfv_FileVersion(NdapiContext.GetContext(), file, out var version);
#endif
            Ensure.Success(status);
            return version;
        }

        /// <summary>
        /// Attaches a new library to the current module.
        /// </summary>
        /// <param name="location">Library location.</param>
        /// <returns>Instance of the attached library.</returns>
        public AttachedLibrary AttachLibrary(string location) => new AttachedLibrary(this, location);

        /// <summary>
        /// Inserts a role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which role should be inserted.</param>
        /// <param name="role">Role name.</param>
        public void AddRoleAt(int index, string role)
        {
            var status = NativeMethods.d2fmmdar_AddRole(NdapiContext.GetContext(), _handle, index, role);
            Ensure.Success(status);
        }

        /// <summary>
        /// Deletes the role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which role should be removed.</param>
        public void DeleteRoleAt(int index)
        {
            var status = NativeMethods.d2fmmdrr_RemoveRole(NdapiContext.GetContext(), _handle, index);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index of the role.</param>
        /// <returns>The role name.</returns>
        public string GetRoleAt(int index)
        {
            string role;
            var status = NativeMethods.d2fmmdgr_GetRole(NdapiContext.GetContext(), _handle, index, out role);
            Ensure.Success(status);
            return role;
        }

        /// <summary>
        /// Creates a menu.
        /// </summary>
        /// <param name="name">Name of the menu.</param>
        /// <returns>The child object.</returns>
        public Menu CreateMenu(string name) => new Menu(this, name);

#if FORMS_6
        /// <summary>
        /// Creates a menu parameter.
        /// </summary>
        /// <param name="name">Name of the menu parameter.</param>
        /// <returns>The child object.</returns>
        public MenuParameter CreateFormParameter(string name) => new MenuParameter(this, name);
#endif

        /// <summary>
        /// Creates a program unit.
        /// </summary>
        /// <param name="name">Name of the program unit.</param>
        /// <returns>The child object.</returns>
        public ProgramUnit CreateProgramUnit(string name) => new ProgramUnit(this, name);

        /// <summary>
        /// Creates an object group.
        /// </summary>
        /// <param name="name">Name of the object group.</param>
        /// <returns>The child object.</returns>
        public ObjectGroup CreateObjectGroup(string name) => new ObjectGroup(this, name);

        /// <summary>
        /// Creates a property class.
        /// </summary>
        /// <param name="name">Name of the property class.</param>
        /// <returns>The child object.</returns>
        public PropertyClass CreatePropertyClass(string name) => new PropertyClass(this, name);

        /// <summary>
        /// Creates a visual attribute.
        /// </summary>
        /// <param name="name">Name of the visual attribute.</param>
        /// <returns>The child object.</returns>
        public VisualAttribute CreateVisualAttribute(string name) => new VisualAttribute(this, name);
    }
}
