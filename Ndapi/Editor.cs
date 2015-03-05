using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents an editor object.
    /// </summary>
    public class Editor : NdapiObject<Editor>
    {
        /// <summary>
        /// Creates an editor.
        /// </summary>
        /// <param name="module">Editor owner.</param>
        /// <param name="name">Editor name.</param>
        public Editor(FormModule module, string name) : base(name, ObjectType.Editor, module)
        {
        }

        /// <summary>
        /// Creates an editor.
        /// </summary>
        /// <param name="group">Editor owner.</param>
        /// <param name="name">Editor name.</param>
        public Editor(ObjectGroup group, string name) : base(name, ObjectType.Editor, group)
        {
        }

        internal Editor(ObjectSafeHandle handle) : base(handle)
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
        /// Gets or sets the bottom title.
        /// </summary>
        [Property(NdapiConstants.D2FP_BTM_TTL)]
        public string BottomTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BTM_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_BTM_TTL, value); }
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
        /// Gets or sets the height.
        /// </summary>
        [Property(NdapiConstants.D2FP_HEIGHT)]
        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should show a horizontal scrollbar.
        /// </summary>
        [Property(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR)]
        public bool ShowHorizontalScrollbar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_HORZ_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should show a vertical scrollbar.
        /// </summary>
        [Property(NdapiConstants.D2FP_SHOW_VERT_SCRLBR)]
        public bool ShowVerticalScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_VERT_SCRLBR, value); }
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

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        [Property(NdapiConstants.D2FP_VAT_NAM)]
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstants.D2FP_WHITE_ON_BLACK)]
        public bool IsWhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [Property(NdapiConstants.D2FP_WIDTH)]
        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        /// <summary>
        /// Gets or sets the content's wrap style.
        /// </summary>
        [Property(NdapiConstants.D2FP_WRAP_STY)]
        public WrapStyle WrapStyle
        {
            get { return GetNumberProperty<WrapStyle>(NdapiConstants.D2FP_WRAP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_WRAP_STY, value); }
        }

        /// <summary>
        /// Gets or sets the X position measured at the upper left corner.
        /// </summary>
        [Property(NdapiConstants.D2FP_X_POS)]
        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position measured at the upper left corner.
        /// </summary>
        [Property(NdapiConstants.D2FP_Y_POS)]
        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }
    }
}
