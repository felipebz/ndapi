using System;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a program unit library.
/// </summary>
public partial class LibraryModule : NdapiModule
{
    internal LibraryModule(ObjectSafeHandle handle) : base(handle, ObjectType.LibraryModule)
    {
    }

    /// <summary>
    /// Gets all the attached libraries.
    /// </summary>
    [Property(NdapiConstant.D2FP_ATT_LIB)]
    public partial NdapiObjectList<AttachedLibrary> AttachedLibraries { get; }

    /// <summary>
    /// Gets the library location.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIB_LOC)]
    public partial string Location { get; }

    /// <summary>
    /// Gets all the program units.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIB_PROG_UNIT)]
    public partial NdapiObjectList<LibraryProgramUnit> ProgramUnits { get; }

    /// <summary>
    /// Gets the source type.
    /// </summary>
    [Property(NdapiConstant.D2FP_LIB_SRC)]
    public partial SourceType SourceType { get; }

    /// <summary>
    /// Load the program unit library into memory.
    /// </summary>
    /// <param name="filename">Library location (.pll file)</param>
    /// <returns>Loaded library reference.</returns>
    public new static LibraryModule Open(string filename)
    {
        var status = NdapiContext.BuilderVersion.MajorVersion == 6
            ? NativeMethods.d2flibld_Load(NdapiContext.GetContext(), out var library, filename, false)
            : NativeMethods.d2flibld_Load(NdapiContext.GetContext(), out library, filename);

        Ensure.Success(status);

        return new LibraryModule(library);
    }

    /// <summary>
    /// Program unit libraries does not support compilation.
    /// </summary>
    public override void CompileFile()
    {
        throw new NotSupportedException("Library module does not support compilation");
    }

    /// <summary>
    /// Program unit libraries does not support compilation.
    /// </summary>
    public override void CompileObjects()
    {
        throw new NotSupportedException("Library module does not support compilation");
    }

    /// <summary>
    /// Program unit libraries does not support saving.
    /// </summary>
    public override void Save()
    {
        throw new NotSupportedException("Library module does not support saving");
    }

    /// <summary>
    /// Program unit libraries does not support saving.
    /// </summary>
    public override void Save(string path)
    {
        throw new NotSupportedException("Library module does not support saving");
    }

    /// <summary>
    /// Program unit libraries does not support saving.
    /// </summary>
    public override void Save(string path, bool saveInDatabase)
    {
        throw new NotSupportedException("Library module does not support saving");
    }
}
