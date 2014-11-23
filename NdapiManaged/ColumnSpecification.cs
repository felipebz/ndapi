﻿using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged
{
    public class ColumnSpecification : NdapiObject
    {
        public ColumnSpecification()
        {
        }

        public ColumnSpecification(string name)
        {
            Create(name, NdapiConstants.D2FFO_RG_COLSPEC);
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
