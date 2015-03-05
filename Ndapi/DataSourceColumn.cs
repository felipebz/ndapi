using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a data source column.
    /// </summary>
    public class DataSourceColumn : NdapiObject<DataSourceColumn>
    {
        /// <summary>
        /// Creates a data source column.
        /// </summary>
        /// <param name="block">Block object.</param>
        /// <param name="name">Data source column name.</param>
        public DataSourceColumn(Block block, string name) : base(name, ObjectType.DataSourceColumn, block)
        {
        }

        internal DataSourceColumn(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the data source column length.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_LEN)]
        public int Length
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_LEN, value); }
        }

        /// <summary>
        /// Gets or sets whether the data source column is mandatory.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_MANDATORY)]
        public bool IsMandatory
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DSC_MANDATORY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DSC_MANDATORY, value); }
        }

        /// <summary>
        /// Gets or sets the data source column name.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_NAM)]
        public override string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSC_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the data source column precision.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_PRECISION)]
        public int Precision
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_PRECISION); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_PRECISION, value); }
        }

        /// <summary>
        /// Gets or sets the data source column scale.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_SCALE)]
        public int Scale
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_SCALE); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_SCALE, value); }
        }

        /// <summary>
        /// Gets or sets the data source column type.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_TYP)]
        public DataSourceColumnType Type
        {
            get { return GetNumberProperty<DataSourceColumnType>(NdapiConstants.D2FP_DSC_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the name of the data source column type.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSC_TYPE_NAME)]
        public string TypeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSC_TYPE_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_DSC_TYPE_NAME, value); }
        }
    }
}
