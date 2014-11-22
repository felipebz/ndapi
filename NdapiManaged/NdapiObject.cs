using NdapiManaged.Core.Handles;
using System;

namespace NdapiManaged
{
    public class NdapiObject
    {
        private ObjectSafeHandle _handler;

        internal NdapiObject(ObjectSafeHandle handler)
        {
            _handler = handler;
        }
    }
}