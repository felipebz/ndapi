using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class DataSourceArgument : NdapiObject
    {
        public DataSourceArgument(Block module, string name)
        {
            Create(name, ObjectType.DataSourceArgument, module);
        }

        internal DataSourceArgument(ObjectSafeHandle handle) : base(handle)
        {
        }

        public DataSourceArgumentMode Mode
        {
            get { return GetNumberProperty<DataSourceArgumentMode>(NdapiConstants.D2FP_DSA_MODE); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSA_MODE, value); }
        }

        public override string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_NAM, value); }
        }

        public DataSourceColumnType Type
        {
            get { return GetNumberProperty<DataSourceColumnType>(NdapiConstants.D2FP_DSA_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSA_TYP, value); }
        }

        public string TypeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_TYP_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_TYP_NAM, value); }
        }

        public string Value
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSA_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_DSA_VAL, value); }
        }
    }
}
