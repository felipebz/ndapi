using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a program unit object.
/// </summary>
public class ProgramUnit : NdapiObject<ProgramUnit>
{
    /// <summary>
    /// Creates a program unit.
    /// </summary>
    /// <param name="module">Program unit owner.</param>
    /// <param name="name">Program unit name.</param>
    public ProgramUnit(FormModule module, string name) : base(name, ObjectType.ProgramUnit, module)
    {
    }

    /// <summary>
    /// Creates a program unit.
    /// </summary>
    /// <param name="module">Program unit owner.</param>
    /// <param name="name">Program unit name.</param>
    public ProgramUnit(MenuModule module, string name) : base(name, ObjectType.ProgramUnit, module)
    {
    }

    /// <summary>
    /// Creates a program unit.
    /// </summary>
    /// <param name="module">Program unit owner.</param>
    /// <param name="name">Program unit name.</param>
    public ProgramUnit(ObjectGroup module, string name) : base(name, ObjectType.ProgramUnit, module)
    {
    }

    internal ProgramUnit(ObjectSafeHandle handle) : base(handle, ObjectType.ProgramUnit)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comment
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the program unit code.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TXT)]
    public string Text
    {
        get => GetStringProperty(NdapiConstant.D2FP_PGU_TXT);
        set => SetStringProperty(NdapiConstant.D2FP_PGU_TXT, value);
    }

    /// <summary>
    /// Gets the program unit type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TYP)]
    public ProgramUnitType Type => GetNumberProperty<ProgramUnitType>(NdapiConstant.D2FP_PGU_TYP);

    /// <summary>
    /// Compile the program unit.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2fpguco_CompileObj(NdapiContext.GetContext(), _handle);
        Ensure.Success(status);
    }
}
