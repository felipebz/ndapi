using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a record group column.
/// </summary>
public class RecordGroupColumn : NdapiObject<RecordGroupColumn>
{
    /// <summary>
    /// Creates a record group column.
    /// </summary>
    /// <param name="module">Column owner.</param>
    /// <param name="name">Column name.</param>
    public RecordGroupColumn(RecordGroup module, string name) : base(name, ObjectType.ColumnSpecification, module)
    {
    }

    internal RecordGroupColumn(ObjectSafeHandle handle) : base(handle, ObjectType.ColumnSpecification)
    {
    }

    /// <summary>
    /// Gets or sets the column data type.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_DAT_TYP)]
    public ColumnSpecificationDataType DataType
    {
        get => GetNumberProperty<ColumnSpecificationDataType>(NdapiConstant.D2FP_COL_DAT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_COL_DAT_TYP, value);
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
    /// Gets the number of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_VALS_COUNT)]
    public int ValueCount => GetNumberProperty(NdapiConstant.D2FP_COL_VALS_COUNT);

    /// <summary>
    /// Gets the menu item roles.
    /// </summary>
    public IEnumerable<string> Values
    {
        get
        {
            for (var i = 1; i <= ValueCount; i++) // objects index is one-based
            {
                yield return GetValueAt(i);
            }
        }
    }

    /// <summary>
    /// Inserts a value in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which value should be inserted.</param>
    /// <param name="value">Value to insert.</param>
    /// <param name="formatMask">Format mask to format the data.</param>
    public void AddValueAt(int index, string value, string formatMask = null)
    {
        var status = NativeMethods.d2frcsir_InsertRow_Int(NdapiContext.GetContext(), _handle, index, value, formatMask);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the value in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which value should be removed.</param>
    public void DeleteValueAt(int index)
    {
        var status = NativeMethods.d2frcsdr_DeleteRow(NdapiContext.GetContext(), _handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the value in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the value.</param>
    /// <returns>The row value.</returns>
    public string GetValueAt(int index)
    {
        var status = NativeMethods.d2frcsgr_GetRow(NdapiContext.GetContext(), _handle, index, out var value);
        Ensure.Success(status);
        return value;
    }
}
