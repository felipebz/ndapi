using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class FormParameter : NdapiObject
    {
        public FormParameter(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_FORM_PARAM, module);
        }

        internal FormParameter(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        public ParameterDataType DataType
        {
            get { return GetNumberProperty<ParameterDataType>(NdapiConstants.D2FP_PARAM_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PARAM_DAT_TYP, value); }
        }

        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PARAM_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_PARAM_INIT_VAL, value); }
        }


    }
}
