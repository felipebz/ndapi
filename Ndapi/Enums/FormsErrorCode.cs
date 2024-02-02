namespace Ndapi.Enums;

public enum FormsErrorCode
{
    /// <summary>
    /// Operation Succeeded
    /// </summary>
    Success = 0,

    /// <summary>
    /// Operation Failed
    /// </summary>
    Fail = 1,

    /// <summary>
    /// Operation returned YES
    /// </summary>
    Yes = 2,

    /// <summary>
    /// Operation returned NO
    /// </summary>
    No = 3,

    /// <summary>
    /// Bad context provided
    /// </summary>
    BadContext = 4,

    /// <summary>
    /// Bad property
    /// </summary>
    BadProperty = 5,

    /// <summary>
    /// One of the args is wrong
    /// </summary>
    BadArgument = 6,

    /// <summary>
    /// Object type is unknown
    /// </summary>
    BadType = 7,

    /// <summary>
    /// Unexpected object
    /// </summary>
    WrongObject = 8,

    /// <summary>
    /// Unexpected parent
    /// </summary>
    WrongParent = 9,

    /// <summary>
    /// Null object passed
    /// </summary>
    NullObject = 10,

    /// <summary>
    /// Null pointer to object
    /// </summary>
    NullContainer = 11,

    /// <summary>
    /// Null property
    /// </summary>
    NullProperty = 12,

    /// <summary>
    /// Not connected to DB
    /// </summary>
    NotConnected = 13,

    /// <summary>
    /// Out of memory
    /// </summary>
    NoMemory = 14,

    /// <summary>
    /// Message file not found
    /// </summary>
    NoMessageFile = 15,

    /// <summary>
    /// Generation failed
    /// </summary>
    GenerationFailed = 16,

    /// <summary>
    /// Not implemented yet
    /// </summary>
    NotImplemented = 17,

    /// <summary>
    /// Passed in type does not match the actual object
    /// </summary>
    TypeMismatch = 18,

    /// <summary>
    /// The operation failed partially, but the error was not fatal
    /// </summary>
    Warning = 19,

    /// <summary>
    /// Null Data Passed in
    /// </summary>
    NullData = 20,

    /// <summary>
    /// Data Passed in is invalid
    /// </summary>
    InvalidData = 21,

    /// <summary>
    /// Index in is invalid
    /// </summary>
    InvalidIndex = 22,

    /// <summary>
    /// The Object does not have the given property
    /// </summary>
    PropertyDoesNotExist = 23,

    /// <summary>
    /// Initialization failed because a NULL Instance Handle passed
    /// </summary>
    NoInstanceHandle = 24,

    /// <summary>
    /// The operation failed because the object being created/placed was not not unique. An object with this name already exists
    /// </summary>
    ObjectNotUnique = 25,

    /// <summary>
    /// The Object was not found
    /// </summary>
    ObjectNotFound = 26,

    /// <summary>
    /// Function can only be called in translation mode
    /// </summary>
    NotInTranslationMode = 27,

    /// <summary>
    /// The database context passed in is invalid
    /// </summary>
    BadDatabaseContext = 28,

    /// <summary>
    /// A subclassed module could not be found during loading
    /// </summary>
    MissingSubclassedModule = 29,

    /// <summary>
    /// Duplicate String ID This slot in the string table has already been used
    /// </summary>
    SuplicateStringId = 30,

    /// <summary>
    /// A supplied value parameter was out of the legal range
    /// </summary>
    ValueOutOfRange = 31,

    /// <summary>
    /// The specified file was not found
    /// </summary>
    FileNotFound = 32,

    /// <summary>
    /// An attached library could not be found
    /// </summary>
    MissingLibraryModule = 33
}
