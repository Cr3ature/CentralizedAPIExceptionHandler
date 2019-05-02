﻿namespace GenericApiExceptionManagement
{
    /// <summary>
    /// Supported error types.
    /// </summary>
    public enum ErrorType
    {
        ApplicationError,
        TechnicalError,
        BusinessError,
        ResourceError,
        ValidationError
    }
}