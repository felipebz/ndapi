using NdapiManaged.Core;
using NdapiManaged.Core.Handles;

namespace NdapiManaged
{
    public class NdapiObject
    {
        private ObjectSafeHandle _handler;

        internal NdapiObject(ObjectSafeHandle handler)
        {
            _handler = handler;
        }

        public string GetStringProperty(int property)
        {
            string value;
            NativeMethods.d2fobgt_GetTextProp(NdapiContext.Context, _handler, property, out value);
            return value;
        }
    }
}