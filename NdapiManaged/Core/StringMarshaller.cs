using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NdapiManaged.Core
{
    class StringMarshaller : ICustomMarshaler
    {
        private static Encoding _encoding;
        private static readonly StringMarshaller _staticInstance;

        static StringMarshaller()
        {
            _encoding = Encoding.ASCII;
            _staticInstance = new StringMarshaller();
        }

        public static ICustomMarshaler GetInstance(String cookie)
        {
            return _staticInstance;
        }

        public void CleanUpManagedData(object managedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
            {
                return;
            }

            Marshal.FreeHGlobal(pNativeData);
        }

        public int GetNativeDataSize()
        {
            return -1;
        }

        public unsafe IntPtr MarshalManagedToNative(object managedObj)
        {
            if (managedObj == null)
            {
                return IntPtr.Zero;
            }

            var str = managedObj as string;

            if (str == null)
            {
                throw new MarshalDirectiveException(string.Format(CultureInfo.InvariantCulture, "{0} must be used on a string.", GetType().Name));
            }

            return Marshal.StringToHGlobalAnsi(str);
        }

        public unsafe object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
            {
                return null;
            }

            return Marshal.PtrToStringAnsi(pNativeData);
        }
    }
}
