using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu module parameter.
/// </summary>
public partial class MenuParameter : NdapiObject<MenuParameter>
{
    /// <summary>
    /// Creates a new menu parameter.
    /// </summary>
    /// <param name="module">Parameter owner.</param>
    /// <param name="name">Parameter name.</param>
    public MenuParameter(MenuModule module, string name) : base(name, ObjectType.MenuParameter, module)
    {
    }

    internal MenuParameter(ObjectSafeHandle handle) : base(handle, ObjectType.MenuParameter)
    {
    }

    /// <summary>
    /// Gets the number of associated menus.
    /// </summary>
    [Property(NdapiConstant.D2FP_ASSOC_MENUS_COUNT)]
    public partial int AssociatedMenusCount { get; }

    /// <summary>
    /// Gets or sets the case restriction.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_RSTRCTION)]
    public partial CaseRestriction CaseRestriction { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should hide characters that the user types into the text item. 
    /// </summary>
    [Property(NdapiConstant.D2FP_CONCEAL_DATA)]
    public partial bool ConcealData { get; set; }

    /// <summary>
    /// Gets or sets whether the length is fixed.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIXED_LEN)]
    public partial bool IsFixedLength { get; set; }

    /// <summary>
    /// Gets or sets the parameter hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT)]
    public partial string? Hint { get; set; }

    /// <summary>
    /// Gets or sets the label of the associated text item.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public partial string? Label { get; set; }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public partial int MaximumLength { get; set; }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_PARAM_INIT_VAL)]
    public partial string? InitialValue { get; set; }

    /// <summary>
    /// Gets or sets whether the parameter is required.
    /// </summary>
    [Property(NdapiConstant.D2FP_REQUIRED)]
    public partial bool IsRequired { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT_STRID)]
    public partial int HintStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL_STRID)]
    public partial int LabelStringId { get; set; }

    /// <summary>
    /// Gets or sets the translation string id of the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_PARAM_INIT_VAL_STRID)]
    public partial int InitialValueStringId { get; set; }

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
    /// Gets the menu item roles.
    /// </summary>
    public IEnumerable<string> AssociatedMenus
    {
        get
        {
            var count = AssociatedMenusCount;
            for (var i = 1; i <= count; i++) // objects index is one-based
            {
                yield return GetAssociatedMenuAt(i);
            }
        }
    }

    /// <summary>
    /// Inserts an associated menu in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which associated menu should be inserted.</param>
    /// <param name="menu">Associated menu name.</param>
    public void AddAssociatedMenuAt(int index, string menu)
    {
        var status = NativeMethods.d2fmpmaam_AddAssocMenu(NdapiContext.GetContext(), Handle, index, menu);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the associated menu in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which associated menu should be removed.</param>
    public void DeleteAssociatedMenuAt(int index)
    {
        var status = NativeMethods.d2fmpmram_RemoveAssocMenu(NdapiContext.GetContext(), Handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the associated menu in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the associated menu.</param>
    /// <returns>The associated menu name.</returns>
    public string GetAssociatedMenuAt(int index)
    {
        var status = NativeMethods.d2fmpmgam_GetAssocMenu(NdapiContext.GetContext(), Handle, index, out var menu);
        Ensure.Success(status);
        return NlsStringMarshaller.ReadNlsStringAndFree(menu) ?? string.Empty;
    }
}
