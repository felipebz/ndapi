using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class MenuItem : NdapiObject
    {
        public MenuItem(FormModule module, string name)
        {
            Create(name, ObjectType.MenuItem, module);
        }

        internal MenuItem(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string CommandText
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COM_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_COM_TXT, value); }
        }

        public MenuCommandType CommandType
        {
            get { return GetNumberProperty<MenuCommandType>(NdapiConstants.D2FP_COM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_COM_TYP, value); }
        }

        public bool DisplayWithoutPrivilege
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DISP_NO_PRIV, value); }
        }

        public bool Enabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        public int FontSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        public string Hint
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HINT); }
            set { SetStringProperty(NdapiConstants.D2FP_HINT, value); }
        }

        public string Help
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION); }
            set { SetStringProperty(NdapiConstants.D2FP_HLP_DESCRIPTION, value); }
        }

        public string IconFilename
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ICON_FLNAM); }
            set { SetStringProperty(NdapiConstants.D2FP_ICON_FLNAM, value); }
        }

        public bool Iconic
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ICON_IN_MNU, value); }
        }

        public string KeyboardAccelerator
        {
            get { return GetStringProperty(NdapiConstants.D2FP_KBRD_ACC); }
            set { SetStringProperty(NdapiConstants.D2FP_KBRD_ACC, value); }
        }

        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        public MagicMenuItemType MagicItemType
        {
            get { return GetNumberProperty<MagicMenuItemType>(NdapiConstants.D2FP_MAGIC_ITM); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAGIC_ITM, value); }
        }

        public string Code
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ITM_CODE, value); }
        }

        public string MenuItemRadioGroup
        {
            get { return GetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP); }
            set { SetStringProperty(NdapiConstants.D2FP_MNU_ITM_RAD_GRP, value); }
        }

        public MenuItemType MenuItemType
        {
            get { return GetNumberProperty<MenuItemType>(NdapiConstants.D2FP_MNU_ITM_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_MNU_ITM_TYP, value); }
        }

        public int RoleCount => GetNumberProperty(NdapiConstants.D2FP_ROLE_COUNT);

        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        public bool VisibleInHorizontalToolbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_HORZ_MNU_TLBR, value); }
        }

        public bool VisibleInMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_MENU, value); }
        }

        public bool VisibleInVerticalToolbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VSBL_IN_VERT_MNU_TLBR, value); }
        }

    }
}
