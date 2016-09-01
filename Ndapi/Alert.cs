using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents an alert object.
    /// </summary>
    public class Alert : NdapiObject<Alert>
    {
        /// <summary>
        /// Creates an alert object.
        /// </summary>
        /// <param name="module">Alert owner.</param>
        /// <param name="name">Alert name.</param>
        public Alert(FormModule module, string name) : base(name, ObjectType.Alert, module)
        {
        }

        /// <summary>
        /// Creates an alert object.
        /// </summary>
        /// <param name="group">Alert owner.</param>
        /// <param name="name">Alert name.</param>
        public Alert(ObjectGroup group, string name) : base(name, ObjectType.Alert, group)
        {
        }

        internal Alert(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Property(NdapiConstants.D2FP_ALT_MSG)]
        public string Message
        {
            get { return GetStringProperty(NdapiConstants.D2FP_ALT_MSG); }
            set { SetStringProperty(NdapiConstants.D2FP_ALT_MSG, value); }
        }

        /// <summary>
        /// Gets or sets the alert style.
        /// </summary>
        [Property(NdapiConstants.D2FP_ALT_STY)]
        public AlertStyle AlertStyle
        {
            get { return GetNumberProperty<AlertStyle>(NdapiConstants.D2FP_ALT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_ALT_STY, value); }
        }


        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        [Property(NdapiConstants.D2FP_BACK_COLOR)]
        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the first button label.
        /// </summary>
        [Property(NdapiConstants.D2FP_BTN_1_LBL)]
        public string Button1Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_1_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_1_LBL, value); }
        }

        /// <summary>
        /// Gets or sets the second button label.
        /// </summary>
        [Property(NdapiConstants.D2FP_BTN_2_LBL)]
        public string Button2Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_2_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_2_LBL, value); }
        }

        /// <summary>
        /// Gets or sets the third button label.
        /// </summary>
        [Property(NdapiConstants.D2FP_BTN_3_LBL)]
        public string Button3Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTN_3_LBL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTN_3_LBL, value); }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the default alert button.
        /// </summary>
        [Property(NdapiConstants.D2FP_DFLT_ALT_BTN)]
        public AlertButton DefaultAlertButton
        {
            get { return GetNumberProperty<AlertButton>(NdapiConstants.D2FP_DFLT_ALT_BTN); }
            set { SetNumberProperty(NdapiConstants.D2FP_DFLT_ALT_BTN, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        [Property(NdapiConstants.D2FP_FILL_PAT)]
        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_NAM)]
        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SIZ)]
        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SPCING)]
        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_STY)]
        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_WGHT)]
        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        [Property(NdapiConstants.D2FP_FORE_COLOR)]
        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        [Property(NdapiConstants.D2FP_LANG_DIR)]
        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [Property(NdapiConstants.D2FP_TITLE)]
        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }
    }
}