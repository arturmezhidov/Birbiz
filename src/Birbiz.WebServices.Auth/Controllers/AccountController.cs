using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Birbiz.Common.Entities;
using Birbiz.WebServices.Auth.Models.AccountViewModels;
using Birbiz.WebServices.Auth.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Birbiz.WebServices.Common.Controllers;

namespace Birbiz.WebServices.Auth.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger logger;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            logger = loggerFactory.CreateLogger<AccountController>();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Ok(result);
            }

            ErrorLoginResult errorLoginResult = new ErrorLoginResult(result);

            if (errorLoginResult.IsLockedOut)
            {
                errorLoginResult.Add("isLockedOut", new []{ "Аккаунт заблокирован." });
            }
            else
            {
                errorLoginResult.Add("", new[] { "Неправильный логин или пароль." });
            }

            return Json(errorLoginResult);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Login };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                    // Send an email with this link
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                    //await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
                    //    $"Please confirm your account by clicking this link: <a href='{callbackUrl}'>link</a>");
                    await signInManager.SignInAsync(user, isPersistent: false);
                    logger.LogInformation(3, "User created a new account with password.");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Json(ModelState);
        }
    }
}