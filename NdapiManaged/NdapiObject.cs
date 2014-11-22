using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
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

        public string Name
        {
            get
            {
                return GetStringProperty(NdapiConstants.D2FP_NAME);
            }
            set
            {
                SetStringProperty(NdapiConstants.D2FP_NAME, value);
            }
        }

        public int ParentType
        {
            get
            {
                return GetNumberProperty(NdapiConstants.D2FP_PAR_TYP);
            }
            set
            {
                SetNumberProperty(NdapiConstants.D2FP_PAR_TYP, value);
            }
        }

        public string ParentName
        {
            get
            {
                return GetStringProperty(NdapiConstants.D2FP_PAR_NAM);
            }
            set
            {
                SetStringProperty(NdapiConstants.D2FP_PAR_NAM, value);
            }
        }

        public string ParentModule
        {
            get
            {
                return GetStringProperty(NdapiConstants.D2FP_PAR_MODULE);
            }
            set
            {
                SetStringProperty(NdapiConstants.D2FP_PAR_MODULE, value);
            }
        }

        public int ParentModuleType
        {
            get
            {
                return GetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP);
            }
            set
            {
                SetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP, value);
            }
        }

        public ModuleStorageType ParentModuleStorage
        {
            get
            {
                return GetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR);
            }
            set
            {
                SetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR, value);
            }
        }

        public string ParentFileNamePath
        {
            get
            {
                return GetStringProperty(NdapiConstants.D2FP_PAR_FLPATH);
            }
            set
            {
                SetStringProperty(NdapiConstants.D2FP_PAR_FLPATH, value);
            }
        }

        public string ParentFileName
        {
            get
            {
                return GetStringProperty(NdapiConstants.D2FP_PAR_FLNAM);
            }
            set
            {
                SetStringProperty(NdapiConstants.D2FP_PAR_FLNAM, value);
            }
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

        public bool HasOverriddenProperty(int property)
        {
            var status = NativeMethods.d2fobid_IspropDefault(NdapiContext.Context, _handler, property);
            Ensure.BooleanResult(status);

            return status == (int)D2fErrorCode.D2FS_YES;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}