using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class ObjectGroup : NdapiObject
    {
        public ObjectGroup(FormModule module, string name)
        {
            Create(name, ObjectType.ObjectGroup, module);
        }

        internal ObjectGroup(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public IEnumerable<ObjectGroupChild> Childs
        {
            get { return GetObjectList<ObjectGroupChild>(NdapiConstants.D2FP_OG_CHILD); }
        }
    }
}
