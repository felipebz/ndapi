using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a compound text.
    /// </summary>
    public class CompoundText : NdapiObject
    {
        /// <summary>
        /// Creates a compound text.
        /// </summary>
        /// <param name="graphics">Compound text owner.</param>
        /// <param name="name">Compound text name.</param>
        public CompoundText(Graphics graphics, string name) : base(name, ObjectType.CompoundText, graphics)
        {
        }

        internal CompoundText(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets the text segments.
        /// </summary>
        [Property(NdapiConstants.D2FP_TEXT_SEG)]
        public NdapiObjectList<TextSegment> TextSegments => GetObjectList<TextSegment>(NdapiConstants.D2FP_TEXT_SEG);
    }
}
