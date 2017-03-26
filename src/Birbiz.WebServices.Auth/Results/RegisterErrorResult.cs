using System;
using System.Net;
using Birbiz.WebServices.Auth.Validation;
using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Identity;

namespace Birbiz.WebServices.Auth.Results
{
    public class RegisterErrorResult : BaseErrorResult
    {
        public RegisterErrorResult(IdentityResult result) : base((int)HttpStatusCode.BadRequest)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            Init(result);
        }

        protected void Init(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                switch (error.Code)
                {
                    case ValidateCodes.DuplicateUserName:
                        {
                            Add(ValidateCodes.DuplicateUserName, Resources.ErrorMessages.DuplicateUserName);
                            break;
                        }
                    case ValidateCodes.PasswordRequiresDigit:
                        {
                            Add(ValidateCodes.PasswordRequiresDigit, Resources.ErrorMessages.PasswordRequiresDigit);
                            break;
                        }
                    case ValidateCodes.PasswordRequiresLower:
                        {
                            Add(ValidateCodes.PasswordRequiresLower, Resources.ErrorMessages.PasswordRequiresLower);
                            break;
                        }
                    case ValidateCodes.PasswordRequiresUpper:
                        {
                            Add(ValidateCodes.PasswordRequiresUpper, Resources.ErrorMessages.PasswordRequiresUpper);
                            break;
                        }
                    case ValidateCodes.PasswordRequiresNonAlphanumeric:
                        {
                            Add(ValidateCodes.PasswordRequiresNonAlphanumeric, Resources.ErrorMessages.PasswordRequiresNonAlphanumeric);
                            break;
                        }
                    default:
                        {
                            Add(error.Code, error.Description);
                            break;
                        }
                }
            }
        }
    }
}