using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a font declaration
/// </summary>
public partial class Font : NdapiObject<Font>
{
    /// <summary>
    /// Creates a font declaration
    /// </summary>
    public Font() : base(ObjectType.Font)
    {
        Handle = new ObjectSafeHandle();
        var status = NativeMethods.d2ffntcr_Create(NdapiContext.GetContext(), out Handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Extracts the font declaration from an object.
    /// </summary>
    /// <param name="obj">Object.</param>
    /// <param name="type">Visual attribute type.</param>
    public Font(NdapiObject obj, VisualAttributeType type) : this()
    {
        Extract(obj, type);
    }

    internal Font(ObjectSafeHandle handle) : base(handle, ObjectType.Font)
    {
    }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public partial string FontName { get; set; }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public partial int FontSize { get; set; }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public partial FontSpacing FontSpacing { get; set; }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public partial FontStyle FontStyle { get; set; }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public partial FontWeight FontWeight { get; set; }

    /// <summary>
    /// Extract the font declaration from the specified object.
    /// </summary>
    /// <param name="obj">Object.</param>
    /// <param name="type">Visual attribute type.</param>
    public void Extract(NdapiObject obj, VisualAttributeType type)
    {
        var status = NativeMethods.d2ffntex_Extract(NdapiContext.GetContext(), Handle, obj.Handle, type);
        Ensure.Success(status);
    }

    /// <summary>
    /// Apply the coordinate declaration to the specified form module.
    /// </summary>
    /// <param name="module">Form module to be changed.</param>
    /// <param name="type">Visual attribute type.</param>
    public void Apply(NdapiObject module, VisualAttributeType type)
    {
        var status = NativeMethods.d2ffntap_Apply(NdapiContext.GetContext(), Handle, module.Handle, type);
        Ensure.Success(status);
    }
}
