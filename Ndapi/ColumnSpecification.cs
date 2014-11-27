using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class ColumnSpecification : NdapiObject
    {
        public ColumnSpecification(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_RG_COLSPEC, module);
        }

        internal ColumnSpecification(ObjectSafeHandle handle) : base(handle)
        {
        }

        public ColumnSpecificationDataType DataType
        {
            get { return GetNumberProperty<ColumnSpecificationDataType>(NdapiConstants.D2FP_COL_DAT_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_COL_DAT_TYP, value); }
        }

        public int ValueCount
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_COL_VALS_COUNT); }
        }
            
        public int MaximumLength
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_LEN); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_LEN, value); }
        }
    }
}
