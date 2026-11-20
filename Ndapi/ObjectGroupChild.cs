using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an object group child. Every object must be wrapped in an "object group child" to add it
/// in an object group.
/// </summary>
public partial class ObjectGroupChild : NdapiObject<ObjectGroupChild>
{
    /// <summary>
    /// Creates an object group child.
    /// </summary>
    /// <param name="group">Object owner.</param>
    /// <param name="name">Object name.</param>
    public ObjectGroupChild(ObjectGroup group, string name) : base(name, ObjectType.ObjectGroupChild, group)
    {
    }

    internal ObjectGroupChild(ObjectSafeHandle handle) : base(handle, ObjectType.ObjectGroupChild)
    {
    }

    /// <summary>
    /// Gets or sets the real object.
    /// </summary>
    [Property(NdapiConstant.D2FP_OBJ_GRP_CHILD_REAL_OBJ)]
    public partial NdapiObject? RealObject { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject? Source { get; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as a sub-object of a subclassed parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_SUBOBJ)]
    public partial bool IsSubclassSubObject { get; set; }
}
