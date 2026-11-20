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
    public partial string? Location { get; }

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

        var module = new LibraryModule(library);
        NdapiContext.AddModule(module);
        return module;
    }

    /// <summary>
    /// Load the program unit library into memory, reporting attached libraries that could not be loaded instead of
    /// failing. Forms 12c and later.
    /// </summary>
    /// <param name="filename">Library location (.pll file)</param>
    /// <param name="libraryErrors">The library load errors (FRM-10102 …), or null when every library was loaded.</param>
    /// <returns>Loaded library reference.</returns>
    public static LibraryModule Open(string filename, out string? libraryErrors)
    {
        Ensure.MinimumMajorVersion(12, "Loading with library details");
        var status = NativeMethods.d2flibld_Load_pllDetails(NdapiContext.GetContext(), out var library, filename, true,
            out var details);
        libraryErrors = NlsStringMarshaller.ReadNlsStringAndFree(details);
        if (status != FormsErrorCode.MissingLibraryModule)
        {
            Ensure.Success(status);
        }

        var module = new LibraryModule(library);
        NdapiContext.AddModule(module);
        return module;
    }

    /// <summary>
    /// Compile the library, creating a .plx file. Forms 12c and later.
    /// </summary>
    public override void CompileFile()
    {
        Ensure.MinimumMajorVersion(12, nameof(CompileFile));
        var status = NativeMethods.d2flibcf_CompileFile(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
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
    public override void Save(string? path, bool saveInDatabase)
    {
        throw new NotSupportedException("Library module does not support saving");
    }
}
