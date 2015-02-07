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

        /// <summary>
        /// Creates a new object with the given name and owner.
        /// The new object is an exact copy of the original object, with all the same property values.
        /// </summary>
        /// <param name="newName">Name of the new object.</param>
        /// <param name="newOwner">New owner of the object. If null, the object will be owned by the same parent of the current object.</param>
        /// <param name="keepSubclassingInfo">If false, the sublassing info is discarded and the inherited properties are flattened into local values in the new object.</param>
        /// <returns>The new object.</returns>
        public T Clone(string newName, BaseNdapiObject newOwner = null, bool keepSubclassingInfo = true)
        {
            var parentHandle = newOwner?._handle ?? Owner._handle;

            ObjectSafeHandle newHandle;
            var status = keepSubclassingInfo ? NativeMethods.d2fobre_Replicate(NdapiContext.Context, parentHandle, _handle, out newHandle, newName)
                                             : NativeMethods.d2fobdu_Duplicate(NdapiContext.Context, parentHandle, _handle, out newHandle, newName);
            Ensure.Success(status);

            return Create<T>(newHandle);
        }

    }
}
