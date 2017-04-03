using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Birbiz.WebServices.Common.Controllers;
using Birbiz.WebServices.UserService.Models.User;

namespace Birbiz.WebServices.UserService.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        public IActionResult UserInfo()
        {
            UserInfoViewModel vm = new UserInfoViewModel
            {
                Login = User.Identity?.Name
            };

            return JsonOk(vm);
        }
    }
}