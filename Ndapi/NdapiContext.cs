using Ndapi.Core;
using Ndapi.Core.Handles;
using System;

namespace Ndapi
{
    /// <summary>
    /// Represents a Forms API context.
    /// </summary>
    public sealed class NdapiContext : IDisposable
    {
        private static ContextSafeHandle _context;

        internal static ContextSafeHandle Context
        {
            get
            {
                if (_context == null)
                {
                    var context_attributes = IntPtr.Zero;
                    var status = NativeMethods.d2fctxcr_Create(out _context, ref context_attributes);
                    Ensure.Success(status);
                }
                return _context;
            }
        }

        /// <summary>
        /// Gets the version of the Forms API currently running. The format of the version number is a number 
        /// of the form 12334455, that corresponds to version 1.2.33.44.55.
        /// </summary>
        public static int ProductVersion
        {
            get
            {
                var version = 0;

                var status = NativeMethods.d2fctxbv_BuilderVersion(Context, ref version);
                Ensure.Success(status);

                return version;
            }
        }

        /// <summary>
        /// Establish a database connection given a connect string.
        /// </summary>
        /// <param name="connection">Connection string (username/password@database).</param>
        public static void ConnectToDatabase(string connection)
        {
            var status = NativeMethods.d2fctxcn_Connect(Context, connection, IntPtr.Zero);
            Ensure.Success(status);
        }

        /// <summary>
        /// Disconnect from the current database if one has been established.
        /// </summary>
        public static void DisconnectFromDatabase()
        {
            var status = NativeMethods.d2fctxdc_Disconnect(Context);
            Ensure.Success(status);
        }

        /// <summary>
        /// Destroy the Forms API context.
        /// </summary>
        public static void Destroy()
        {
            if (!_context.IsInvalid)
            {
                _context.Dispose();
                _context = null;
            }
        }

        /// <summary>
        /// Destroy the Forms API context and dispose the object.
        /// </summary>
        public void Dispose()
        {
            Destroy();
            GC.SuppressFinalize(this);
        }
    }
}
