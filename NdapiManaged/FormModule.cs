using NdapiManaged.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged
{
    public class FormModule : NdapiObject
    {
        internal FormModule(IntPtr handler) : base(handler)
        {
        }

        public static FormModule Open(string filename)
        {
            var form = IntPtr.Zero;

            var status = NativeMethods.d2ffmdld_Load(NdapiContext.Context, ref form, filename, false);
            Ensure.Success(status);

            return new FormModule(form);
        }
    }
}
