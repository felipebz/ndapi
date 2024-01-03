using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a font declaration
/// </summary>
public class Font : NdapiObject<Font>
{
    /// <summary>
    /// Creates a font declaration
    /// </summary>
    public Font() : base(ObjectType.Font)
    {
        _handle = new ObjectSafeHandle();
        var status = NativeMethods.d2ffntcr_Create(NdapiContext.GetContext(), out _handle);
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
    public string FontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public int FontSize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_FONT_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public FontSpacing FontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstant.D2FP_FONT_SPCING);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public FontStyle FontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstant.D2FP_FONT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public FontWeight FontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstant.D2FP_FONT_WGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_WGHT, value);
    }

    /// <summary>
    /// Extract the font declaration from the specified object.
    /// </summary>
    /// <param name="obj">Object.</param>
    /// <param name="type">Visual attribute type.</param>
    public void Extract(NdapiObject obj, VisualAttributeType type)
    {
        var status = NativeMethods.d2ffntex_Extract(NdapiContext.GetContext(), _handle, obj._handle, type);
        Ensure.Success(status);
    }

    /// <summary>
    /// Apply the coordinate declaration to the specified form module.
    /// </summary>
    /// <param name="module">Form module to be changed.</param>
    /// <param name="type">Visual attribute type.</param>
    public void Apply(NdapiObject module, VisualAttributeType type)
    {
        var status = NativeMethods.d2ffntap_Apply(NdapiContext.GetContext(), _handle, module._handle, type);
        Ensure.Success(status);
    }
}
