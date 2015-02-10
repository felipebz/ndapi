using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Metadata;
using System.IO;
using System.Linq;

namespace Ndapi
{
    /// <summary>
    /// Represents a generic module.
    /// </summary>
    public abstract class NdapiModule : BaseNdapiObject
    {
        //internal NdapiModule()
        //{
        //}

        internal NdapiModule(string name, ObjectType type, BaseNdapiObject parent = null) : base(name, type, parent)
        {
        }

        internal NdapiModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Load the module into memory.
        /// </summary>
        /// <param name="filename">Module location (.fmb, .olb, .mmb or .pll file)</param>
        /// <returns>Loaded module reference.</returns>
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
                case ".PLL":
                    return LibraryModule.Open(filename);
                default:
                    throw new NdapiException($"The file {filename} does not have a valid extension.");
            }
        }

        /// <summary>
        /// Save the module to disk.
        /// </summary>
        /// <param name="path">Location to save.</param>
        /// <param name="saveInDatabase">Should save module in database.</param>
        public abstract void Save(string path = null, bool saveInDatabase = false);

        /// <summary>
        /// Compile the module.
        /// </summary>
        public abstract void CompileFile();

        /// <summary>
        /// Compile PL/SQL code in the module.
        /// </summary>
        public abstract void CompileObjects();

        /// <summary>
        /// Convert the module to text.
        /// </summary>
        /// <param name="filename">File to convert.</param>
        public static void ConvertToText<T>(string filename) where T : NdapiModule
        {
            var type = NdapiMetadata.ObjectTypeMapping.Single(t => t.Value == typeof(T)).Key;
            var status = NativeMethods.d2fctxcf_ConvertFile(NdapiContext.Context, filename, type, NdapiConstants.BINTOTEXT);
            Ensure.Success(status);
        }

        /// <summary>
        /// Convert the text file to a binary module.
        /// </summary>
        /// <param name="filename">File to convert.</param>
        public static void ConvertFromText<T>(string filename) where T : NdapiModule
        {
            var type = NdapiMetadata.ObjectTypeMapping.Single(t => t.Value == typeof(T)).Key;
            var status = NativeMethods.d2fctxcf_ConvertFile(NdapiContext.Context, filename, type, NdapiConstants.TEXTTOBIN);
            Ensure.Success(status);
        }
    }
}
