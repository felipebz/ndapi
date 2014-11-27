using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class AttachedLibrary : NdapiObject
    {
        public AttachedLibrary(string name)
        {
            Create(name, NdapiConstants.D2FFO_ATT_LIB);
        }

        internal AttachedLibrary(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string Location
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LIB_LOC); }
        }

        public SourceType SourceType
        {
            get { return GetNumberProperty<SourceType>(NdapiConstants.D2FP_LIB_SRC); }
        }
    }
}
