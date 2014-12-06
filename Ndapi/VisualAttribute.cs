using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class VisualAttribute : NdapiObject
    {
        public VisualAttribute(FormModule module, string name)
        {
            Create(name, ObjectType.VisualAttribute, module);
        }

        internal VisualAttribute(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
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

        public string PromptBackground
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR, value); }
        }

        public string PromptFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT, value); }
        }

        public string PromptFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM, value); }
        }

        public int PromptFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ, value); }
        }

        public FontSpacing PromptFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_PRMPT_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SPCING, value); }
        }

        public FontStyle PromptFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_PRMPT_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_STY, value); }
        }

        public FontWeight PromptFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_PRMPT_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_WGHT, value); }
        }

        public string PromptForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR, value); }
        }

        public VisualAttributeType Type
        {
            get { return GetNumberProperty<VisualAttributeType>(NdapiConstants.D2FP_VAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_VAT_TYP, value); }
        }

        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }
    }
}
