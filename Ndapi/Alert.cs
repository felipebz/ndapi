using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class Alert : NdapiObject
    {
        public Alert()
        {
        }

        public Alert(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_ALERT, module);
        }

        internal Alert(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Message
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ALT_MSG); }
            set { SetStringProperty(NdapiConstants.D2FP_ALT_MSG, value); }
        }

        public AlertStyle AlertStyle
        {
            get { return GetNumberProperty<AlertStyle>(NdapiConstants.D2FP_ALT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_ALT_STY, value); }
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        public string Button1Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_1_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_1_LBL, value); }
        }

        public string Button2Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_2_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_2_LBL, value); }
        }

        public string Button3Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_3_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_3_LBL, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public AlertButton DefaultAlertButton
        {
            get { return GetNumberProperty<AlertButton>(NdapiConstants.D2FP_DFLT_ALT_BTN); }
            set { SetNumberProperty(NdapiConstants.D2FP_DFLT_ALT_BTN, value); }
        }

        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
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

        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
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

        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }

        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }
    }
}