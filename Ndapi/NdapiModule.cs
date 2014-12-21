using System.IO;
using Ndapi.Core.Handles;

namespace Ndapi
{
    public abstract class NdapiModule : NdapiObject
    {
        internal NdapiModule()
        {
        }

        internal NdapiModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        public static NdapiModule Open(string filename)
        {
            var extension = Path.GetExtension(filename).ToUpper(); ;
            switch (extension)
            {
                case ".FMB":
                    return FormModule.Open(filename);
                case ".OLB":
                    return ObjectLibrary.Open(filename);
                case ".MMB":
                    return MenuModule.Open(filename);
                default:
                    throw new NdapiException(string.Format("The file {0} does not have a valid extension.", filename));
            }
        }

        public abstract void Save(string path = null, bool saveInDatabase = false);

        public abstract void CompileFile();

        public abstract void CompileObjects();
    }
}
