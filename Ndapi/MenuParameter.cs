using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a menu module parameter.
/// </summary>
public class MenuParameter : NdapiObject<MenuParameter>
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
    public int AssociatedMenusCount => GetNumberProperty(NdapiConstant.D2FP_ASSOC_MENUS_COUNT);

    /// <summary>
    /// Gets or sets the case restriction.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_RSTRCTION)]
    public CaseRestriction CaseRestriction
    {
        get => GetNumberProperty<CaseRestriction>(NdapiConstant.D2FP_CASE_RSTRCTION);
        set => SetNumberProperty(NdapiConstant.D2FP_CASE_RSTRCTION, value);
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
    /// Gets or sets whether runtime should hide characters that the user types into the text item. 
    /// </summary>
    [Property(NdapiConstant.D2FP_CONCEAL_DATA)]
    public bool ConcealData
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_CONCEAL_DATA);
        set => SetBooleanProperty(NdapiConstant.D2FP_CONCEAL_DATA, value);
    }

    /// <summary>
    /// Gets or sets whether the length is fixed.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIXED_LEN)]
    public bool IsFixedLength
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_FIXED_LEN);
        set => SetBooleanProperty(NdapiConstant.D2FP_FIXED_LEN, value);
    }

    /// <summary>
    /// Gets or sets the parameter hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT)]
    public string Hint
    {
        get => GetStringProperty(NdapiConstant.D2FP_HINT);
        set => SetStringProperty(NdapiConstant.D2FP_HINT, value);
    }

    /// <summary>
    /// Gets or sets the label of the associated text item.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public string Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_LABEL);
        set => SetStringProperty(NdapiConstant.D2FP_LABEL, value);
    }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public int MaximumLength
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_LEN, value);
    }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_MNU_PARAM_INIT_VAL)]
    public string InitialValue
    {
        get => GetStringProperty(NdapiConstant.D2FP_MNU_PARAM_INIT_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_MNU_PARAM_INIT_VAL, value);
    }

    /// <summary>
    /// Gets the menu item roles.
    /// </summary>
    public IEnumerable<string> AssociatedMenus
    {
        get
        {
            for (var i = 1; i <= AssociatedMenusCount; i++) // objects index is one-based
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
        return menu;
    }
}
