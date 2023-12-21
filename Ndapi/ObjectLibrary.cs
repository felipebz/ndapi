using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;

namespace Ndapi
{
    /// <summary>
    /// Represents an object library.
    /// </summary>
    public class ObjectLibrary : NdapiModule
    {
        /// <summary>
        /// Creates a object library;
        /// </summary>
        /// <param name="name">Object library name.</param>
        public ObjectLibrary(string name) : base(name, ObjectType.ObjectLibrary)
        {
        }

        internal ObjectLibrary(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets all the tabs.
        /// </summary>
        [Property(NdapiConstants.D2FP_OBJ_LIB_TAB)]
        public NdapiObjectList<ObjectLibraryTab> Tabs => GetObjectList<ObjectLibraryTab>(NdapiConstants.D2FP_OBJ_LIB_TAB);

        /// <summary>
        /// Gets all the objects contained in this Library.
        /// </summary>
        public NdapiObjectLibraryObjectList Objects => new NdapiObjectLibraryObjectList(this);

        /// <summary>
        /// Get the object in the specified position.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <returns>The object found.</returns>
        public NdapiObject GetObjectByPosition(int position)
        {
            ObjectSafeHandle obj;
            var status = NativeMethods.d2folbf2_Findobjbypos(NdapiContext.GetContext(), _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return Create<NdapiObject>(obj);
        }

        /// <summary>
        /// Load the object library into memory.
        /// </summary>
        /// <param name="filename">Library location (.olb file)</param>
        /// <returns>Loaded library reference.</returns>
        public new static ObjectLibrary Open(string filename)
        {
#if FORMS_6
            var status = NativeMethods.d2folbld_Load(NdapiContext.GetContext(), out var form, filename, false);
#else
            var status = NativeMethods.d2folbld_Load(NdapiContext.GetContext(), out ObjectSafeHandle form, filename);
#endif
            Ensure.Success(status);

            return new ObjectLibrary(form);
        }

        /// <summary>
        /// Save the object library to disk.
        /// </summary>
        public override void Save()
        {
            Save(null, false);
        }

        /// <summary>
        /// Save the object library to disk.
        /// </summary>
        /// <param name="path">Location to save.</param>
        public override void Save(string path)
        {
            Save(path, false);
        }

        /// <summary>
        /// Save the object library to disk.
        /// </summary>
        /// <param name="path">Location to save.</param>
        /// <param name="saveInDatabase">Should save library in database.</param>
        public override void Save(string path, bool saveInDatabase)
        {
#if FORMS_6
            var status = NativeMethods.d2folbsv_Save(NdapiContext.GetContext(), _handle, path, saveInDatabase);
#else
            var status = NativeMethods.d2folbsv_Save(NdapiContext.GetContext(), _handle, path);
#endif
            Ensure.Success(status);
        }

        /// <summary>
        /// Object libraries does not support compilation.
        /// </summary>
        public override void CompileFile()
        {
            throw new NotSupportedException("Object library module does not support compilation");
        }

        /// <summary>
        /// Object libraries does not support compilation.
        /// </summary>
        public override void CompileObjects()
        {
            throw new NotSupportedException("Object library module does not support compilation");
        }

        /// <summary>
        /// Gets the version of the last Form Builder that loaded the library.
        /// </summary>
        /// <param name="file">Object library location (.olb file)</param>
        /// <returns>The Form Builder version</returns>
        public static int GetFileVersion(string file)
        {
            return GetFileVersion(file, false);
        }

        /// <summary>
        /// Gets the version of the last Form Builder that loaded the library.
        /// </summary>
        /// <param name="file">Object library location (.olb file)</param>
        /// <param name="loadFromDb">Library should be loaded from database.</param>
        /// <returns>The Form Builder version</returns>
        public static int GetFileVersion(string file, bool loadFromDb)
        {
#if FORMS_6
            var status = NativeMethods.d2folbfv_FileVersion(NdapiContext.GetContext(), file, loadFromDb, out var version);
#else
            var status = NativeMethods.d2folbfv_FileVersion(NdapiContext.GetContext(), file, out int version);
#endif
            Ensure.Success(status);
            return version;
        }

        /// <summary>
        /// Creates an object library tab.
        /// </summary>
        /// <param name="name">Name of the object library tab.</param>
        /// <returns>The child object.</returns>
        public ObjectLibraryTab CreateObjectLibraryTab(string name) => new ObjectLibraryTab(this, name);

        /// <summary>
        /// Removes the object from the object library.
        /// </summary>
        /// <param name="obj">Object to be removed.</param>
        public void RemoveObject(NdapiObject obj)
        {
            var status = NativeMethods.d2folbro_RemoveObj(NdapiContext.GetContext(), _handle, obj._handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Flag whether an object is considered a smart object or not.
        /// </summary>
        /// <param name="obj">Object to check.</param>
        /// <param name="state">Indicate if it's a smart object or not.</param>
        public void SetSmartclass(NdapiObject obj, bool state)
        {
            var status = NativeMethods.d2folbss_SetSmartclass(NdapiContext.GetContext(), _handle, obj._handle, state);
            Ensure.Success(status);
        }

        /// <summary>
        /// Checks if an object is considered a smart object.
        /// </summary>
        /// <param name="obj">Object to check.</param>
        /// <returns>The state indicating if it's a smart object or not.</returns>
        public bool IsSmartclass(NdapiObject obj)
        {
            var status = NativeMethods.d2folbis_IsSmartclassed(NdapiContext.GetContext(), _handle, obj._handle);
            Ensure.BooleanResult(status);
            return status == D2fErrorCode.D2FS_YES;
        }

        /// <summary>
        /// Sets the description for an object in the library.
        /// </summary>
        /// <param name="obj">Object in library.</param>
        /// <param name="description">Description of object.</param>
        public void SetObjectDescription(NdapiObject obj, string description)
        {
            var status = NativeMethods.d2folbsd_SetDesc(NdapiContext.GetContext(), _handle, obj._handle, description);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the description for an object in the library.
        /// </summary>
        /// <param name="obj">Object in library.</param>
        /// <returns>Description of object.</returns>
        public string GetObjectDescription(NdapiObject obj)
        {
            string description;
            var status = NativeMethods.d2folbgd_GetDesc(NdapiContext.GetContext(), _handle, obj._handle, out description);
            Ensure.Success(status);
            return description;
        }

        /// <summary>
        /// Gets the name of the tab that a given object is on. 
        /// </summary>
        /// <param name="obj">Object in library.</param>
        /// <returns>Name of tab the object is on.</returns>
        public string GetObjectTabName(NdapiObject obj)
        {
            string tabName;
            var status = NativeMethods.d2folbot_ObjTabname(NdapiContext.GetContext(), _handle, obj._handle, out tabName);
            Ensure.Success(status);
            return tabName;
        }
    }
}
