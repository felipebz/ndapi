using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;

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
        /// Gets the number of object in the library.
        /// </summary>
        public int ObjectCount => GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);

        /// <summary>
        /// Gets all the tabs.
        /// </summary>
        public IEnumerable<ObjectLibraryTab> Tabs => GetObjectList<ObjectLibraryTab>(NdapiConstants.D2FP_OBJ_LIB_TAB);

        /// <summary>
        /// Gets all the objects contained in this Library.
        /// </summary>
        public IEnumerable<NdapiObject> Objects
        {
            get
            {
                for (var i = 1; i<= ObjectCount; i++) // objects index is one-based
                {
                    yield return GetObjectByPosition(i);
                }
            }
        }

        /// <summary>
        /// Get the object in the specified position.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <returns>The object found.</returns>
        public NdapiObject GetObjectByPosition(int position)
        {
            ObjectSafeHandle obj;
            var status = NativeMethods.d2folbf2_Findobjbypos(NdapiContext.Context, _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return new NdapiObject(obj);
        }

        /// <summary>
        /// Load the object library into memory.
        /// </summary>
        /// <param name="filename">Library location (.olb file)</param>
        /// <returns>Loaded library reference.</returns>
        public new static ObjectLibrary Open(string filename)
        {
            ObjectSafeHandle form;

            var status = NativeMethods.d2folbld_Load(NdapiContext.Context, out form, filename, false);
            Ensure.Success(status);

            return new ObjectLibrary(form);
        }

        /// <summary>
        /// Save the object library to disk.
        /// </summary>
        /// <param name="path">Location to save.</param>
        /// <param name="saveInDatabase">Should save library in database.</param>
        public override void Save(string path = null, bool saveInDatabase = false)
        {
            var status = NativeMethods.d2folbsv_Save(NdapiContext.Context, _handle, path, saveInDatabase);
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
        /// <param name="loadFromDb">Library should be loaded from database.</param>
        /// <returns>The Form Builder version</returns>
        public static int GetFileVersion(string file, bool loadFromDb = false)
        {
            int version;
            var status = NativeMethods.d2folbfv_FileVersion(NdapiContext.Context, file, loadFromDb, out version);
            Ensure.Success(status);
            return version;
        }
    }
}
