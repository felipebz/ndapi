﻿using System;

using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// The exception that is thrown when an error occurs during application execution.
/// </summary>
[Serializable]
public sealed class NdapiException : Exception
{
    /// <summary>
    /// Gets the internal Forms API error code.
    /// </summary>
    public FormsErrorCode ErrorCode { get; }

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

    internal NdapiException(string message, FormsErrorCode code) : this(message)
    {
        ErrorCode = code;
        Data.Add("ndapi.code", (int)ErrorCode);
    }
}
