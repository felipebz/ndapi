using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class BlockRelation : NdapiObject
    {
        public BlockRelation()
        {
        }

        public BlockRelation(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_RELATION, module);
        }

        internal BlockRelation(ObjectSafeHandle handle) : base(handle)
        {
        }

        public bool AutomaticQuery
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_AUTO_QRY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_AUTO_QRY, value); }
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public bool Deferred
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DEFERRED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DEFERRED, value); }
        }

        public DeleteRecordBehavior DeleteRecordBehavior
        {
            get { return GetNumberProperty<DeleteRecordBehavior>(NdapiConstants.D2FP_DEL_REC); }
            set { SetNumberProperty(NdapiConstants.D2FP_DEL_REC, value); }
        }

        public string DetailBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DETAIL_BLK); }
            set { SetStringProperty(NdapiConstants.D2FP_DETAIL_BLK, value); }
        }

        public string JoinCondition
        {
            get { return GetStringProperty(NdapiConstants.D2FP_JOIN_COND); }
            set { SetStringProperty(NdapiConstants.D2FP_JOIN_COND, value); }
        }

        public bool PreventMasterlessOperations
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_PRVNT_MSTRLESS_OPS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_PRVNT_MSTRLESS_OPS, value); }
        }
    }
}
