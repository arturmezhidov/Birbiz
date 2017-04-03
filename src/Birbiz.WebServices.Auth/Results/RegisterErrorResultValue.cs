using System;
using Microsoft.AspNetCore.Identity;
using Birbiz.WebServices.Auth.Validation;
using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Auth.Results
{
    public class RegisterErrorResultValue : ErrorResultValue
    {
        private readonly IdentityResult identity;

        public RegisterErrorResultValue(IdentityResult result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            identity = result;
        }

        protected override void OnExecuting(ActionContext context)
        {
            foreach (IdentityError error in identity.Errors)
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