using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Birbiz.Common.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ProfileUser Profile { get; set; }
    }
}