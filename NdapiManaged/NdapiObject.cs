using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdapiManaged
{
    public class NdapiObject
    {
        internal ObjectSafeHandle _handle;

        public NdapiObject()
        {
        }

        internal NdapiObject(ObjectSafeHandle handle)
        {
            _handle = handle;
        }

        public string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_NAME, value); }
        }

        public int ParentType
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PAR_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PAR_TYP, value); }
        }

        public string ParentName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_NAM, value); }
        }

        public string ParentModule
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_MODULE); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_MODULE, value); }
        }

        public int ParentModuleType
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP, value); }
        }

        public ModuleStorageType ParentModuleStorage
        {
            get { return GetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR); }
            set { SetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR, value); }
        }

        public string ParentFileNamePath
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_FLPATH); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_FLPATH, value); }
        }

        public string ParentFileName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_FLNAM, value); }
        }

        public NdapiObject Owner
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_OWNER); }
        }

        public bool IsSubclassed
        {
            get
            {
                var status = NativeMethods.d2fobis_IsSubclassed(NdapiContext.Context, _handle);
                Ensure.BooleanResult(status);
                return status == (int)D2fErrorCode.D2FS_YES;
            }
        }

        protected void Create(string name, int type)
        {
            var status = NativeMethods.d2fobcr_Create(NdapiContext.Context, new ObjectSafeHandle(), out _handle, name, type);
            Ensure.Success(status);
        }

        private void SetHandle(ObjectSafeHandle handle)
        {
            _handle = handle;
        }

        public string GetStringProperty(int property)
        {
            string value;
            var status = NativeMethods.d2fobgt_GetTextProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        public void SetStringProperty(int property, string value)
        {
            var status = NativeMethods.d2fobst_SetTextProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        public int GetNumberProperty(int property)
        {
            int value;
            var status = NativeMethods.d2fobgn_GetNumProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        public T GetNumberProperty<T>(int property) where T : struct
        {
            return (T)Enum.Parse(typeof(T), GetNumberProperty(property).ToString(), true);
        }

        public void SetNumberProperty(int property, int value)
        {
            var status = NativeMethods.d2fobsn_SetNumProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        public void SetNumberProperty<T>(int property, T value) where T : struct
        {
            SetNumberProperty(property, Convert.ToInt32(value));
        }

        public bool GetBooleanProperty(int property)
        {
            bool value;
            var status = NativeMethods.d2fobgb_GetBoolProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        public void SetBooleanProperty(int property, bool value)
        {
            var status = NativeMethods.d2fobsb_SetBoolProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        public T GetObjectProperty<T>(int property) where T : NdapiObject
        {
            ObjectSafeHandle handle;
            var status = NativeMethods.d2fobgo_GetObjProp(NdapiContext.Context, _handle, property, out handle);
            Ensure.Success(status);

            if (handle.IsInvalid)
            {
                return null;
            }

            var instance = (NdapiObject)Activator.CreateInstance<T>();
            instance.SetHandle(handle);
            return (T)instance;
        }

        public void SetObjectProperty<T>(int property, T value) where T : NdapiObject
        {
            var status = NativeMethods.d2fobso_SetObjProp(NdapiContext.Context, _handle, property, value._handle);
            Ensure.Success(status);
        }

        public IEnumerable<T> GetObjectList<T>(int property) where T : NdapiObject
        {
            var _result = GetObjectProperty<T>(property);
            while (_result != null)
            {
                yield return _result;
                _result = _result.GetObjectProperty<T>(NdapiConstants.D2FP_NEXT);
            }

        }

        public string GetQualifiedName(bool includeModule)
        {
            var builder = new StringBuilder();
            var owner = Owner;
            if (owner != null)
            {
                int type;
                var status = NativeMethods.d2fobqt_QueryType(NdapiContext.Context, owner._handle, out type);
                Ensure.Success(status);

                if (includeModule || (type != NdapiConstants.D2FFO_FORM_MODULE))
                {
                    builder.Append(owner.GetQualifiedName(includeModule));
                    builder.Append(".");
                }
            }
            builder.Append(Name);
            return builder.ToString();
        }

        public bool HasOverriddenProperty(int property)
        {
            var status = NativeMethods.d2fobid_IspropDefault(NdapiContext.Context, _handle, property);
            Ensure.BooleanResult(status);

            return status == (int)D2fErrorCode.D2FS_YES;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}