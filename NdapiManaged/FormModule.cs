using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged
{
    public class FormModule : NdapiObject
    {
        internal FormModule(ObjectSafeHandle handler) : base(handler)
        {
        }

        public static FormModule Open(string filename)
        {
            ObjectSafeHandle form;

            var status = NativeMethods.d2ffmdld_Load(NdapiContext.Context, out form, filename, false);
            Ensure.Success(status);

            return new FormModule(form);
        }
    }
}
