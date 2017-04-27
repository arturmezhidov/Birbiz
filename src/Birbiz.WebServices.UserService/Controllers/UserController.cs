using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Birbiz.WebServices.Common.Controllers;
using Birbiz.WebServices.UserService.Models.User;
using Birbiz.WebServices.UserService.Converters;

namespace Birbiz.WebServices.UserService.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        public IActionResult UserInfo()
        {
            UserInfo userInfo = new UserInfo
            {
                UserName = ApplicationUser.UserName,
                Email = ApplicationUser.Email,
                Roles = RoleConverter.ToDictionary(UserManager.GetRolesAsync(ApplicationUser).Result)
            };

            return JsonOk(userInfo);
        }
    }
}