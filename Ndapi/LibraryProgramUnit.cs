using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a library program unit.
/// </summary>
public partial class LibraryProgramUnit : NdapiObject<LibraryProgramUnit>
{
    internal LibraryProgramUnit(ObjectSafeHandle handle) : base(handle, ObjectType.LibraryProgramUnit)
    {
    }

    /// <summary>
    /// Gets the program unit code.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TXT)]
    public partial string Text { get; }

    /// <summary>
    /// Gets the program unit type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TYP)]
    public partial ProgramUnitType Type { get; }
}
