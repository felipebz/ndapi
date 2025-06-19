using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an attached library object.
/// </summary>
public partial class AttachedLibrary : NdapiObject<AttachedLibrary>
{
    /// <summary>
    /// Creates an attached library in the specified module.
    /// </summary>
    /// <param name="module">Form module to attach the library.</param>
    /// <param name="location">Library location.</param>
    public AttachedLibrary(FormModule module, string location)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module.Handle, out Handle, false, location)
            : NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module.Handle, out Handle, location);

        Ensure.Success(status);
    }

    /// <summary>
    /// Creates an attached library in the specified module.
    /// </summary>
    /// <param name="module">Form module to attach the library.</param>
    /// <param name="location">Library location.</param>
    public AttachedLibrary(MenuModule module, string location)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module.Handle, out Handle, false, location)
            : NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module.Handle, out Handle, location);

        Ensure.Success(status);
    }

    internal AttachedLibrary(ObjectSafeHandle handle) : base(handle, ObjectType.AttachedLibrary)
    {
    }

    /// <summary>
    /// Gets or sets the comment property.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets the library location.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIB_LOC)]
    public partial string Location { get; }

    /// <summary>
    /// Gets the library source type.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIB_SRC)]
    public partial SourceType SourceType { get; }

    /// <summary>
    /// Detaches the attached library and destroy the object.
    /// </summary>
    public void Detach()
    {
        var status = NativeMethods.d2falbdt_Detach(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);

        Handle = null;
    }
}
