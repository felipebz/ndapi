using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using System;

namespace NdapiManaged
{
    public class NdapiObject
    {
        private ObjectSafeHandle _handler;

        internal NdapiObject(ObjectSafeHandle handler)
        {
            _handler = handler;
        }

        public string GetStringProperty(int property)
        {
            string value;
            var status = NativeMethods.d2fobgt_GetTextProp(NdapiContext.Context, _handler, property, out value);
            Ensure.Success(status);
            return value;
        }

        public void SetStringProperty(int property, string value)
        {
            var status = NativeMethods.d2fobst_SetTextProp(NdapiContext.Context, _handler, property, value);
            Ensure.Success(status);
        }

        public int GetNumberProperty(int property)
        {
            int value;
            var status = NativeMethods.d2fobgn_GetNumProp(NdapiContext.Context, _handler, property, out value);
            Ensure.Success(status);
            return value;
        }

        public T GetNumberProperty<T>(int property) where T : struct
        {
            return (T)Enum.Parse(typeof(T), GetNumberProperty(property).ToString(), true);
        }

        public void SetNumberProperty(int property, int value)
        {
            var status = NativeMethods.d2fobsn_SetNumProp(NdapiContext.Context, _handler, property, value);
            Ensure.Success(status);
        }

        public void SetNumberProperty<T>(int property, T value) where T : struct
        {
            SetNumberProperty(property, Convert.ToInt32(value));
        }

        public bool GetBooleanProperty(int property)
        {
            bool value;
            var status = NativeMethods.d2fobgb_GetBoolProp(NdapiContext.Context, _handler, property, out value);
            Ensure.Success(status);
            return value;
        }

        public void SetBooleanProperty(int property, bool value)
        {
            var status = NativeMethods.d2fobsb_SetBoolProp(NdapiContext.Context, _handler, property, value);
            Ensure.Success(status);
        }
    }
}