using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a trigger object.
/// </summary>
public partial class Trigger : NdapiObject<Trigger>
{
    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="module">Trigger owner.</param>
    /// <param name="name">Trigger name.</param>
    public Trigger(FormModule module, string name) : base(name, ObjectType.Trigger, module)
    {
    }

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="group">Trigger owner.</param>
    /// <param name="name">Trigger name.</param>
    public Trigger(ObjectGroup group, string name) : base(name, ObjectType.Trigger, group)
    {
    }

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="block">Trigger owner.</param>
    /// <param name="name">Trigger name.</param>
    public Trigger(Block block, string name) : base(name, ObjectType.Trigger, block)
    {
    }

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="item">Trigger owner.</param>
    /// <param name="name">Trigger name.</param>
    public Trigger(Item item, string name) : base(name, ObjectType.Trigger, item)
    {
    }

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="propertyClass">Trigger owner.</param>
    /// <param name="name">Trigger name.</param>
    public Trigger(PropertyClass propertyClass, string name) : base(name, ObjectType.Trigger, propertyClass)
    {
    }

    internal Trigger(ObjectSafeHandle handle) : base(handle, ObjectType.Trigger)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should display the trigger in keyboard help.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_IN_KBRD_HLP)]
    public partial bool DisplayInKeyboardHelp { get; set; }

    /// <summary>
    /// Gets or sets the execution style.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_HIERARCHY)]
    public partial ExecutionStyle ExecutionStyle { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should fire the trigger in enter-query mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIRE_IN_QRY)]
    public partial bool FireInEnterQueryMode { get; set; }

    /// <summary>
    /// Gets or sets the keyboard help description.
    /// </summary>
    [Property(NdapiConstant.D2FP_KBRD_HLP_TXT)]
    public partial string? KeyboardHelpDescription { get; set; }

    /// <summary>
    /// Gets or sets the trigger style.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRG_STY)]
    public partial TriggerStyle Style { get; set; }

    /// <summary>
    /// Gets or sets the trigger code.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRG_TXT)]
    public partial string? Text { get; set; }

    /// <summary>
    /// Gets or sets whether the object is hidden.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIDE)]
    public partial bool IsHidden { get; set; }

    /// <summary>
    /// Gets or sets the internal trigger type.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRG_INTERNAL_TYP)]
    public partial int InternalType { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the keyboard help description.
    /// </summary>
    [Property(NdapiConstant.D2FP_KBRD_HLP_TXT_STRID)]
    public partial int KeyboardHelpDescriptionStringId { get; set; }

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
    /// Gets or sets the name of the first-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL1OBJ_NAM)]
    public partial string? ParentSourceLevel1ObjectName { get; set; }

    /// <summary>
    /// Gets or sets the type of the first-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL1OBJ_TYP)]
    public partial int ParentSourceLevel1ObjectType { get; set; }

    /// <summary>
    /// Gets or sets the name of the second-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL2OBJ_NAM)]
    public partial string? ParentSourceLevel2ObjectName { get; set; }

    /// <summary>
    /// Gets or sets the type of the second-level source object of the parent.
    /// </summary>
    [Property(NdapiConstant.D2FP_PAR_SL2OBJ_TYP)]
    public partial int ParentSourceLevel2ObjectType { get; set; }

    /// <summary>
    /// Compiles the trigger.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2ftrgco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }
}
