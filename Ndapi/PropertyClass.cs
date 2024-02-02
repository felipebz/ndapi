using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represent a property class.
/// </summary>
public class PropertyClass : NdapiObject<PropertyClass>
{
    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="module">Property class owner.</param>
    /// <param name="name">Property class name.</param>
    public PropertyClass(FormModule module, string name) : base(name, ObjectType.PropertyClass, module)
    {
    }

    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="module">Property class owner.</param>
    /// <param name="name">Property class name.</param>
    public PropertyClass(MenuModule module, string name) : base(name, ObjectType.PropertyClass, module)
    {
    }

    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="group">Property class owner.</param>
    /// <param name="name">Property class name.</param>
    public PropertyClass(ObjectGroup group, string name) : base(name, ObjectType.PropertyClass, group)
    {
    }

    /// <summary>
    /// Creates a property class.
    /// </summary>
    /// <param name="library">Property class owner.</param>
    /// <param name="name">Property class name.</param>
    public PropertyClass(LibraryModule library, string name) : base(name, ObjectType.PropertyClass, library)
    {
    }

    internal PropertyClass(ObjectSafeHandle handle) : base(handle, ObjectType.PropertyClass)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets all the triggers attached to this property class.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public NdapiObjectList<Trigger> Triggers =>
        GetObjectList<Trigger>(NdapiConstant.D2FP_TRIGGER);

    /// <summary>
    /// Remove the specified property from the property class.
    /// </summary>
    /// <param name="propertyId">Property id (see <see cref="NdapiConstant"/>).</param>
    public void RemoveProperty(int propertyId)
    {
        var status = NativeMethods.d2fppcrp_RemoveProp(NdapiContext.GetContext(), Handle, propertyId);
        Ensure.Success(status);
    }

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="name">Name of the trigger.</param>
    /// <returns>The child object.</returns>
    public Trigger CreateTrigger(string name) => new(this, name);
}
