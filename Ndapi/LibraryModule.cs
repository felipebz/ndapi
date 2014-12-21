using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    public class LibraryModule : NdapiModule
    {
        internal LibraryModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        public IEnumerable<AttachedLibrary> AttachedLibraries => GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB);

        public string Location => GetStringProperty(NdapiConstants.D2FP_LIB_LOC);

        public SourceType SourceType => GetNumberProperty<SourceType>(NdapiConstants.D2FP_LIB_SRC);

        public new LibraryModule Open(string filename)
        {
            ObjectSafeHandle library;

            var status = NativeMethods.d2flibld_Load(NdapiContext.Context, out library, filename, false);
            Ensure.Success(status);

            return new LibraryModule(library);
        }

        public override void CompileFile()
        {
            throw new NdapiException("Library module does not support compilation");
        }

        public override void CompileObjects()
        {
            throw new NdapiException("Library module does not support compilation");
        }

        public override void Save(string path = null, bool saveInDatabase = false)
        {
            throw new NdapiException("Library module does not support saving");
        }
    }
}
