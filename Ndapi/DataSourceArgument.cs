using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a data source argument.
    /// </summary>
    public class DataSourceArgument : NdapiObject<DataSourceArgument>
    {
        /// <summary>
        /// Creates a data source argument.
        /// </summary>
        /// <param name="block">Block object.</param>
        /// <param name="name">Data source argument name.</param>
        public DataSourceArgument(Block block, string name) : base(name, ObjectType.DataSourceArgument, block)
        {
        }

        internal DataSourceArgument(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets data source argument mode.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSA_MODE)]
        public DataSourceArgumentMode Mode
        {
            get { return GetNumberProperty<DataSourceArgumentMode>(NdapiConstants.D2FP_DSA_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSA_MODE, value); }
        }

        /// <summary>
        /// Gets or sets the data source argument name.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSA_NAM)]
        public override string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the data source argument type.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSA_TYP)]
        public DataSourceColumnType Type
        {
            get { return GetNumberProperty<DataSourceColumnType>(NdapiConstants.D2FP_DSA_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSA_TYP, value); }
        }

        /// <summary>
        /// Gets or sets name of the data source argument type.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSA_TYP_NAM)]
        public string TypeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_TYP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_TYP_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the data source argument value.
        /// </summary>
        [Property(NdapiConstants.D2FP_DSA_VAL)]
        public string Value
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_VAL, value); }
        }
    }
}
