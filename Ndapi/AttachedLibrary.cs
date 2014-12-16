using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    public class AttachedLibrary : NdapiObject
    {
        public AttachedLibrary(string name)
        {
            Create(name, ObjectType.AttachedLibrary);
        }

        internal AttachedLibrary(ObjectSafeHandle handle) : base(handle)
        {
        }

        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        public string Location => GetStringProperty(NdapiConstants.D2FP_LIB_LOC);

        public SourceType SourceType => GetNumberProperty<SourceType>(NdapiConstants.D2FP_LIB_SRC);
    }
}