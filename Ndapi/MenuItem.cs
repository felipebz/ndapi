using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a menu item.
    /// </summary>
    public class MenuItem : NdapiObject
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

        /// <summary>
        /// Creates a menu item.
        /// </summary>
        /// <param name="library">Menu item owner.</param>
        /// <param name="name">Menu item name.</param>
        public MenuItem(ObjectLibrary library, string name) : base(name, ObjectType.MenuItem, library)
        {
        }

        internal MenuItem(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        public string CommandText
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COM_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_COM_TXT, value); }
        }

        /// <summary>
        /// Gets or sets the command type.
        /// </summary>
        public MenuCommandType CommandType
        {
            get { return GetNumberProperty<MenuCommandType>(NdapiConstants.D2FP_COM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_COM_TYP, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is displayed when the user is not a member of a security role that has access privileges to the item.
        /// </summary>
        public bool DisplayWithoutPrivilege
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV, value); }
        }

        /// <summary>
        /// Gets or sets whether menu item is enabled.
        /// </summary>
        public bool Enabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        public int FontSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the hint.
        /// </summary>
        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        public string Help
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION); }
            set { SetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION, value); }
        }

        /// <summary>
        /// Gets or sets the icon filename.
        /// </summary>
        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is iconic.
        /// </summary>
        public bool Iconic
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU, value); }
        }

        /// <summary>
        /// Gets or sets the keyboard accelerator.
        /// </summary>
        public string KeyboardAccelerator
        {
            get { return GetStringProperty(NdapiConstants.D2FP_KBRD_ACC); }
            set { SetStringProperty(NdapiConstants.D2FP_KBRD_ACC, value); }
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets or sets the magic menu item type.
        /// </summary>
        public MagicMenuItemType MagicItemType
        {
            get { return GetNumberProperty<MagicMenuItemType>(NdapiConstants.D2FP_MAGIC_ITM); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAGIC_ITM, value); }
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE, value); }
        }

        /// <summary>
        /// Gets or sets the menu item radio group.
        /// </summary>
        public string MenuItemRadioGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP, value); }
        }

        /// <summary>
        /// Gets or sets the menu item type.
        /// </summary>
        public MenuItemType MenuItemType
        {
            get { return GetNumberProperty<MenuItemType>(NdapiConstants.D2FP_MNU_ITM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_ITM_TYP, value); }
        }

        /// <summary>
        /// Gets the role count.
        /// </summary>
        public int RoleCount => GetNumberProperty(NdapiConstants.D2FP_ROLE_COUNT);

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible.
        /// </summary>
        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in the horizontal toolbar.
        /// </summary>
        public bool VisibleInHorizontalToolbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in menu.
        /// </summary>
        public bool VisibleInMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU, value); }
        }

        /// <summary>
        /// Gets or sets whether the menu item is visible in the vertical toolbar.
        /// </summary>
        public bool VisibleInVerticalToolbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR, value); }
        }

    }
}
