using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a text segment.
    /// </summary>
    public class TextSegment : NdapiObject<TextSegment>
    {
        /// <summary>
        /// Creates a text segment.
        /// </summary>
        /// <param name="compoundText">Text segment owner.</param>
        /// <param name="name">Text segment name.</param>
        public TextSegment(CompoundText compoundText, string name) : base(name, ObjectType.TextSegment, compoundText)
        {
        }

        internal TextSegment(ObjectSafeHandle handle) : base(handle)
        {
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
        public FontSpacing FontSpacing
        {
            get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING);
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
        /// Gets or sets the foreground color.
        /// </summary>
        [Property(NdapiConstants.D2FP_FORE_COLOR)]
        public string ForegroundColor
        {
            get => GetStringProperty(NdapiConstants.D2FP_FORE_COLOR);
            set => SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value);
        }

        /// <summary>
        /// Gets or sets the text segment content.
        /// </summary>
        [Property(NdapiConstants.D2FP_TEXT)]
        public string Text
        {
            get => GetStringProperty(NdapiConstants.D2FP_TEXT);
            set => SetStringProperty(NdapiConstants.D2FP_TEXT, value);
        }
    }
}
