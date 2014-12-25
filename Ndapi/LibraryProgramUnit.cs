using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a library program unit.
    /// </summary>
    public class LibraryProgramUnit : NdapiObject
    {
        internal LibraryProgramUnit(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets the program unit code.
        /// </summary>
        public string Text => GetStringProperty(NdapiConstants.D2FP_PGU_TXT);

        /// <summary>
        /// Gets the program unit type.
        /// </summary>
        public ProgramUnitType Type => GetNumberProperty<ProgramUnitType>(NdapiConstants.D2FP_PGU_TYP);
    }
}
