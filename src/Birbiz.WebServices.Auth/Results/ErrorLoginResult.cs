using System;
using System.Net;
using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Identity;

namespace Birbiz.WebServices.Auth.Results
{
    public class ErrorLoginResult : BaseErrorResult
    {
        public bool IsLockedOut { get; protected set; }

        public bool IsNotAllowed { get; protected set; }

        public bool RequiresTwoFactor { get; protected set; }

        public ErrorLoginResult() : base((int)HttpStatusCode.BadRequest)
        {
        }

        public ErrorLoginResult(SignInResult signInResult) : this()
        {
            if (signInResult == null)
            {
                throw new ArgumentNullException(nameof(signInResult));
            }

            IsLockedOut = signInResult.IsLockedOut;
            IsNotAllowed = signInResult.IsNotAllowed;
            RequiresTwoFactor = signInResult.RequiresTwoFactor;
        }
    }
}