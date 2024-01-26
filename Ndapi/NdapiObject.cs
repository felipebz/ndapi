using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Metadata;

namespace Ndapi;

/// <summary>
/// Represents a generic object.
/// </summary>
public abstract class NdapiObject : IDisposable
{
    internal ObjectSafeHandle _handle;
    private ObjectType _type;

    internal NdapiObject()
    {
        _type = ObjectType.Undefined;
    }

    internal NdapiObject(ObjectType type)
    {
        _type = type;
    }

    internal NdapiObject(string name, ObjectType type, NdapiObject parent = null)
    {
        var parentHandle = parent?._handle ?? new ObjectSafeHandle();
        var status = NativeMethods.d2fobcr_Create(NdapiContext.GetContext(), parentHandle, out _handle, name,
            ConstantConverter.GetValue(type));
        Ensure.Success(status);
        _type = type;
    }

    internal NdapiObject(ObjectSafeHandle handle, ObjectType type)
    {
        _handle = handle;
        _type = type;
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [Property(NdapiConstant.D2FP_NAME)]
    public virtual string Name
    {
        get => GetStringProperty(NdapiConstant.D2FP_NAME);
        set => SetStringProperty(NdapiConstant.D2FP_NAME, value);
    }

    /// <summary>
    /// Gets or sets the parent type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_TYP)]
    public int ParentType
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PAR_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_PAR_TYP, value);
    }

    /// <summary>
    /// Gets or sets the parent name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_NAM)]
    public string ParentName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PAR_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PAR_NAM, value);
    }

    /// <summary>
    /// Gets or sets the parent module.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_MODULE)]
    public string ParentModule
    {
        get => GetStringProperty(NdapiConstant.D2FP_PAR_MODULE);
        set => SetStringProperty(NdapiConstant.D2FP_PAR_MODULE, value);
    }

    /// <summary>
    /// Gets or sets the parent module type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_MODTYP)]
    public int ParentModuleType
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PAR_MODTYP);
        set => SetNumberProperty(NdapiConstant.D2FP_PAR_MODTYP, value);
    }

    /// <summary>
    /// Gets or sets the parent module storage.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_MODSTR)]
    public ModuleStorageType ParentModuleStorage
    {
        get => GetNumberProperty<ModuleStorageType>(NdapiConstant.D2FP_PAR_MODSTR);
        set => SetNumberProperty(NdapiConstant.D2FP_PAR_MODSTR, value);
    }

    /// <summary>
    /// Gets or sets the parent filename path.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_FLPATH)]
    public string ParentFileNamePath
    {
        get => GetStringProperty(NdapiConstant.D2FP_PAR_FLPATH);
        set => SetStringProperty(NdapiConstant.D2FP_PAR_FLPATH, value);
    }

    /// <summary>
    /// Gets or sets the parent filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_FLNAM)]
    public string ParentFileName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PAR_FLNAM);
        set => SetStringProperty(NdapiConstant.D2FP_PAR_FLNAM, value);
    }

    /// <summary>
    /// Gets or sets the object owner.
    /// </summary>
    [Property(NdapiConstant.D2FP_OWNER)]
    public NdapiObject Owner => GetObjectProperty<NdapiObject>(NdapiConstant.D2FP_OWNER);

    /// <summary>
    /// Gets whether item is subclassed.
    /// </summary>
    public bool IsSubclassed
    {
        get
        {
            var status = NativeMethods.d2fobis_IsSubclassed(NdapiContext.GetContext(), _handle);
            Ensure.BooleanResult(status);
            return status == D2fErrorCode.D2FS_YES;
        }
    }

    /// <summary>
    /// Gets a <see cref="NdapiMetaObject"/> instance for the object type.
    /// </summary>
    public NdapiMetaObject MetaObject => NdapiMetadata.GetMetaObjectFrom(NdapiMetadata.GetTypeFrom(_type));

    /// <summary>
    /// Gets a list of the available properties for the object type.
    /// </summary>
    public IEnumerable<NdapiMetaProperty> MetaProperties => MetaObject.AllProperties;

    internal T GetPrevious<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>()
        where T : NdapiObject =>
        GetObjectProperty<T>(NdapiConstant.D2FP_PREVIOUS);

    internal T GetNext<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>()
        where T : NdapiObject =>
        GetObjectProperty<T>(NdapiConstant.D2FP_NEXT);

    /// <summary>
    /// Gets the value of a string property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property value.</returns>
    public string GetStringProperty(NdapiConstant property)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobgt_GetTextProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), out var value);
        Ensure.Success(status);
        return value;
    }

    /// <summary>
    /// Sets the value of a string property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <param name="value">Property value</param>
    public void SetStringProperty(NdapiConstant property, string value)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobst_SetTextProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), value);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the value of a number property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property value.</returns>
    public int GetNumberProperty(NdapiConstant property)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobgn_GetNumProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), out var value);
        Ensure.Success(status);
        return value;
    }

    /// <summary>
    /// Gets the value of a number property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property value.</returns>
    public T GetNumberProperty<T>(NdapiConstant property)
        where T : struct, Enum
    {
        var realValue = GetNumberProperty(property);
        return Convert<T>(realValue);
    }

    internal static T Convert<T>(int realValue)
        where T : struct, Enum
    {
        return Enum.GetValues<T>()
            .First(x => ConstantConverter.IsPropertySupportedByBuilderVersion(x) &&
                        ConstantConverter.GetValue(x) == realValue);
    }

    /// <summary>
    /// Sets the value of a number property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <param name="value">Property value</param>
    public void SetNumberProperty(NdapiConstant property, int value)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobsn_SetNumProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), value);
        Ensure.Success(status);
    }

    /// <summary>
    /// Sets the value of a number property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <param name="value">Property value</param>
    public void SetNumberProperty<T>(NdapiConstant property, T value) where T : struct, Enum
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        Ensure.IsValueSupportedByBuilderVersion(property, value);
        var realValueId = ConstantConverter.GetValue(value);

        SetNumberProperty(property, realValueId);
    }

    /// <summary>
    /// Gets the value of a boolean property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property value.</returns>
    public bool GetBooleanProperty(NdapiConstant property)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobgb_GetBoolProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), out var value);
        Ensure.Success(status);
        return value;
    }

    /// <summary>
    /// Sets the value of a boolean property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <param name="value">Property value</param>
    public void SetBooleanProperty(NdapiConstant property, bool value)
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobsb_SetBoolProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), value);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the value of an object property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property value.</returns>
    public T GetObjectProperty<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(
        NdapiConstant property) where T : NdapiObject
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobgo_GetObjProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), out var handle);
        Ensure.Success(status);

        return handle.IsInvalid ? null : Create<T>(handle);
    }

    /// <summary>
    /// Sets the value of an object property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <param name="value">Property value</param>
    public void SetObjectProperty<T>(NdapiConstant property, T value) where T : NdapiObject
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
        var status = NativeMethods.d2fobso_SetObjProp(NdapiContext.GetContext(), _handle,
            ConstantConverter.GetValue(property), value._handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets a list of child objects.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>List of child objects.</returns>
    public NdapiObjectList<T> GetObjectList<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)]
    T>(NdapiConstant property)
        where T : NdapiObject
    {
        Ensure.IsPropertySupportedByBuilderVersion(property);
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

        var status = NativeMethods.d2fobqt_QueryType(NdapiContext.GetContext(), _handle, out var type);
        Ensure.Success(status);
        _type = Convert<ObjectType>(type);

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
        while ((owner != null) && (includeModule || (owner.GetObjectType() != ObjectType.FormModule)))
        {
            builder.Insert(0, ".");
            builder.Insert(0, owner.Name);
            owner = (owner is NdapiModule)
                ? null
                : owner.Owner; // if owner is a module, the Owner property returns a Point object (?)
        }

        builder.Append(Name);
        return builder.ToString();
    }

    /// <summary>
    /// Checks whether the object has the specified property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>A boolean indicating whether item has the property.</returns>
    public bool HasProperty(NdapiConstant property)
    {
        var status = NativeMethods.d2fobhp_HasProp(NdapiContext.GetContext(), _handle, ConstantConverter.GetValue(property));
        Ensure.BooleanResult(status);

        return status == D2fErrorCode.D2FS_YES;
    }

    /// <summary>
    /// Inherits a property from the parent.
    /// </summary>
    /// <param name="property"></param>
    public void InheritProperty(NdapiConstant property)
    {
        var status = NativeMethods.d2fobip_InheritProp(NdapiContext.GetContext(), _handle, ConstantConverter.GetValue(property));
        Ensure.Success(status);
    }

    internal D2fErrorCode IsPropertyDefaulted(NdapiConstant property)
    {
        return NativeMethods.d2fobid_IspropDefault(NdapiContext.GetContext(), _handle, ConstantConverter.GetValue(property));
    }

    /// <summary>
    /// Checks whether the property has its default value.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>A boolean indicating whether property has its default value. If the object doesn't have the property, returns false.</returns>
    public bool HasDefaultedProperty(NdapiConstant property)
    {
        var status = IsPropertyDefaulted(property);
        if (status == D2fErrorCode.D2FS_DONTHAVE)
        {
            return false;
        }

        Ensure.BooleanResult(status);
        return status == D2fErrorCode.D2FS_YES;
    }

    /// <summary>
    /// Checks whether the property value was overriden.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>A boolean indicating whether property value was overriden. If the object doesn't have the property, returns false.</returns>
    public bool HasOverriddenProperty(NdapiConstant property)
    {
        var status = IsPropertyDefaulted(property);
        if (status == D2fErrorCode.D2FS_DONTHAVE)
        {
            return false;
        }

        Ensure.BooleanResult(status);
        return status == D2fErrorCode.D2FS_NO;
    }

    /// <summary>
    /// Checks whether the property was inherited.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>A boolean indicating whether property was inherited.</returns>
    public bool HasInheritedProperty(NdapiConstant property)
    {
        var status = NativeMethods.d2fobii_IspropInherited(NdapiContext.GetContext(), _handle, ConstantConverter.GetValue(property));
        Ensure.BooleanResult(status);

        return status == D2fErrorCode.D2FS_YES;
    }

    /// <summary>
    /// Gets the state of the specified property.
    /// </summary>
    /// <param name="property">Property id.</param>
    /// <returns>The property state.</returns>
    public PropertyState GetPropertyState(NdapiConstant property)
    {
        PropertyState state;
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
    /// <see cref="ParentFileName"/>, <see cref="ParentFileNamePath"/>, <see cref="ParentModule"/>,
    /// <see cref="ParentModuleType"/>, <see cref="ParentName"/> or <see cref="ParentType"/>.
    /// </remarks>
    public void Reattach()
    {
        var status = NativeMethods.d2fobra_Reattach(NdapiContext.GetContext(), _handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Change the subclassing parent of an object to the parent object.
    /// This will cause the property values to be overriden for all properties which are defined on the parent object.
    /// </summary>
    /// <param name="parent">Object to subclass.</param>
    /// <param name="keepPath">Indicates whether the system should refer to the parent object's module by filename or by path+filename.
    /// The recommended choice is false in most cases.</param>
    public void Subclass(NdapiObject parent, bool keepPath = false)
    {
        var status = NativeMethods.d2fobsc_SubClass(NdapiContext.GetContext(), _handle, parent._handle, keepPath);
        Ensure.Success(status);
    }

    public NdapiObject Find(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)]
        Type type,
        string name)
    {
        var objectType = NdapiMetadata.GetObjectTypeFrom(type);
        var internalObjectType = ConstantConverter.GetValue(objectType);

        var status = NativeMethods.d2fobfo_FindObj(NdapiContext.GetContext(), _handle, name, internalObjectType,
            out ObjectSafeHandle handle);
        if (status == D2fErrorCode.D2FS_OBJNOTFOUND)
        {
            return null;
        }

        Ensure.Success(status);

        return Create(type, handle);
    }

    /// <summary>
    /// Destroy the current object.
    /// </summary>
    public virtual void Destroy()
    {
        var status = NativeMethods.d2fobde_Destroy(NdapiContext.GetContext(), _handle);
        Ensure.Success(status);
    }

    internal static NdapiObject Create(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)]
        Type type,
        ObjectSafeHandle handle)
    {
        var foundType = type;
        if (foundType == typeof(NdapiObject))
        {
            var status = NativeMethods.d2fobqt_QueryType(NdapiContext.GetContext(), handle, out var internalObjectType);
            Ensure.Success(status);

            var objectType = Convert<ObjectType>(internalObjectType);

            if (objectType == ObjectType.Undefined)
            {
                return null;
            }

            foundType = NdapiMetadata.GetTypeFrom(objectType);
        }

        var instance = Activator.CreateInstance(foundType,
            BindingFlags.NonPublic | BindingFlags.Instance,
            null,
            [handle],
            null);
        return (NdapiObject)instance;
    }

    internal static T
        Create<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(
            ObjectSafeHandle handle) where T : NdapiObject
    {
        return (T)Create(typeof(T), handle);
    }

    /// <summary>
    /// Gets the object name.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => Name;

    #region IDisposable Support

    private bool disposedValue; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (disposedValue)
        {
            return;
        }

        if (disposing)
        {
            _handle?.Dispose();
        }

        disposedValue = true;
    }

    public void Dispose()
    {
        Dispose(true);
    }

    #endregion
}

