﻿using System.Diagnostics.CodeAnalysis;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represent an object library tab.
/// </summary>
public partial class ObjectLibraryTab : NdapiObject<ObjectLibraryTab>
{
    /// <summary>
    /// Creates an object library tab..
    /// </summary>
    /// <param name="library">Object library.</param>
    /// <param name="name">Tab name.</param>
    public ObjectLibraryTab(ObjectLibrary library, string name) : base(name, ObjectType.ObjectLibraryTab, library)
    {
        ObjectLibrary = library;
    }

    internal ObjectLibraryTab(ObjectSafeHandle handle) : base(handle, ObjectType.ObjectLibraryTab)
    {
    }

    /// <summary>
    /// Get the object library that owns the current tab.
    /// </summary>
    public ObjectLibrary ObjectLibrary { get; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string Label { get; set; }

    /// <summary>
    /// Gets all the objects contained in this tab.
    /// </summary>
    public NdapiObjectLibraryTabObjectsList Objects => new(this);

    /// <summary>
    /// Get the object in the specified position.
    /// </summary>
    /// <param name="position">Position.</param>
    /// <returns>The object found.</returns>
    public NdapiObject GetObjectByPosition(int position)
    {
        var status = NativeMethods.d2foltf2_Findobjbypos(NdapiContext.GetContext(), Handle, position, out var obj);
        Ensure.Success(status);

        return obj.IsInvalid ? null : Create<NdapiObject>(obj);
    }

    /// <summary>
    /// Add an object to the object library tab. When adding an object, a copy is made and it is this copy that is added to the library.
    /// </summary>
    /// <typeparam name="T">Object type.</typeparam>
    /// <param name="obj">Object to add to library tab.</param>
    /// <param name="replace">Should replace the existing object.</param>
    /// <returns>A copy of the original object.</returns>
    public T AddObject<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(T obj, bool replace = false) where T : NdapiObject
    {
        var status = NativeMethods.d2folbao_AddObj(NdapiContext.GetContext(), ObjectLibrary.Handle, Handle, obj.Handle, out var handle, replace);
        Ensure.Success(status);
        return Create<T>(handle);
    }
}
