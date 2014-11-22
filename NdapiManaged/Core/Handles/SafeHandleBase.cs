using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged.Core.Handles
{
    internal abstract class SafeHandleBase : SafeHandle
    {
        protected SafeHandleBase() : base(IntPtr.Zero, true)
        {
            //Console.WriteLine("SafeHandleBase");
        }

        public override bool IsInvalid
        {
            get
            {
                return handle == IntPtr.Zero;
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected abstract bool ReleaseHandleImpl();

        protected override sealed bool ReleaseHandle()
        {
            //Console.WriteLine("ReleaseHandle");
            return ReleaseHandleImpl();
        }
    }
}
