using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ndapi
{
    /// <summary>
    /// Represents a generic object.
    /// </summary>
    public class BaseNdapiObject
    {
        internal ObjectSafeHandle _handle;
        private ObjectType _type;

        internal BaseNdapiObject()
        {
            _type = ObjectType.Undefined;
        }

        internal BaseNdapiObject(ObjectType type)
        {
            _type = type;
        }

        internal BaseNdapiObject(string name, ObjectType type, BaseNdapiObject parent = null)
        {
            var parentHandle = parent?._handle ?? new ObjectSafeHandle();
            var status = NativeMethods.d2fobcr_Create(NdapiContext.Context, parentHandle, out _handle, name, (int)type);
            Ensure.Success(status);
            _type = type;
        }

        internal BaseNdapiObject(ObjectSafeHandle handle) : this()
        {
            _handle = handle;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Property(NdapiConstants.D2FP_NAME)]
        public virtual string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_NAME, value); }
        }

        /// <summary>
        /// Gets or sets the parent type.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_TYP)]
        public int ParentType
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PAR_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PAR_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the parent name.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_NAM)]
        public string ParentName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the parent module.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_MODULE)]
        public string ParentModule
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_MODULE); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_MODULE, value); }
        }

        /// <summary>
        /// Gets or sets the parent module type.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_MODTYP)]
        public int ParentModuleType
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PAR_MODTYP, value); }
        }

        /// <summary>
        /// Gets or sets the parent module storage.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_MODSTR)]
        public ModuleStorageType ParentModuleStorage
        {
            get { return GetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR); }
            set { SetNumberProperty<ModuleStorageType>(NdapiConstants.D2FP_PAR_MODSTR, value); }
        }

        /// <summary>
        /// Gets or sets the parent filename path.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_FLPATH)]
        public string ParentFileNamePath
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_FLPATH); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_FLPATH, value); }
        }

        /// <summary>
        /// Gets or sets the parent filename.
        /// </summary>
        [Property(NdapiConstants.D2FP_PAR_FLNAM)]
        public string ParentFileName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PAR_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PAR_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets the object owner.
        /// </summary>
        [Property(NdapiConstants.D2FP_OWNER)]
        public BaseNdapiObject Owner => GetObjectProperty<BaseNdapiObject>(NdapiConstants.D2FP_OWNER);

        /// <summary>
        /// Gets whether item is subclassed. 
        /// </summary>
        public bool IsSubclassed
        {
            get
            {
                var status = NativeMethods.d2fobis_IsSubclassed(NdapiContext.Context, _handle);
                Ensure.BooleanResult(status);
                return status == (int)D2fErrorCode.D2FS_YES;
            }
        }

        /// <summary>
        /// Gets a <see cref="NdapiMetaObject"/> instance for the object type.
        /// </summary>
        public NdapiMetaObject MetaObject => NdapiMetadata.GetMetaObjectFrom(GetType());

        /// <summary>
        /// Gets a list of the available properties for the object type.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> MetaProperties => MetaObject.AllProperties;

        /// <summary>
        /// Gets the value of a string property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property value.</returns>
        public string GetStringProperty(int property)
        {
            string value;
            var status = NativeMethods.d2fobgt_GetTextProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        /// <summary>
        /// Sets the value of a string property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <param name="value">Property value</param>
        public void SetStringProperty(int property, string value)
        {
            var status = NativeMethods.d2fobst_SetTextProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the value of a number property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property value.</returns>
        public int GetNumberProperty(int property)
        {
            int value;
            var status = NativeMethods.d2fobgn_GetNumProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        /// <summary>
        /// Gets the value of a number property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property value.</returns>
        public T GetNumberProperty<T>(int property) where T : struct
        {
            return (T)(ValueType)GetNumberProperty(property);
        }

        /// <summary>
        /// Sets the value of a number property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <param name="value">Property value</param>
        public void SetNumberProperty(int property, int value)
        {
            var status = NativeMethods.d2fobsn_SetNumProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        /// <summary>
        /// Sets the value of a number property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <param name="value">Property value</param>
        public void SetNumberProperty<T>(int property, T value) where T : struct
        {
            SetNumberProperty(property, Convert.ToInt32(value));
        }

        /// <summary>
        /// Gets the value of a boolean property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property value.</returns>
        public bool GetBooleanProperty(int property)
        {
            bool value;
            var status = NativeMethods.d2fobgb_GetBoolProp(NdapiContext.Context, _handle, property, out value);
            Ensure.Success(status);
            return value;
        }

        /// <summary>
        /// Sets the value of a boolean property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <param name="value">Property value</param>
        public void SetBooleanProperty(int property, bool value)
        {
            var status = NativeMethods.d2fobsb_SetBoolProp(NdapiContext.Context, _handle, property, value);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the value of an object property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property value.</returns>
        public T GetObjectProperty<T>(int property) where T : BaseNdapiObject
        {
            ObjectSafeHandle handle;
            var status = NativeMethods.d2fobgo_GetObjProp(NdapiContext.Context, _handle, property, out handle);
            Ensure.Success(status);

            if (handle.IsInvalid)
            {
                return null;
            }

            return Create<T>(handle);
        }

        /// <summary>
        /// Sets the value of an object property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <param name="value">Property value</param>
        public void SetObjectProperty<T>(int property, T value) where T : BaseNdapiObject
        {
            var status = NativeMethods.d2fobso_SetObjProp(NdapiContext.Context, _handle, property, value._handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets a list of child objects.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>List of child objects.</returns>
        public NdapiObjectList<T> GetObjectList<T>(int property) where T : BaseNdapiObject
        {
            return new NdapiObjectList<T>(this, property);
        }

        /// <summary>
        /// Gets the real object type.
        /// </summary>
        /// <returns>The object type.</returns>
        public ObjectType GetObjectType()
        {
            if (_type != ObjectType.Undefined)
            {
                return _type;
            }

            var status = NativeMethods.d2fobqt_QueryType(NdapiContext.Context, _handle, out _type);
            Ensure.Success(status);

            return _type;
        }

        /// <summary>
        /// Get the qualified name of object. The name includes the object name itself and the name of its ancestors.
        /// </summary>
        /// <param name="includeModule">Should include the module in the qualified name.</param>
        /// <returns>The qualified name.</returns>
        public string GetQualifiedName(bool includeModule)
        {
            var builder = new StringBuilder();
            var owner = Owner;
            if ((owner != null) && (includeModule || (owner.GetObjectType() != ObjectType.FormModule)))
            {
                builder.Append(owner.GetQualifiedName(includeModule));
                builder.Append(".");
            }
            builder.Append(Name);
            return builder.ToString();
        }

        /// <summary>
        /// Checks whether the object has the specified property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>A boolean indicating whether item has the property.</returns>
        public bool HasProperty(int property)
        {
            var status = NativeMethods.d2fobhp_HasProp(NdapiContext.Context, _handle, property);
            Ensure.BooleanResult(status);

            return status == (int)D2fErrorCode.D2FS_YES;
        }

        /// <summary>
        /// Inherits a property from the parent.
        /// </summary>
        /// <param name="property"></param>
        public void InheritProperty(int property)
        {
            var status = NativeMethods.d2fobip_InheritProp(NdapiContext.Context, _handle, property);
            Ensure.Success(status);
        }

        /// <summary>
        /// Checks whether the property has its default value.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>A boolean indicating whether property  has its default value.</returns>
        public bool HasDefaultedProperty(int property)
        {
            var status = NativeMethods.d2fobid_IspropDefault(NdapiContext.Context, _handle, property);
            Ensure.BooleanResult(status);

            return status == (int)D2fErrorCode.D2FS_YES;
        }

        /// <summary>
        /// Checks whether the property was inherited.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>A boolean indicating whether property was inherited.</returns>
        public bool HasInheritedProperty(int property)
        {
            var status = NativeMethods.d2fobii_IspropInherited(NdapiContext.Context, _handle, property);
            Ensure.BooleanResult(status);

            return status == (int)D2fErrorCode.D2FS_YES;
        }

        /// <summary>
        /// Checks whether the property value was overriden.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>A boolean indicating whether property value was overriden.</returns>
        public bool HasOverriddenProperty(int property)
        {
            return !HasDefaultedProperty(property);
        }

        /// <summary>
        /// Gets the state of the specified property.
        /// </summary>
        /// <param name="property">Property id.</param>
        /// <returns>The property state.</returns>
        public PropertyState GetPropertyState(int property)
        {
            var state = PropertyState.Unknown;
            if (HasInheritedProperty(property))
            {
                state = PropertyState.Inherited;
            }
            else if (HasDefaultedProperty(property))
            {
                state = PropertyState.Default;
            }
            else
            {
                state = IsSubclassed ? PropertyState.OverriddenInherited : PropertyState.OverriddenDefault;
            }
            return state;
        }

        /// <summary>
        /// Reattaches subclassed object.
        /// </summary>
        /// <remarks>
        /// This method must be called if you changed one of the following properties:
        /// <see cref="ParentFileName"/>, <see cref="ParentFileNamePath"/>, <see cref="ParentModule"/>, <see cref="ParentModuleStorage"/>,
        /// <see cref="ParentModuleType"/>, <see cref="ParentName"/> or <see cref="ParentType"/>.
        /// </remarks>
        public void Reattach()
        {
            var status = NativeMethods.d2fobra_Reattach(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Change the subclassing parent of an object to the parent object.
        /// This will cause the property values to be overriden for all properties which are defined on the parent object.
        /// </summary>
        /// <param name="parent">Object to subclass.</param>
        /// <param name="keepPath">Indicates whether the system should refer to the parent object's module by filename or by path+filename.
        /// The recommended choice is false in most cases.</param>
        public void Subclass(BaseNdapiObject parent, bool keepPath = false)
        {
            var status = NativeMethods.d2fobsc_SubClass(NdapiContext.Context, _handle, parent._handle, keepPath);
            Ensure.Success(status);
        }

        /// <summary>
        /// Destroy the current object.
        /// </summary>
        public void Destroy()
        {
            var status = NativeMethods.d2fobde_Destroy(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }

        internal static T Create<T>(ObjectSafeHandle handle)
        {
            Type objectType = typeof(T);
            if (objectType == typeof(BaseNdapiObject))
            {
                ObjectType type;
                var status = NativeMethods.d2fobqt_QueryType(NdapiContext.Context, handle, out type);
                Ensure.Success(status);

                objectType = NdapiMetadata.ObjectTypeMapping[type];
            }

            var instance = Activator.CreateInstance(objectType,
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                new[] { handle },
                null);
            return (T)instance;
        }

        /// <summary>
        /// Gets the object name.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Name;
    }
}