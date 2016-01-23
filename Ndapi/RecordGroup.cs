using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a record group.
    /// </summary>
    public class RecordGroup : NdapiObject<RecordGroup>
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

        internal RecordGroup(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the query fetch size.
        /// </summary>
        [Property(NdapiConstants.D2FP_REC_GRP_FETCH_SIZ)]
        public int FetchSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_REC_GRP_FETCH_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_REC_GRP_FETCH_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        [Property(NdapiConstants.D2FP_REC_GRP_QRY)]
        public string Query
        {
            get { return GetStringProperty(NdapiConstants.D2FP_REC_GRP_QRY); }
            set { SetStringProperty(NdapiConstants.D2FP_REC_GRP_QRY, value); }
        }

        /// <summary>
        /// Gets or sets the record group type.
        /// </summary>
        [Property(NdapiConstants.D2FP_REC_GRP_TYP)]
        public RecordGroupType Type
        {
            get { return GetNumberProperty<RecordGroupType>(NdapiConstants.D2FP_REC_GRP_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_REC_GRP_TYP, value); }
        }

        /// <summary>
        /// Gets the columns in the record group.
        /// </summary>
        [Property(NdapiConstants.D2FP_COL_SPEC)]
        public NdapiObjectList<RecordGroupColumn> Columns => GetObjectList<RecordGroupColumn>(NdapiConstants.D2FP_COL_SPEC);

        /// <summary>
        /// Set the record group query without parsing the SQL to create the record group column specifications.
        /// </summary>
        /// <param name="query">SQL query.</param>
        public void SetQueryWithoutParse(string query)
        {
            var status = NativeMethods.d2frcgs_qry_noparse(NdapiContext.GetContext(), _handle, query);
            Ensure.Success(status);
        }

        /// <summary>
        /// Creates a record group column.
        /// </summary>
        /// <param name="name">Name of the record group column.</param>
        /// <returns>The child object.</returns>
        public RecordGroupColumn CreateRecordGroupColumn(string name) => new RecordGroupColumn(this, name);
    }
}
