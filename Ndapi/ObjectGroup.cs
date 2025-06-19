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
    public partial NdapiObjectList<ObjectGroupChild> Childs { get; }

    /// <summary>
    /// Creates a object group child.
    /// </summary>
    /// <param name="name">Name of the object group child.</param>
    /// <returns>The child object.</returns>
    public ObjectGroupChild CreateObjectGroupChild(string name) => new(this, name);
}
