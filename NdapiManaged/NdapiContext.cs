using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged
{
    public class NdapiContext
    {
        private static IntPtr _context;

        public static IntPtr Context
        {
            get
            {
                if (_context == IntPtr.Zero)
                {
                    var context_attributes = new d2fctxa();
                    context_attributes.mask_d2fctxa = 0;
                    var status = NativeMethods.d2fctxcr_Create(ref _context, ref context_attributes);
                }
                return _context;
            }
        }

        public static int ProductVersion
        {
            get
            {
                uint version = 0;
                var status = NativeMethods.d2fctxbv_BuilderVersion(Context, ref version);
                return (int)version;
            }
        }
    }
}
