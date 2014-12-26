using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a relation between blocks.
    /// </summary>
    public class BlockRelation : NdapiObject
    {
        /// <summary>
        /// Creates a block relation.
        /// </summary>
        /// <param name="module">Relation owner.</param>
        /// <param name="name">Relation name.</param>
        public BlockRelation(Block module, string name) : base(name, ObjectType.BlockRelation, module)
        {
        }

        internal BlockRelation(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets whether runtime should execute an automatic query when the user navigates to
        /// the detail block. This property will affect master-details triggers only when <see cref="Deferred"/> is true.
        /// </summary>
        public bool AutomaticQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_QRY, value); }
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
        /// Gets or sets whether runtime should defer fetching the associated details records.
        /// </summary>
        public bool Deferred
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEFERRED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEFERRED, value); }
        }

        /// <summary>
        /// Gets or sets the relation behavior when deleting records.
        /// </summary>
        public DeleteRecordBehavior DeleteRecordBehavior
        {
            get { return GetNumberProperty<DeleteRecordBehavior>(NdapiConstants.D2FP_DEL_REC); }
            set { SetNumberProperty(NdapiConstants.D2FP_DEL_REC, value); }
        }

        /// <summary>
        /// Gets or sets the detail block.
        /// </summary>
        public string DetailBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DETAIL_BLK); }
            set { SetStringProperty(NdapiConstants.D2FP_DETAIL_BLK, value); }
        }

        /// <summary>
        /// Gets or sets the join condition between master and detail block.
        /// </summary>
        public string JoinCondition
        {
            get { return GetStringProperty(NdapiConstants.D2FP_JOIN_COND); }
            set { SetStringProperty(NdapiConstants.D2FP_JOIN_COND, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should be allowed to query or insert records in a block that is a detail block in a master-detail relation.
        /// </summary>
        public bool PreventMasterlessOperations
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_PRVNT_MSTRLESS_OPS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_PRVNT_MSTRLESS_OPS, value); }
        }

        /// <summary>
        /// Generate the triggers and program units required for the relation.
        /// If you do not call this function, the relation object is not complete and the behavior is undefined.
        /// </summary>
        public void Generate()
        {
            var status = NativeMethods.d2frelup_Update(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}
