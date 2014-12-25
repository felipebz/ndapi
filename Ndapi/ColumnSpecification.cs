using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a record group column.
    /// </summary>
    public class ColumnSpecification : NdapiObject
    {
        /// <summary>
        /// Creates a record group column.
        /// </summary>
        /// <param name="module"></param>
        /// <param name="name"></param>
        public ColumnSpecification(RecordGroup module, string name)
        {
            Create(name, ObjectType.ColumnSpecification, module);
        }

        internal ColumnSpecification(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the column data type.
        /// </summary>
        public ColumnSpecificationDataType DataType
        {
            get { return GetNumberProperty<ColumnSpecificationDataType>(NdapiConstants.D2FP_COL_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_COL_DAT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the maximum length.
        /// </summary>
        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        /// <summary>
        /// Gets the number of values.
        /// </summary>
        public int ValueCount => GetNumberProperty(NdapiConstants.D2FP_COL_VALS_COUNT);
    }
}
