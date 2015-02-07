using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a generic object.
    /// </summary>
    public class NdapiObject<T> : BaseNdapiObject where T : class
    {
        internal NdapiObject() : base() { }
        internal NdapiObject(ObjectType type) : base(type) { }
        internal NdapiObject(string name, ObjectType type, BaseNdapiObject parent = null) : base(name, type, parent) { }
        internal NdapiObject(ObjectSafeHandle handle) : base(handle) { }
    }
}
