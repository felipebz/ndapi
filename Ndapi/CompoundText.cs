using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a compound text.
/// </summary>
public class CompoundText : NdapiObject<CompoundText>
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

    /// <summary>
    /// Creates a text segment.
    /// </summary>
    /// <param name="name">Name of the text segment.</param>
    /// <returns>The child object.</returns>
    public TextSegment CreateTextSegment(string name) => new TextSegment(this, name);
}