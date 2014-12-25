using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a program unit object.
    /// </summary>
    public class ProgramUnit : NdapiObject
    {
        /// <summary>
        /// Creates a program unit.
        /// </summary>
        /// <param name="module">Program unit owner.</param>
        /// <param name="name">Program unit name.</param>
        public ProgramUnit(FormModule module, string name)
        {
            Create(name, ObjectType.ProgramUnit, module);
        }

        /// <summary>
        /// Creates a program unit.
        /// </summary>
        /// <param name="module">Program unit owner.</param>
        /// <param name="name">Program unit name.</param>
        public ProgramUnit(MenuModule module, string name)
        {
            Create(name, ObjectType.ProgramUnit, module);
        }

        /// <summary>
        /// Creates a program unit.
        /// </summary>
        /// <param name="module">Program unit owner.</param>
        /// <param name="name">Program unit name.</param>
        public ProgramUnit(ObjectGroup module, string name)
        {
            Create(name, ObjectType.ProgramUnit, module);
        }

        /// <summary>
        /// Creates a program unit.
        /// </summary>
        /// <param name="module">Program unit owner.</param>
        /// <param name="name">Program unit name.</param>
        public ProgramUnit(ObjectLibrary module, string name)
        {
            Create(name, ObjectType.ProgramUnit, module);
        }

        internal ProgramUnit(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the program unit code.
        /// </summary>
        public string Text
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PGU_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_PGU_TXT, value); }
        }

        /// <summary>
        /// Gets the program unit type.
        /// </summary>
        public ProgramUnitType Type => GetNumberProperty<ProgramUnitType>(NdapiConstants.D2FP_PGU_TYP);

        /// <summary>
        /// Compile the program unit.
        /// </summary>
        public void Compile()
        {
            var status = NativeMethods.d2fpguco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}
