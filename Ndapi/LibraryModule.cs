using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a program unit library.
    /// </summary>
    public class LibraryModule : NdapiModule
    {
        internal LibraryModule(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets all the attached libraries.
        /// </summary>
        [Property(NdapiConstants.D2FP_ATT_LIB)]
        public IEnumerable<AttachedLibrary> AttachedLibraries => GetObjectList<AttachedLibrary>(NdapiConstants.D2FP_ATT_LIB);

        /// <summary>
        /// Gets the library location.
        /// </summary>
        [Property(NdapiConstants.D2FP_LIB_LOC)]
        public string Location => GetStringProperty(NdapiConstants.D2FP_LIB_LOC);

        /// <summary>
        /// Gets all the program units.
        /// </summary>
        [Property(NdapiConstants.D2FP_LIB_PROG_UNIT)]
        public IEnumerable<LibraryProgramUnit> ProgramUnits => GetObjectList<LibraryProgramUnit>(NdapiConstants.D2FP_LIB_PROG_UNIT);

        /// <summary>
        /// Gets the source type.
        /// </summary>
        [Property(NdapiConstants.D2FP_LIB_SRC)]
        public SourceType SourceType => GetNumberProperty<SourceType>(NdapiConstants.D2FP_LIB_SRC);

        /// <summary>
        /// Load the program unit library into memory.
        /// </summary>
        /// <param name="filename">Library location (.pll file)</param>
        /// <returns>Loaded library reference.</returns>
        public new static LibraryModule Open(string filename)
        {
            ObjectSafeHandle library;

            var status = NativeMethods.d2flibld_Load(NdapiContext.Context, out library, filename, false);
            Ensure.Success(status);

            return new LibraryModule(library);
        }

        /// <summary>
        /// Program unit libraries does not support compilation.
        /// </summary>
        public override void CompileFile()
        {
            throw new NotSupportedException("Library module does not support compilation");
        }

        /// <summary>
        /// Program unit libraries does not support compilation.
        /// </summary>
        public override void CompileObjects()
        {
            throw new NotSupportedException("Library module does not support compilation");
        }

        /// <summary>
        /// Program unit libraries does not support saving.
        /// </summary>
        public override void Save(string path = null, bool saveInDatabase = false)
        {
            throw new NotSupportedException("Library module does not support saving");
        }
    }
}
