using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Authentication;
using AspNet.Security.OpenIdConnect.Primitives;
using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Server;
using OpenIddict.Core;
using Birbiz.Common.Entities;
using Birbiz.WebServices.Auth.Configuration;
using Birbiz.WebServices.Auth.Resources;
using Birbiz.WebServices.Auth.Results;
using Birbiz.WebServices.Common.Controllers;

namespace Birbiz.WebServices.Auth.Controllers
{
    public class AuthorizationController : BaseController
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AuthorizationController(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpPost(AuthOptions.TokenEndpoint), Produces("application/json")]
        public async Task<IActionResult> Exchange(OpenIdConnectRequest request)
        {
            if (request.IsPasswordGrantType())
            {
                var user = await userManager.FindByNameAsync(request.Username);
                if (user == null)
                {
                    return Error(ErrorMessages.InvalidLoginOrPassword);
                }

                // Ensure the user is allowed to sign in.
                if (!await signInManager.CanSignInAsync(user))
                {
                    return Error(ErrorMessages.CannotSignIn);
                }

                // Reject the token request if two-factor authentication has been enabled by the user.
                if (userManager.SupportsUserTwoFactor && await userManager.GetTwoFactorEnabledAsync(user))
                {
                    return Error(ErrorMessages.TwoFactor);
                }

                // Ensure the user is not already locked out.
                if (userManager.SupportsUserLockout && await userManager.IsLockedOutAsync(user))
                {
                    return Error(ErrorMessages.Lockout);
                }

                // Ensure the password is valid.
                if (!await userManager.CheckPasswordAsync(user, request.Password))
                {
                    if (userManager.SupportsUserLockout)
                    {
                        await userManager.AccessFailedAsync(user);
                    }

                    return Error(ErrorMessages.InvalidLoginOrPassword);
                }

                if (userManager.SupportsUserLockout)
                {
                    await userManager.ResetAccessFailedCountAsync(user);
                }

                // Create a new authentication ticket.
                var ticket = await CreateTicketAsync(request, user);

                return SignIn(ticket.Principal, ticket.Properties, ticket.AuthenticationScheme);
            }

            return Error(ErrorMessages.PasswordGrantType);
        }

        private async Task<AuthenticationTicket> CreateTicketAsync(OpenIdConnectRequest request, ApplicationUser user)
        {
            // Create a new ClaimsPrincipal containing the claims that
            // will be used to create an id_token, a token or a code.
            var principal = await signInManager.CreateUserPrincipalAsync(user);

            // Note: by default, claims are NOT automatically included in the access and identity tokens.
            // To allow OpenIddict to serialize them, you must attach them a destination, that specifies
            // whether they should be included in access tokens, in identity tokens or in both.

            foreach (var claim in principal.Claims)
            {
                // In this sample, every claim is serialized in both the access and the identity tokens.
                // In a real world application, you'd probably want to exclude confidential claims
                // or apply a claims policy based on the scopes requested by the client application.
                claim.SetDestinations(OpenIdConnectConstants.Destinations.AccessToken,
                                      OpenIdConnectConstants.Destinations.IdentityToken);
            }

            // Create a new authentication ticket holding the user identity.
            var ticket = new AuthenticationTicket(
                principal, 
                new AuthenticationProperties(),
                OpenIdConnectServerDefaults.AuthenticationScheme);

            // Set the list of scopes granted to the client application.
            // Note: the offline_access scope must be granted
            // to allow OpenIddict to return a refresh token.
            ticket.SetScopes(new[]
            {
                OpenIdConnectConstants.Scopes.OpenId,
                OpenIdConnectConstants.Scopes.Email,
                OpenIdConnectConstants.Scopes.Profile,
                OpenIdConnectConstants.Scopes.OfflineAccess,
                OpenIddictConstants.Scopes.Roles
            }.Intersect(request.GetScopes()));

            return ticket;
        }

        private IActionResult Error(string message)
        {
            return JsonBadRequest(new LoginErrorResultValue(message));
        }
    }
}