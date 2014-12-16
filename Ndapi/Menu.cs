using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class Menu : NdapiObject
    {
        public Menu(FormModule module, string name)
        {
            Create(name, ObjectType.Menu, module);
        }

        internal Menu(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string Subtitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_SUB_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_SUB_TTL, value); }
        }

        public bool TearOffMenu
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU); }
            set { SetBooleanProperty(NdapiConstants.D2FP_TEAR_OFF_MNU, value); }
        }

        public IEnumerable<MenuItem> MenuItems => GetObjectList<MenuItem>(NdapiConstants.D2FP_MNU_ITM);
    }
}
