using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class ColumnSpecification : NdapiObject
    {
        public ColumnSpecification(FormModule module, string name)
        {
            Create(name, ObjectType.ColumnSpecification, module);
        }

        internal ColumnSpecification(ObjectSafeHandle handle) : base(handle)
        {
        }

        public ColumnSpecificationDataType DataType
        {
            get { return GetNumberProperty<ColumnSpecificationDataType>(NdapiConstants.D2FP_COL_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_COL_DAT_TYP, value); }
        }

        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }

        public int ValueCount => GetNumberProperty(NdapiConstants.D2FP_COL_VALS_COUNT);
    }
}
