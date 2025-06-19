using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu item.
/// </summary>
public partial class MenuItem : NdapiObject<MenuItem>
{
    /// <summary>
    /// Creates a menu item.
    /// </summary>
    /// <param name="menu">Menu item owner.</param>
    /// <param name="name">Menu item name.</param>
    public MenuItem(Menu menu, string name) : base(name, ObjectType.MenuItem, menu)
    {
    }

    /// <summary>
    /// Creates a menu item.
    /// </summary>
    /// <param name="group">Menu item owner.</param>
    /// <param name="name">Menu item name.</param>
    public MenuItem(ObjectGroup group, string name) : base(name, ObjectType.MenuItem, group)
    {
    }

    internal MenuItem(ObjectSafeHandle handle) : base(handle, ObjectType.MenuItem)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the command text.
    /// </summary>
    [Property(NdapiConstant.D2FP_COM_TXT)]
    public partial string CommandText { get; set; }

    /// <summary>
    /// Gets or sets the command type.
    /// </summary>
    [Property(NdapiConstant.D2FP_COM_TYP)]
    public partial MenuCommandType CommandType { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is displayed when the user is not a member of a security role that has access privileges to the item.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_NO_PRIV)]
    public partial bool DisplayWithoutPrivilege { get; set; }

    /// <summary>
    /// Gets or sets whether menu item is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public partial bool IsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public partial string FontName { get; set; }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public partial int FontSize { get; set; }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public partial int FontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public partial FontStyle FontStyle { get; set; }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public partial FontWeight FontWeight { get; set; }

    /// <summary>
    /// Gets or sets the hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT)]
    public partial string Hint { get; set; }

    /// <summary>
    /// Gets or sets the help text.
    /// </summary>
    [Property(NdapiConstant.D2FP_HLP_DESCRIPTION)]
    public partial string Help { get; set; }

    /// <summary>
    /// Gets or sets the icon filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public partial string IconFilename { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is iconic.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_IN_MNU)]
    public partial bool IsIconic { get; set; }

    /// <summary>
    /// Gets or sets the keyboard accelerator.
    /// </summary>
    [Property(NdapiConstant.D2FP_KBRD_ACC)]
    public partial string KeyboardAccelerator { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string Label { get; set; }

    /// <summary>
    /// Gets or sets the magic menu item type.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAGIC_ITM)]
    public partial MagicMenuItemType MagicItemType { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ITM_CODE)]
    public partial string Code { get; set; }

    /// <summary>
    /// Gets or sets the menu item radio group.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ITM_RAD_GRP)]
    public partial string MenuItemRadioGroup { get; set; }

    /// <summary>
    /// Gets or sets the menu item type.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_ITM_TYP)]
    public partial MenuItemType MenuItemType { get; set; }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public partial string VisualAttributeName { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public partial bool IsVisible { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is visible in the horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VSBL_IN_HORZ_MNU_TLBR)]
    public partial bool IsVisibleInHorizontalToolbar { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is visible in menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_VSBL_IN_MENU)]
    public partial bool IsVisibleInMenu { get; set; }

    /// <summary>
    /// Gets or sets whether the menu item is visible in the vertical toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_VSBL_IN_VERT_MNU_TLBR)]
    public partial bool IsVisibleInVerticalToolbar { get; set; }

    /// <summary>
    /// Gets the menu item roles.
    /// </summary>
    public IEnumerable<string> Roles => new NdapiMenuItemRoleList(this);

    /// <summary>
    /// Compile PL/SQL code in the menu item.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2fmnico_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Inserts a role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which role should be inserted.</param>
    /// <param name="role">Role name.</param>
    public void AddRoleAt(int index, string role)
    {
        var status = NativeMethods.d2fmniar_AddRole(NdapiContext.GetContext(), Handle, index, role);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which role should be removed.</param>
    public void DeleteRoleAt(int index)
    {
        var status = NativeMethods.d2fmnirr_RemoveRole(NdapiContext.GetContext(), Handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the role in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the role.</param>
    /// <returns>The role name.</returns>
    public string GetRoleAt(int index)
    {
        var status = NativeMethods.d2fmnigr_GetRole(NdapiContext.GetContext(), Handle, index, out var role);
        Ensure.Success(status);
        return role;
    }
}
