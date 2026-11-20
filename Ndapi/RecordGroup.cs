using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a record group.
/// </summary>
public partial class RecordGroup : NdapiObject<RecordGroup>
{
    /// <summary>
    /// Creates a record group
    /// </summary>
    /// <param name="module">Record group owner.</param>
    /// <param name="name">Record group name.</param>
    public RecordGroup(FormModule module, string name) : base(name, ObjectType.RecordGroup, module)
    {
    }

    /// <summary>
    /// Creates a record group
    /// </summary>
    /// <param name="group">Record group owner.</param>
    /// <param name="name">Record group name.</param>
    public RecordGroup(ObjectGroup group, string name) : base(name, ObjectType.RecordGroup, group)
    {
    }

    internal RecordGroup(ObjectSafeHandle handle) : base(handle, ObjectType.RecordGroup)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets the query fetch size.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP_FETCH_SIZ)]
    public partial int FetchSize { get; set; }

    /// <summary>
    /// Gets or sets the SQL query.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP_QRY)]
    public partial string? Query { get; set; }

    /// <summary>
    /// Gets or sets the record group type.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_GRP_TYP)]
    public partial RecordGroupType Type { get; set; }

    /// <summary>
    /// Gets the columns in the record group.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_SPEC)]
    public partial NdapiObjectList<RecordGroupColumn> Columns { get; }

    /// <summary>
    /// Gets or sets whether the object is hidden.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIDE)]
    public partial bool IsHidden { get; set; }

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
    /// Set the record group query without parsing the SQL to create the record group column specifications.
    /// </summary>
    /// <param name="query">SQL query.</param>
    public void SetQueryWithoutParse(string query)
    {
        var status = NativeMethods.d2frcgs_qry_noparse(NdapiContext.GetContext(), Handle, query);
        Ensure.Success(status);
    }

    /// <summary>
    /// Creates a record group column.
    /// </summary>
    /// <param name="name">Name of the record group column.</param>
    /// <returns>The child object.</returns>
    public RecordGroupColumn CreateRecordGroupColumn(string name) => new(this, name);
}
