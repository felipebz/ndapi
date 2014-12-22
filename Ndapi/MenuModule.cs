using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class MenuModule : NdapiModule
    {
        public MenuModule(string name)
        {
            Create(name, ObjectType.MenuModule);
        }

        internal MenuModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string MainMenu
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MAIN_MNU); }
            set { SetStringProperty(NdapiConstants.D2FP_MAIN_MNU, value); }
        }

        public string Directory
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_DRCTRY); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_DRCTRY, value); }
        }

        public string Filename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_FLNAM, value); }
        }

        public bool ShareLibraryWithForm
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHARE_LIB); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHARE_LIB, value); }
        }

        public string StartupCode
        {
            get { return GetStringProperty(NdapiConstants.D2FP_STRTUP_CODE); }
            set { SetStringProperty(NdapiConstants.D2FP_STRTUP_CODE, value); }
        }

        public bool UseSecurity
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_USE_SECURITY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_USE_SECURITY, value); }
        }

        public IEnumerable<AttachedLibrary> AttachedLibraries =>
            GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB);

        public IEnumerable<Menu> Menus =>
            GetObjectList<Menu>(NdapiConstants.D2FP_MENU);

        public IEnumerable<MenuParameter> Parameters =>
            GetObjectList<MenuParameter>(NdapiConstants.D2FP_MNU_PARAM);

        public IEnumerable<ObjectGroup> ObjectGroups =>
            GetObjectList<ObjectGroup>(NdapiConstants.D2FP_OBJ_GRP);

        public IEnumerable<ProgramUnit> ProgramUnits =>
            GetObjectList<ProgramUnit>(NdapiConstants.D2FP_PROG_UNIT);

        public IEnumerable<PropertyClass> PropertyClasses =>
            GetObjectList<PropertyClass>(NdapiConstants.D2FP_PROP_CLASS);

        public int RoleCount =>
            GetNumberProperty(NdapiConstants.D2FP_ROLE_COUNT);

        public IEnumerable<VisualAttribute> VisualAttributes =>
            GetObjectList<VisualAttribute>(NdapiConstants.D2FP_VIS_ATTR);

        public new static MenuModule Open(string filename)
        {
            ObjectSafeHandle menu;

            var status = NativeMethods.d2fmmdld_Load(NdapiContext.Context, out menu, filename, false);
            Ensure.Success(status);

            return new MenuModule(menu);
        }

        public override void Save(string path = null, bool saveInDatabase = false)
        {
            var status = NativeMethods.d2fmmdsv_Save(NdapiContext.Context, _handle, path, saveInDatabase);
            Ensure.Success(status);
        }

        public override void CompileFile()
        {
            var status = NativeMethods.d2fmmdcf_CompileFile(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        public override void CompileObjects()
        {
            var status = NativeMethods.d2fmmdco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Attaches a new library to the current module.
        /// </summary>
        /// <param name="location">Library location.</param>
        /// <returns>Instance of the attached library.</returns>
        public AttachedLibrary AttachLibrary(string location) => new AttachedLibrary(this, location);
    }
}
