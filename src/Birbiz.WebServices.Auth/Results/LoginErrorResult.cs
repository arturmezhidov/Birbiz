using System.Net;
using Birbiz.WebServices.Auth.Validation;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class LoginErrorResult : BaseErrorResult
    {
        public LoginErrorResult() : base((int)HttpStatusCode.BadRequest)
        {
        }

        public LoginErrorResult(string errorMessage) : base((int)HttpStatusCode.BadRequest)
        {
            Add(ValidateCodes.SigninError, errorMessage);
        }
    }
}