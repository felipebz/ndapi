using Ndapi.Core.Handles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ndapi
{
    public class ColumnMapping : NdapiObject
    {
        public ColumnMapping(FormModule module, string name)
        {
            Create(name, NdapiConstants.D2FFO_LV_COLMAP, module);
        }

        internal ColumnMapping(ObjectSafeHandle handle) : base(handle)
        {
        }

        public int DisplayWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DISP_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_DISP_WID, value); }
        }

        public string ReturnItem
        {
            get { return GetStringProperty(NdapiConstants.D2FP_RTRN_ITM); }
            set { SetStringProperty(NdapiConstants.D2FP_RTRN_ITM, value); }
        }

        public string Title
        {
            get { return GetStringProperty(NdapiConstants.D2FP_TITLE); }
            set { SetStringProperty(NdapiConstants.D2FP_TITLE, value); }
        }
    }
}
