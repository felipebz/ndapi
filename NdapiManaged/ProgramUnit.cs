﻿using NdapiManaged.Core;
using NdapiManaged.Core.Handles;
using NdapiManaged.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged
{
    public class ProgramUnit : NdapiObject
    {
        public ProgramUnit()
        {
        }

        public ProgramUnit(string name)
        {
            Create(name, NdapiConstants.D2FFO_PROG_UNIT);
        }

        internal ProgramUnit(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string Text
        {
            get { return GetStringProperty(NdapiConstants.D2FP_PGU_TXT); }
            set { SetStringProperty(NdapiConstants.D2FP_PGU_TXT, value); }
        }

        public ProgramUnitType Type
        {
            get { return GetNumberProperty<ProgramUnitType>(NdapiConstants.D2FP_PGU_TYP); }
        }

        public void Compile()
        {
            var status = NativeMethods.d2fpguco_CompileObj(NdapiContext.Context, _handle);
            Ensure.Success(status);
        }
    }
}
