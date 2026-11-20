using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a program unit object.
/// </summary>
public partial class ProgramUnit : NdapiObject<ProgramUnit>
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
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets the program unit code.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TXT)]
    public partial string? Text { get; set; }

    /// <summary>
    /// Gets the program unit type.
    /// </summary>
    [Property(NdapiConstant.D2FP_PGU_TYP)]
    public partial ProgramUnitType Type { get; }

    /// <summary>
    /// Gets or sets whether the program unit runs with the privileges of the current user (AUTHID CURRENT_USER).
    /// Forms 14 and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_PU_AUTH)]
    public partial bool IsAuthIdCurrentUser { get; set; }

    /// <summary>
    /// Gets or sets whether the program unit is restricted. Forms 14 and later.
    /// </summary>
    [Property(NdapiConstant.D2FP_PU_REST)]
    public partial bool IsRestricted { get; set; }

    /// <summary>
    /// Gets or sets whether the object was modified since it was loaded or saved.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIRTY_INFO)]
    public partial bool IsDirty { get; set; }

    /// <summary>
    /// Gets the module that contains the object.
    /// </summary>
    [Property(NdapiConstant.D2FP_MODULE)]
    public partial NdapiObject? Module { get; }

    /// <summary>
    /// Gets the object this object is subclassed from.
    /// </summary>
    [Property(NdapiConstant.D2FP_SOURCE)]
    public partial NdapiObject? Source { get; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as part of an object group.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_OBJGRP)]
    public partial bool IsSubclassObjectGroup { get; set; }

    /// <summary>
    /// Gets or sets whether the object is subclassed as a sub-object of a subclassed parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUBCL_SUBOBJ)]
    public partial bool IsSubclassSubObject { get; set; }

    /// <summary>
    /// Compile the program unit.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2fpguco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }
}
