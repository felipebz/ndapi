using System.Collections.Generic;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Core;

namespace Ndapi
{
    /// <summary>
    /// Represent an object library tab.
    /// </summary>
    public class ObjectLibraryTab : NdapiObject
    {
        /// <summary>
        /// Creates an object library tab..
        /// </summary>
        /// <param name="library">Object library.</param>
        /// <param name="name">Tab name.</param>
        public ObjectLibraryTab(ObjectLibrary library, string name) : base(name, ObjectType.ObjectLibraryTab, library)
        {
        }

        internal ObjectLibraryTab(ObjectSafeHandle handle) : base(handle)
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
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets the number of object in the tab.
        /// </summary>
        public int ObjectCount => GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);

        /// <summary>
        /// Gets all the objects contained in this tab.
        /// </summary>
        public IEnumerable<NdapiObject> Objects
        {
            get
            {
                for (var i = 1; i <= ObjectCount; i++) // objects index is one-based
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
            var status = NativeMethods.d2foltf2_Findobjbypos(NdapiContext.Context, _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return new NdapiObject(obj);
        }
    }
}
