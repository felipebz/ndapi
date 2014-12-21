using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class LibraryProgramUnit : NdapiObject
    {
        internal LibraryProgramUnit(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Text => GetStringProperty(NdapiConstants.D2FP_PGU_TXT);

        public ProgramUnitType Type => GetNumberProperty<ProgramUnitType>(NdapiConstants.D2FP_PGU_TYP);
    }
}
