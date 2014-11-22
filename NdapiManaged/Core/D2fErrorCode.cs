using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NdapiManaged.Core
{
    internal enum D2fErrorCode
    {
        /// <summary>
        /// Operation Succeeded
        /// </summary>
        D2FS_SUCCESS = 0,

        /// <summary>
        /// Operation Failed
        /// </summary>
        D2FS_FAIL = 1,

        /// <summary>
        /// Operation returned YES
        /// </summary>
        D2FS_YES = 2,

        /// <summary>
        /// Operation returned NO
        /// </summary>
        D2FS_NO = 3,

        /// <summary>
        /// Bad context provided
        /// </summary>
        D2FS_BADCONTEXT = 4,

        /// <summary>
        /// Bad property
        /// </summary>
        D2FS_BADPROP = 5,

        /// <summary>
        /// One of the args is wrong
        /// </summary>
        D2FS_BADARG = 6,

        /// <summary>
        /// Object type is unknown
        /// </summary>
        D2FS_BADTYPE = 7,

        /// <summary>
        /// Unexpected object
        /// </summary>
        D2FS_WRONGOBJ = 8,

        /// <summary>
        /// Unexpected parent
        /// </summary>
        D2FS_WRONGPARENT = 9,

        /// <summary>
        /// Null object passed
        /// </summary>
        D2FS_NULLOBJ = 10,

        /// <summary>
        /// Null pointer to object
        /// </summary>
        D2FS_NULLCONTAINER = 11,

        /// <summary>
        /// Null property
        /// </summary>
        D2FS_NULLPROP = 12,

        /// <summary>
        /// Not connected to DB
        /// </summary>
        D2FS_NOTCONNECTED = 13,

        /// <summary>
        /// Out of memory
        /// </summary>
        D2FS_NOMEMORY = 14,

        /// <summary>
        /// Message file not found
        /// </summary>
        D2FS_NOMSGFILE = 15,

        /// <summary>
        /// Generation failed
        /// </summary>
        D2FS_GENFAILED = 16,

        /// <summary>
        /// Not implemented yet
        /// </summary>
        D2FS_NOTIMPLEMENTED = 17,

        /// <summary>
        /// Passed in type does not match the actual object
        /// </summary>
        D2FS_TYPEMISMATCH = 18,

        /// <summary>
        /// The operation failed partially, but the error was not fatal
        /// </summary>
        D2FS_WARN = 19,

        /// <summary>
        /// Null Data Passed in
        /// </summary>
        D2FS_NULLDATA = 20,

        /// <summary>
        /// Data Passed in is invalid
        /// </summary>
        D2FS_INVALIDDATA = 21,

        /// <summary>
        /// Index in is invalid
        /// </summary>
        D2FS_INVALIDINDEX = 22,

        /// <summary>
        /// The Object does not have the given property
        /// </summary>
        D2FS_DONTHAVE = 23,

        /// <summary>
        /// Initialization failed because a NULL Instance Handle passed
        /// </summary>
        D2FS_NOINSTANCEHANDLE = 24,

        /// <summary>
        /// The operation failed because the object being created/placed was not not unique. An object with this name already exists
        /// </summary>
        D2FS_OBJNOTUNIQUE = 25,

        /// <summary>
        /// The Object was not found
        /// </summary>
        D2FS_OBJNOTFOUND = 26,

        /// <summary>
        /// Function can only be called in translation mode
        /// </summary>
        D2FS_NOTTRANSMODE = 27,

        /// <summary>
        /// The database context passed in is invalid
        /// </summary>
        D2FS_BADDBCTX = 28,

        /// <summary>
        /// A subclassed module could not be found during loading
        /// </summary>
        D2FS_MISSINGSUBCLMOD = 29,

        /// <summary>
        /// Duplicate String ID This slot in the string table has already been used
        /// </summary>
        D2FS_DUPSTRID = 30,

        /// <summary>
        /// A supplied value parameter was out of the legal range
        /// </summary>
        D2FS_VALUEOUTOFRANGE = 31,

        /// <summary>
        /// The specified file was not found
        /// </summary>
        /// </summary>
        D2FS_FILENOTFOUND = 32,

        /// <summary>
        /// An attached library could not be found
        /// </summary>
        D2FS_MISSINGLIBMOD = 33,
    }
}