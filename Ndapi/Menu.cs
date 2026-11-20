using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu object.
/// </summary>
public partial class Menu : NdapiObject<Menu>
{
    /// <summary>
    /// Creates a new menu.
    /// </summary>
    /// <param name="module">Menu owner.</param>
    /// <param name="name">Menu name</param>
    public Menu(FormModule module, string name) : base(name, ObjectType.Menu, module)
    {
    }

    /// <summary>
    /// Creates a new menu.
    /// </summary>
    /// <param name="module">Menu owner.</param>
    /// <param name="name">Menu name</param>
    public Menu(MenuModule module, string name) : base(name, ObjectType.Menu, module)
    {
    }

    internal Menu(ObjectSafeHandle handle) : base(handle, ObjectType.Menu)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the subtitle.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUB_TTL)]
    public partial string Subtitle { get; set; }

    /// <summary>
    /// Gets or sets whether the menu is a tear-off menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_TEAR_OFF_MNU)]
    public partial bool IsTearOffMenu { get; set; }

    /// <summary>
    /// Gets the menu items.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ITM)]
    public partial NdapiObjectList<MenuItem> MenuItems { get; }

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
    /// Creates a menu item.
    /// </summary>
    /// <param name="name">Name of the menu item.</param>
    /// <returns>The child object.</returns>
    public MenuItem CreateMenuItem(string name) => new(this, name);
}
