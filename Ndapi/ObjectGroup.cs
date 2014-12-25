using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a group of objects.
    /// </summary>
    public class ObjectGroup : NdapiObject
    {
        /// <summary>
        /// Creates a object group.
        /// </summary>
        /// <param name="module">Object group owner.</param>
        /// <param name="name">Object group name.</param>
        public ObjectGroup(FormModule module, string name)
        {
            Create(name, ObjectType.ObjectGroup, module);
        }

        /// <summary>
        /// Creates a object group.
        /// </summary>
        /// <param name="module">Object group owner.</param>
        /// <param name="name">Object group name.</param>
        public ObjectGroup(MenuModule module, string name)
        {
            Create(name, ObjectType.ObjectGroup, module);
        }

        /// <summary>
        /// Creates a object group.
        /// </summary>
        /// <param name="library">Object group owner.</param>
        /// <param name="name">Object group name.</param>
        public ObjectGroup(ObjectLibrary library, string name)
        {
            Create(name, ObjectType.ObjectGroup, library);
        }

        internal ObjectGroup(ObjectSafeHandle handle) : base(handle)
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
        /// Gets the objects contained in the group.
        /// </summary>
        public IEnumerable<ObjectGroupChild> Childs => GetObjectList<ObjectGroupChild>(NdapiConstants.D2FP_OG_CHILD);
    }
}
