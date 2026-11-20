using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a group of objects.
/// </summary>
public partial class ObjectGroup : NdapiObject<ObjectGroup>
{
    /// <summary>
    /// Creates a object group.
    /// </summary>
    /// <param name="module">Object group owner.</param>
    /// <param name="name">Object group name.</param>
    public ObjectGroup(FormModule module, string name) : base(name, ObjectType.ObjectGroup, module)
    {
    }

    /// <summary>
    /// Creates a object group.
    /// </summary>
    /// <param name="module">Object group owner.</param>
    /// <param name="name">Object group name.</param>
    public ObjectGroup(MenuModule module, string name) : base(name, ObjectType.ObjectGroup, module)
    {
    }

    internal ObjectGroup(ObjectSafeHandle handle) : base(handle, ObjectType.ObjectGroup)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets the objects contained in the group.
    /// </summary>
    [Property(NdapiConstant.D2FP_OG_CHILD)]
    public partial NdapiObjectList<ObjectGroupChild> Children { get; }

    /// <summary>
    /// Gets or sets the object group type. Forms 12c and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_OBJ_GRP_TYP)]
    public partial int ObjectGroupType { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject Source { get; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as part of an object group.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_OBJGRP)]
    public partial bool IsSubclassObjectGroup { get; set; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as a sub-object of a subclassed parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_SUBOBJ)]
    public partial bool IsSubclassSubObject { get; set; }

    /// <summary>
    /// Creates a object group child.
    /// </summary>
    /// <param name="name">Name of the object group child.</param>
    /// <returns>The child object.</returns>
    public ObjectGroupChild CreateObjectGroupChild(string name) => new(this, name);
}
