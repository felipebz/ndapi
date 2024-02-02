using System.IO;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Metadata;

namespace Ndapi;

/// <summary>
/// Represents a generic module.
/// </summary>
public abstract class NdapiModule : NdapiObject
{
    private protected NdapiModule(string name, ObjectType type, NdapiObject parent = null) : base(name, type, parent)
    {
        NdapiContext.AddModule(this);
    }

    private protected NdapiModule(ObjectSafeHandle handle, ObjectType type) : base(handle, type)
    {
        NdapiContext.AddModule(this);
    }

    /// <summary>
    /// Load the module into memory.
    /// </summary>
    /// <param name="filename">Module location (.fmb, .olb, .mmb or .pll file)</param>
    /// <returns>Loaded module reference.</returns>
    public static NdapiModule Open(string filename)
    {
        var extension = Path.GetExtension(filename).ToUpperInvariant();
        return extension switch
        {
            ".FMB" => FormModule.Open(filename),
            ".OLB" => ObjectLibrary.Open(filename),
            ".MMB" => MenuModule.Open(filename),
            ".PLL" => LibraryModule.Open(filename),
            _ => throw new NdapiException($"The file {filename} does not have a valid extension.")
        };
    }

    /// <summary>
    /// Save the module to disk.
    /// </summary>
    public abstract void Save();

    /// <summary>
    /// Save the module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    public abstract void Save(string path);

    /// <summary>
    /// Save the module to disk.
    /// </summary>
    /// <param name="path">Location to save.</param>
    /// <param name="saveInDatabase">Should save module in database.</param>
    public abstract void Save(string path, bool saveInDatabase);

    /// <summary>
    /// Compile the module.
    /// </summary>
    public abstract void CompileFile();

    /// <summary>
    /// Compile PL/SQL code in the module.
    /// </summary>
    public abstract void CompileObjects();

    /// <summary>
    /// Convert the module to text.
    /// </summary>
    /// <param name="filename">File to convert.</param>
    public static void ConvertToText<T>(string filename) where T : NdapiModule
    {
        var type = NdapiMetadata.GetObjectTypeFrom<T>();
        var internalObjectType = ConstantConverter.GetValue(type);
        var status = NativeMethods.d2fctxcf_ConvertFile(NdapiContext.GetContext(), filename, internalObjectType, ConstantConverter.GetValue(NdapiConstant.BINTOTEXT));
        Ensure.Success(status);
    }

    /// <summary>
    /// Convert the text file to a binary module.
    /// </summary>
    /// <param name="filename">File to convert.</param>
    public static void ConvertFromText<T>(string filename) where T : NdapiModule
    {
        var type = NdapiMetadata.GetObjectTypeFrom<T>();
        var internalObjectType = ConstantConverter.GetValue(type);
        var status = NativeMethods.d2fctxcf_ConvertFile(NdapiContext.GetContext(), filename, internalObjectType, ConstantConverter.GetValue(NdapiConstant.TEXTTOBIN));
        Ensure.Success(status);
    }

    /// <summary>
    /// Close the module.
    /// </summary>
    public override void Destroy()
    {
        NdapiContext.RemoveModule(this);
        base.Destroy();
    }
}
