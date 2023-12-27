using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a library program unit.
/// </summary>
public class LibraryProgramUnit : NdapiObject<LibraryProgramUnit>
{
    internal LibraryProgramUnit(ObjectSafeHandle handle) : base(handle, ObjectType.LibraryProgramUnit)
    {
    }

    /// <summary>
    /// Gets the program unit code.
    /// </summary>
    [Property(NdapiConstants.D2FP_PGU_TXT)]
    public string Text => GetStringProperty(NdapiConstants.D2FP_PGU_TXT);

    /// <summary>
    /// Gets the program unit type.
    /// </summary>
    [Property(NdapiConstants.D2FP_PGU_TYP)]
    public ProgramUnitType Type => GetNumberProperty<ProgramUnitType>(NdapiConstants.D2FP_PGU_TYP);
}
