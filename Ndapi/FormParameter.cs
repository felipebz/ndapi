using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a form parameter.
    /// </summary>
    public class FormParameter : NdapiObject
    {
        /// <summary>
        /// Creates a parameter in the specified form module.
        /// </summary>
        /// <param name="module">Parameter owner.</param>
        /// <param name="name">Parameter name.</param>
        public FormParameter(FormModule module, string name) : base(name, ObjectType.FormParameter, module)
        {
        }

        internal FormParameter(ObjectSafeHandle handle) : base(handle)
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
        /// Gets or sets the maximum length.
        /// </summary>
        [Property(NdapiConstants.D2FP_MAX_LEN)]
        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        /// <summary>
        /// Gets or sets the parameter data type.
        /// </summary>
        [Property(NdapiConstants.D2FP_PARAM_DAT_TYP)]
        public ParameterDataType DataType
        {
            get { return GetNumberProperty<ParameterDataType>(NdapiConstants.D2FP_PARAM_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_PARAM_DAT_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the initial value.
        /// </summary>
        [Property(NdapiConstants.D2FP_PARAM_INIT_VAL)]
        public string InitialValue
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PARAM_INIT_VAL); }
            set { SetStringProperty(NdapiConstants.D2FP_PARAM_INIT_VAL, value); }
        }
    }
}
