using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents an object group child. Every object must be wrapped in an "object group child" to add it
    /// in an object group.
    /// </summary>
    public class ObjectGroupChild : NdapiObject<ObjectGroupChild>
    {
        /// <summary>
        /// Creates an object group child.
        /// </summary>
        /// <param name="group">Object owner.</param>
        /// <param name="name">Object name.</param>
        public ObjectGroupChild(ObjectGroup group, string name) : base(name, ObjectType.ObjectGroupChild, group)
        {
        }

        internal ObjectGroupChild(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the real object.
        /// </summary>
        [Property(NdapiConstants.D2FP_OBJ_GRP_CHILD_REAL_OBJ)]
        public NdapiObject RealObject
        {
            get => GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_OBJ_GRP_CHILD_REAL_OBJ);
            set => SetObjectProperty(NdapiConstants.D2FP_OBJ_GRP_CHILD_REAL_OBJ, value);
        }
    }
}
