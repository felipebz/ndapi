using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class ObjectGroupChild : NdapiObject
    {
        public ObjectGroupChild(ObjectGroup group, string name)
        {
            Create(name, ObjectType.ObjectGroupChild, group);
        }

        internal ObjectGroupChild(ObjectSafeHandle handle) : base(handle)
        {
        }

        public NdapiObject RealObject
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_OBJ_GRP_CHILD_REAL_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_OBJ_GRP_CHILD_REAL_OBJ, value); }
        }
    }
}
