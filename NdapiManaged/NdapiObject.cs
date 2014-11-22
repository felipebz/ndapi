using System;

namespace NdapiManaged
{
    public class NdapiObject
    {
        private IntPtr _handler;

        internal NdapiObject(IntPtr handler)
        {
            _handler = handler;
        }
    }
}