﻿using System;
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

            int length = _encoding.GetByteCount(str);
            var buffer = (byte*)Marshal.AllocHGlobal(length + 1).ToPointer();

            if (length > 0)
            {
                fixed (char* pValue = str)
                {
                    _encoding.GetBytes(pValue, str.Length, buffer, length);
                }
            }

            buffer[length] = 0;

            return new IntPtr(buffer);
        }

        public unsafe object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
            {
                return null;
            }

            var start = (byte*)pNativeData;
            byte* walk = start;

            // Find the end of the string
            while (*walk != 0)
            {
                walk++;
            }

            if (walk == start)
            {
                return string.Empty;
            }

            return new string((sbyte*)pNativeData.ToPointer(), 0, (int)(walk - start), _encoding);
        }
    }
}