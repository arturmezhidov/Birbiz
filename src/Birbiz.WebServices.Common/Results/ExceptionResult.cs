using System;
using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public class ExceptionResult : ErrorResult
    {
        public override int StatusCode { get { return (int)HttpStatusCode.InternalServerError; } }

        public override bool HasError { get { return !string.IsNullOrEmpty(ErrorMessage); } }

        public string ErrorMessage { get; set; }

        public ExceptionResult(string errorMessage)
        {
            if (errorMessage == null)
            {
                throw new ArgumentNullException(nameof(errorMessage));
            }

            ErrorMessage = errorMessage;
        }

        public ExceptionResult(Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            ErrorMessage = exception.Message;
        }
    }
}