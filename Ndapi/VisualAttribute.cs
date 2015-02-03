using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a visual attribute.
    /// </summary>
    public class VisualAttribute : NdapiObject
    {
        /// <summary>
        /// Creates a visual attribute.
        /// </summary>
        /// <param name="module">Visual attribute owner.</param>
        /// <param name="name">Visual attribute name.</param>
        public VisualAttribute(FormModule module, string name) : base(name, ObjectType.VisualAttribute, module)
        {
        }

        /// <summary>
        /// Creates a visual attribute.
        /// </summary>
        /// <param name="menu">Visual attribute owner.</param>
        /// <param name="name">Visual attribute name.</param>
        public VisualAttribute(MenuModule menu, string name) : base(name, ObjectType.VisualAttribute, menu)
        {
        }
        /// <summary>
        /// Creates a visual attribute.
        /// </summary>
        /// <param name="group">Visual attribute owner.</param>
        /// <param name="name">Visual attribute name.</param>
        public VisualAttribute(ObjectGroup group, string name) : base(name, ObjectType.VisualAttribute, group)
        {
        }

        internal VisualAttribute(ObjectSafeHandle handle) : base(handle)
        {
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
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
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
        /// Gets or sets the prompt background color.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_BACK_COLOR)]
        public string PromptBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the prompt's fill region.
        /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FILL_PAT)]
        public string PromptFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the prompt's font name.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FONT_NAM)]
        public string PromptFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the prompt's font size.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FONT_SIZ)]
        public int PromptFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font spacing.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FONT_SPCING)]
        public FontSpacing PromptFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_PRMPT_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font style.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FONT_STY)]
        public FontStyle PromptFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_PRMPT_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the prompt font weight.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FONT_WGHT)]
        public FontWeight PromptFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_PRMPT_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_PRMPT_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the prompt foreground color.
        /// </summary>
        [Property(NdapiConstants.D2FP_PRMPT_FORE_COLOR)]
        public string PromptForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_PRMPT_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute type.
        /// </summary>
        [Property(NdapiConstants.D2FP_VAT_TYP)]
        public VisualAttributeType Type
        {
            get { return GetNumberProperty<VisualAttributeType>(NdapiConstants.D2FP_VAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_VAT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstants.D2FP_WHITE_ON_BLACK)]
        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }
    }
}
