using Birbiz.WebServices.Auth.Validation;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class LoginErrorResultValue : ErrorResultValue
    {
        public LoginErrorResultValue()
        {
        }

        public LoginErrorResultValue(string errorMessage)
        {
            Add(errorMessage);
        }

        public void Add(string errorMessage)
        {
            Add(ValidateCodes.SigninError, errorMessage);
        }
    }
}