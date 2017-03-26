using System.Net;
using Microsoft.AspNetCore.Identity;
using Birbiz.WebServices.Auth.Validation;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class LoginErrorResult : BaseErrorResult
    {
        public bool IsLockedOut { get; protected set; }

        public bool IsNotAllowed { get; protected set; }

        public bool RequiresTwoFactor { get; protected set; }

        public LoginErrorResult() : base((int)HttpStatusCode.BadRequest)
        {
        }

        public LoginErrorResult(string errorMessage, SignInResult signInResult = null) : base((int)HttpStatusCode.BadRequest)
        {
            Add(ValidateCodes.SigninError, errorMessage);

            if (signInResult != null)
            {
                IsLockedOut = signInResult.IsLockedOut;
                IsNotAllowed = signInResult.IsNotAllowed;
                RequiresTwoFactor = signInResult.RequiresTwoFactor;
            }
        }
    }
}