/// <summary>
/// Represents a generic object.
/// </summary>
public abstract class
    NdapiObject<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T> : NdapiObject
    where T : NdapiObject
{
    internal NdapiObject() { }
    internal NdapiObject(ObjectType type) : base(type) { }
    internal NdapiObject(string name, ObjectType type, NdapiObject parent = null) : base(name, type, parent) { }
    internal NdapiObject(ObjectSafeHandle handle, ObjectType type) : base(handle, type) { }

    /// <summary>
    /// Get the previous object.
    /// </summary>
    public T Previous => GetPrevious<T>();

    /// <summary>
    /// Get the next object.
    /// </summary>
    public T Next => GetNext<T>();

    /// <summary>
    /// Creates a new object with the given name and owner.
    /// The new object is an exact copy of the original object, with all the same property values.
    /// </summary>
    /// <param name="newName">Name of the new object.</param>
    /// <param name="newOwner">New owner of the object. If null, the object will be owned by the same parent of the current object.</param>
    /// <param name="keepSubclassingInfo">If false, the sublassing info is discarded and the inherited properties are flattened into local values in the new object.</param>
    /// <returns>The new object.</returns>
    public T Clone(string newName, NdapiObject newOwner = null, bool keepSubclassingInfo = true)
    {
        var parentHandle = newOwner?._handle ?? Owner._handle;

        var status = keepSubclassingInfo
            ? NativeMethods.d2fobre_Replicate(NdapiContext.GetContext(), parentHandle, _handle, out var newHandle,
                newName)
            : NativeMethods.d2fobdu_Duplicate(NdapiContext.GetContext(), parentHandle, _handle, out newHandle, newName);
        Ensure.Success(status);

        return Create<T>(newHandle);
    }

    /// <summary>
    /// Change the order of the object relative to its siblings. This is similar to a drag-and-drop operation in
    /// the Form Builder. The object will be moved before the specified object, retaining the same owner. You cannot use
    /// this method to move objects between parents.
    /// </summary>
    /// <param name="nextObject">The next object instance. If null, the object will be moved to the end of the list.</param>
    public void Move(T nextObject)
    {
        var nextHandle = nextObject?._handle ?? new ObjectSafeHandle();
        var status = NativeMethods.d2fobmv_Move(NdapiContext.GetContext(), _handle, nextHandle);
        Ensure.Success(status);
    }
}
