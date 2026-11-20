using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents a relation between blocks.
/// </summary>
public partial class BlockRelation : NdapiObject<BlockRelation>
{
    /// <summary>
    /// Creates a block relation.
    /// </summary>
    /// <param name="module">Relation owner.</param>
    /// <param name="name">Relation name.</param>
    public BlockRelation(Block module, string name) : base(name, ObjectType.BlockRelation, module)
    {
    }

    internal BlockRelation(ObjectSafeHandle handle) : base(handle, ObjectType.BlockRelation)
    {
    }

    /// <summary>
    /// Gets or sets whether runtime should execute an automatic query when the user navigates to
    /// the detail block. This property will affect master-details triggers only when <see cref="IsDeferred"/> is true.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_QRY)]
    public partial bool AutomaticQuery { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string? Comment { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should defer fetching the associated details records.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEFERRED)]
    public partial bool IsDeferred { get; set; }

    /// <summary>
    /// Gets or sets the relation behavior when deleting records.
    /// </summary>
    [Property(NdapiConstant.D2FP_DEL_REC)]
    public partial DeleteRecordBehavior DeleteRecordBehavior { get; set; }

    /// <summary>
    /// Gets or sets the detail block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DETAIL_BLK)]
    public partial string? DetailBlock { get; set; }

    /// <summary>
    /// Gets or sets the join condition between master and detail block.
    /// </summary>
    [Property(NdapiConstant.D2FP_JOIN_COND)]
    public partial string? JoinCondition { get; set; }

    /// <summary>
    /// Gets or sets whether runtime should be allowed to query or insert records in a block that is a detail block in a master-detail relation.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRVNT_MSTRLESS_OPS)]
    public partial bool PreventMasterlessOperations { get; set; }

    /// <summary>
    /// Gets or sets the item that holds the REF to the master block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DETAIL_ITEMREF)]
    public partial string? DetailItemReference { get; set; }

    /// <summary>
    /// Gets or sets whether the relation is based on a join condition or on a REF item.
    /// </summary>
    [Property(NdapiConstant.D2FP_REL_TYPE)]
    public partial RelationType RelationType { get; set; }

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
    /// Generate the triggers and program units required for the relation.
    /// If you do not call this function, the relation object is not complete and the behavior is undefined.
    /// </summary>
    public void Generate()
    {
        var status = NativeMethods.d2frelup_Update(NdapiContext.GetContext(), Handle);
        Ensure.Success(status);
    }
}
