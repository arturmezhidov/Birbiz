using System;
using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public class InternalServerError : BaseErrorResult
    {
        public InternalServerError(string message) : base((int)HttpStatusCode.InternalServerError)
        {
            Add(nameof(message), message);
        }

        public InternalServerError(Exception exception) : this(exception.Message)
        {
        }
    }
}