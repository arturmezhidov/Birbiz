using System.Collections.Generic;

namespace Birbiz.WebServices.UserService.Models.User
{
    public class UserInfo
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public Dictionary<string, bool> Roles { get; set; }
    }
}