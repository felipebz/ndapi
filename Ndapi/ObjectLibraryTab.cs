using System.Collections.Generic;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Core;

namespace Ndapi
{
    /// <summary>
    /// Represent an object library tab.
    /// </summary>
    public class ObjectLibraryTab : BaseNdapiObject
    {
        /// <summary>
        /// Creates an object library tab..
        /// </summary>
        /// <param name="library">Object library.</param>
        /// <param name="name">Tab name.</param>
        public ObjectLibraryTab(ObjectLibrary library, string name) : base(name, ObjectType.ObjectLibraryTab, library)
        {
            ObjectLibrary = library;
        }

        internal ObjectLibraryTab(ObjectSafeHandle handle) : base(handle)
        {
        }

        public ObjectLibrary ObjectLibrary { get; }

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
        /// Gets or sets the label.
        /// </summary>
        [Property(NdapiConstants.D2FP_LABEL)]
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets all the objects contained in this tab.
        /// </summary>
        public NdapiObjectLibraryTabObjectsList Objects => new NdapiObjectLibraryTabObjectsList(this);

        /// <summary>
        /// Get the object in the specified position.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <returns>The object found.</returns>
        public BaseNdapiObject GetObjectByPosition(int position)
        {
            ObjectSafeHandle obj;
            var status = NativeMethods.d2foltf2_Findobjbypos(NdapiContext.Context, _handle, position, out obj);
            Ensure.Success(status);

            if (obj.IsInvalid)
            {
                return null;
            }

            return Create<BaseNdapiObject>(obj);
        }

        /// <summary>
        /// Add an object to the object library tab. When adding an object, a copy is made and it is this copy that is added to the library.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="obj">Object to add to library tab.</param>
        /// <param name="replace">Should replace the existing object.</param>
        /// <returns>A copy of the original object.</returns>
        public T AddObject<T>(T obj, bool replace = false) where T : BaseNdapiObject
        {
            var handle = new ObjectSafeHandle();
            var status = NativeMethods.d2folbao_AddObj(NdapiContext.Context, ObjectLibrary._handle, _handle, obj._handle, out handle, replace);
            Ensure.Success(status);
            return Create<T>(handle);
        }
    }
}
