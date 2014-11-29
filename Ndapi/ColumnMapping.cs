using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class ColumnMapping : NdapiObject
    {
        public ColumnMapping(FormModule module, string name)
        {
            Create(name, ObjectType.ColumnMapping, module);
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
