using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a group of objects.
    /// </summary>
    public class ObjectGroup : NdapiObject<ObjectGroup>
    {
        /// <summary>
        /// Creates a object group.
        /// </summary>
        /// <param name="module">Object group owner.</param>
        /// <param name="name">Object group name.</param>
        public ObjectGroup(FormModule module, string name) : base(name, ObjectType.ObjectGroup, module)
        {
        }

        /// <summary>
        /// Creates a object group.
        /// </summary>
        /// <param name="module">Object group owner.</param>
        /// <param name="name">Object group name.</param>
        public ObjectGroup(MenuModule module, string name) : base(name, ObjectType.ObjectGroup, module)
        {
        }

        internal ObjectGroup(ObjectSafeHandle handle) : base(handle)
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
        /// Gets the objects contained in the group.
        /// </summary>
        [Property(NdapiConstants.D2FP_OG_CHILD)]
        public NdapiObjectList<ObjectGroupChild> Childs => GetObjectList<ObjectGroupChild>(NdapiConstants.D2FP_OG_CHILD);

        /// <summary>
        /// Creates a object group child.
        /// </summary>
        /// <param name="name">Name of the object group child.</param>
        /// <returns>The child object.</returns>
        public ObjectGroupChild CreateObjectGroupChild(string name) => new ObjectGroupChild(this, name);
    }
}
