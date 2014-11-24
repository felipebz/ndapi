using Ndapi.Core;
using Ndapi.Core.Handles;
using System;

namespace Ndapi
{
    public sealed class NdapiContext : IDisposable
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

        public static void ConnectToDatabase(string connection)
        {
            var status = NativeMethods.d2fctxcn_Connect(Context, connection, IntPtr.Zero);
            Ensure.Success(status);
        }

        public static void DisconnectFromDatabase()
        {
            var status = NativeMethods.d2fctxdc_Disconnect(Context);
            Ensure.Success(status);
        }

        public static void Destroy()
        {
            if (!_context.IsInvalid)
            {
                _context.Dispose();
                _context = null;
            }
        }

        public void Dispose()
        {
            Destroy();
        }
    }
}
