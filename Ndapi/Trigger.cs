﻿using Ndapi.Core;
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
    public partial string Comment { get; set; }

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
    public partial string KeyboardHelpDescription { get; set; }

    /// <summary>
    /// Gets or sets the trigger style.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRG_STY)]
    public partial TriggerStyle Style { get; set; }

    /// <summary>
    /// Gets or sets the trigger code.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRG_TXT)]
    public partial string Text { get; set; }

    /// <summary>
    /// Compiles the trigger.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2ftrgco_CompileObj(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }
}
