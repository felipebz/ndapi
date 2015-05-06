using Ndapi.Enums;
using System;
#if !NETCORE
using System.Runtime.Serialization;
#endif
namespace Ndapi
{
    /// <summary>
    /// The exception that is thrown when an error occurs during application execution.
    /// </summary>
#if !NETCORE
    [Serializable]
#endif
    public class NdapiException : Exception
    {
        /// <summary>
        /// Gets the internal Forms API error code.
        /// </summary>
        public D2fErrorCode ErrorCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NdapiException"/> class.
        /// </summary>
        public NdapiException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NdapiException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public NdapiException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NdapiException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public NdapiException(string message, Exception inner) : base(message, inner)
        {
        }

#if !NETCORE
        /// <summary>
        /// Initializes a new instance of the <see cref="NdapiException"/> class with a serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected NdapiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        internal NdapiException(string message, D2fErrorCode code) : this(message)
        {
            ErrorCode = code;
            Data.Add("ndapi.code", (int)ErrorCode);
        }
#endif
    }
}
