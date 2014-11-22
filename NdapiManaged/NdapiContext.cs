using NdapiManaged.Core;
using NdapiManaged.Core.Handles;

namespace NdapiManaged
{
    public class NdapiContext
    {
        private static ContextSafeHandle _context;

        internal static ContextSafeHandle Context
        {
            get
            {
                if (_context == null)
                {
                    var context_attributes = new D2fContextAttributes();
                    context_attributes.mask_d2fctxa = 0;
                    var status = NativeMethods.d2fctxcr_Create(out _context, ref context_attributes);
                    Ensure.Success(status);
                }
                return _context;
            }
        }

        public static int ProductVersion
        {
            get
            {
                int version = 0;

                var status = NativeMethods.d2fctxbv_BuilderVersion(Context, ref version);
                Ensure.Success(status);

                return version;
            }
        }
    }
}
