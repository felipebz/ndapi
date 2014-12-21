using System.Collections.Generic;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Core;

namespace Ndapi
{
    public class PropertyClass : NdapiObject
    {
        public PropertyClass(FormModule module, string name)
        {
            Create(name, ObjectType.PropertyClass, module);
        }

        internal PropertyClass(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public IEnumerable<Trigger> Triggers =>
            GetObjectList<Trigger>(NdapiConstants.D2FP_TRIGGER);

        public void RemoveProperty(int propertyId)
        {
            var status = NativeMethods.d2fppcrp_RemoveProp(NdapiContext.Context, _handle, propertyId);
            Ensure.Success(status);
        }
    }
}
