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
            UserInfo userInfo = new UserInfo
            {
                UserName = ApplicationUser.UserName,
                Email = ApplicationUser.Email,
                Roles = UserManager.GetRolesAsync(ApplicationUser).Result
            };

            return JsonOk(userInfo);
        }        
    }
}