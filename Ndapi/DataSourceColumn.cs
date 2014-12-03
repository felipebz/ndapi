using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class DataSourceColumn : NdapiObject
    {
        public DataSourceColumn(Block module, string name)
        {
            Create(name, ObjectType.DataSourceColumn, module);
        }

        internal DataSourceColumn(ObjectSafeHandle handle) : base(handle)
        {
        }

        public int Length
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_LEN, value); }
        }

        public bool Mandatory
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DSC_MANDATORY); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DSC_MANDATORY, value); }
        }

        public override string Name
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSC_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_DSC_NAM, value); }
        }

        public int Precision
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_PRECISION); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_PRECISION, value); }
        }

        public int Scale
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_SCALE); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_SCALE, value); }
        }

        public int Type
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DSC_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_DSC_TYP, value); }
        }

        public string TypeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_DSC_TYPE_NAME); }
            set { SetStringProperty(NdapiConstants.D2FP_DSC_TYPE_NAME, value); }
        }
    }
}
