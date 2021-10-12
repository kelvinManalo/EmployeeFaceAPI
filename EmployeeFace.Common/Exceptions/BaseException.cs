using EmployeeFace.Common.Entities;
using System;

namespace EmployeeFace.Common.Exceptions
{
    public class BaseException : Exception
    {
        public ErrorResponse ErrorResponse { get; }

        public BaseException(ErrorResponse errorResponse)
        {
            ErrorResponse = errorResponse;
        }
    }
}
