using NdapiManaged.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged
{
    public class FormModule
    {
        public FormModule()
        {

        }

        public static FormModule Open(string filename)
        {
            IntPtr form = IntPtr.Zero;

            var status = NativeMethods.d2ffmdld_Load(NdapiContext.Context, ref form, filename, false);
            return new FormModule();
        }
    }
}
