using System.Linq;
using System.Collections.Generic;

namespace Birbiz.WebServices.UserService.Converters
{
    public static class RoleConverter
    {
        public static Dictionary<string, bool> ToDictionary(IEnumerable<string> roles)
        {
            Dictionary<string, bool> dictionaryRoles = roles == null
                ? new Dictionary<string, bool>()
                : roles.ToDictionary(role => role, value => true);

            return dictionaryRoles;
        }
    }
}