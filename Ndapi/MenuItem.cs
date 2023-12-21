using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a menu item.
    /// </summary>
    public class MenuItem : NdapiObject<MenuItem>
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

        internal MenuItem(ObjectSafeHandle handle) : base(handle)
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
        /// Gets or sets the command text.
        /// </summary>
        [Property(NdapiConstants.D2FP_COM_TXT)]
        public string CommandText
        {
            get => GetStringProperty(NdapiConstants.D2FP_COM_TXT);
            set => SetStringProperty(NdapiConstants.D2FP_COM_TXT, value);
        }

        /// <summary>
        /// Gets or sets the command type.
        /// </summary>
        [Property(NdapiConstants.D2FP_COM_TYP)]
        public MenuCommandType CommandType
        {
            get => GetNumberProperty<MenuCommandType>(NdapiConstants.D2FP_COM_TYP);
            set => SetNumberProperty(NdapiConstants.D2FP_COM_TYP, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is displayed when the user is not a member of a security role that has access privileges to the item.
        /// </summary>
        [Property(NdapiConstants.D2FP_DISP_NO_PRIV)]
        public bool DisplayWithoutPrivilege
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV);
            set => SetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV, value);
        }

        /// <summary>
        /// Gets or sets whether menu item is enabled.
        /// </summary>
        [Property(NdapiConstants.D2FP_ENABLED)]
        public bool IsEnabled
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_ENABLED);
            set => SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value);
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_NAM)]
        public string FontName
        {
            get => GetStringProperty(NdapiConstants.D2FP_FONT_NAM);
            set => SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value);
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SIZ)]
        public int FontSize
        {
            get => GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value);
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SPCING)]
        public int FontSpacing
        {
            get => GetNumberProperty(NdapiConstants.D2FP_FONT_SPCING);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value);
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_STY)]
        public FontStyle FontStyle
        {
            get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value);
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_WGHT)]
        public FontWeight FontWeight
        {
            get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value);
        }

        /// <summary>
        /// Gets or sets the hint.
        /// </summary>
        [Property(NdapiConstants.D2FP_HINT)]
        public string Hint
        {
            get => GetStringProperty(NdapiConstants.D2FP_HINT);
            set => SetStringProperty(NdapiConstants.D2FP_HINT, value);
        }

#if FORMS_6
        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        [Property(NdapiConstants.D2FP_HLP_DESCRIPTION)]
        public string Help
        {
            get => GetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION);
            set => SetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION, value);
        }
#endif

        /// <summary>
        /// Gets or sets the icon filename.
        /// </summary>
        [Property(NdapiConstants.D2FP_ICON_FLNAM)]
        public string IconFilename
        {
            get => GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM);
            set => SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is iconic.
        /// </summary>
        [Property(NdapiConstants.D2FP_ICON_IN_MNU)]
        public bool IsIconic
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU);
            set => SetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU, value);
        }

        /// <summary>
        /// Gets or sets the keyboard accelerator.
        /// </summary>
        [Property(NdapiConstants.D2FP_KBRD_ACC)]
        public string KeyboardAccelerator
        {
            get => GetStringProperty(NdapiConstants.D2FP_KBRD_ACC);
            set => SetStringProperty(NdapiConstants.D2FP_KBRD_ACC, value);
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [Property(NdapiConstants.D2FP_LABEL)]
        public string Label
        {
            get => GetStringProperty(NdapiConstants.D2FP_LABEL);
            set => SetStringProperty(NdapiConstants.D2FP_LABEL, value);
        }

        /// <summary>
        /// Gets or sets the magic menu item type.
        /// </summary>
        [Property(NdapiConstants.D2FP_MAGIC_ITM)]
        public MagicMenuItemType MagicItemType
        {
            get => GetNumberProperty<MagicMenuItemType>(NdapiConstants.D2FP_MAGIC_ITM);
            set => SetNumberProperty(NdapiConstants.D2FP_MAGIC_ITM, value);
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_ITM_CODE)]
        public string Code
        {
            get => GetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE);
            set => SetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE, value);
        }

        /// <summary>
        /// Gets or sets the menu item radio group.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_ITM_RAD_GRP)]
        public string MenuItemRadioGroup
        {
            get => GetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP);
            set => SetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP, value);
        }

        /// <summary>
        /// Gets or sets the menu item type.
        /// </summary>
        [Property(NdapiConstants.D2FP_MNU_ITM_TYP)]
        public MenuItemType MenuItemType
        {
            get => GetNumberProperty<MenuItemType>(NdapiConstants.D2FP_MNU_ITM_TYP);
            set => SetNumberProperty(NdapiConstants.D2FP_MNU_ITM_TYP, value);
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        [Property(NdapiConstants.D2FP_VAT_NAM)]
        public string VisualAttributeName
        {
            get => GetStringProperty(NdapiConstants.D2FP_VAT_NAM);
            set => SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible.
        /// </summary>
        [Property(NdapiConstants.D2FP_VISIBLE)]
        public bool IsVisible
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_VISIBLE);
            set => SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in the horizontal toolbar.
        /// </summary>
        [Property(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR)]
        public bool IsVisibleInHorizontalToolbar
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR);
            set => SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in menu.
        /// </summary>
        [Property(NdapiConstants.D2FP_VSBL_IN_MENU)]
        public bool IsVisibleInMenu
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU);
            set => SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU, value);
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in the vertical toolbar.
        /// </summary>
        [Property(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR)]
        public bool IsVisibleInVerticalToolbar
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR);
            set => SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR, value);
        }

        /// <summary>
        /// Gets the menu item roles.
        /// </summary>
        public IEnumerable<string> Roles => new NdapiMenuItemRoleList(this);

        /// <summary>
        /// Compile PL/SQL code in the menu item.
        /// </summary>
        public void Compile()
        {
            var status = NativeMethods.d2fmnico_CompileObj(NdapiContext.GetContext(), _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Inserts a role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which role should be inserted.</param>
        /// <param name="role">Role name.</param>
        public void AddRoleAt(int index, string role)
        {
            var status = NativeMethods.d2fmniar_AddRole(NdapiContext.GetContext(), _handle, index, role);
            Ensure.Success(status);
        }

        /// <summary>
        /// Deletes the role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index at which role should be removed.</param>
        public void DeleteRoleAt(int index)
        {
            var status = NativeMethods.d2fmnirr_RemoveRole(NdapiContext.GetContext(), _handle, index);
            Ensure.Success(status);
        }

        /// <summary>
        /// Gets the role in the specified index.
        /// </summary>
        /// <param name="index">The one-based index of the role.</param>
        /// <returns>The role name.</returns>
        public string GetRoleAt(int index)
        {
            string role;
            var status = NativeMethods.d2fmnigr_GetRole(NdapiContext.GetContext(), _handle, index, out role);
            Ensure.Success(status);
            return role;
        }
    }
}
