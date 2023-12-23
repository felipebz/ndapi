using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu object.
/// </summary>
public class Menu : NdapiObject<Menu>
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

    internal Menu(ObjectSafeHandle handle) : base(handle)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstants.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstants.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstants.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the subtitle.
    /// </summary>
    [Property(NdapiConstants.D2FP_SUB_TTL)]
    public string Subtitle
    {
        get => GetStringProperty(NdapiConstants.D2FP_SUB_TTL);
        set => SetStringProperty(NdapiConstants.D2FP_SUB_TTL, value);
    }

    /// <summary>
    /// Gets or sets whether the menu is a tear-off menu.
    /// </summary>
    [Property(NdapiConstants.D2FP_TEAR_OFF_MNU)]
    public bool IsTearOffMenu
    {
        get => GetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU);
        set => SetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU, value);
    }

    /// <summary>
    /// Gets the menu items.
    /// </summary>
    [Property(NdapiConstants.D2FP_MNU_ITM)]
    public NdapiObjectList<MenuItem> MenuItems => GetObjectList<MenuItem>(NdapiConstants.D2FP_MNU_ITM);

    /// <summary>
    /// Creates a menu item.
    /// </summary>
    /// <param name="name">Name of the menu item.</param>
    /// <returns>The child object.</returns>
    public MenuItem CreateMenuItem(string name) => new(this, name);
}