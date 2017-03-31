using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Birbiz.Common.Entities;
using Birbiz.WebServices.Common.Controllers;
using Birbiz.WebServices.Auth.Models.AccountViewModels;
using Birbiz.WebServices.Auth.Results;

namespace Birbiz.WebServices.Auth.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger logger;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory)
        {
            this.userManager = userManager;
            logger = loggerFactory.CreateLogger<AccountController>();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Login };

            var result = await userManager.CreateAsync(user, model.Password);

            if(result.Succeeded)
            {
                return Json(new RegisterResult());
            }

            return Json(new RegisterErrorResult(result));
        }
    }
}