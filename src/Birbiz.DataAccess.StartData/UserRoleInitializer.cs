using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Birbiz.DataAccess.StartData
{
    public class UserRoleInitializer : BaseInitializerEntityCollection<IdentityRole>
    {
        protected override IEnumerable<IdentityRole> GetEntities()
        {
            return new List<IdentityRole>
            {
                new IdentityRole("superadmin") { NormalizedName = "SUPERADMIN" },
                new IdentityRole("useradmin") { NormalizedName = "USERADMIN" },
                new IdentityRole("catalogadmin") { NormalizedName = "CATALOGADMIN" },
                new IdentityRole("auctionadmin") { NormalizedName = "AUCTIONADMIN" },
                new IdentityRole("automobileadmin") { NormalizedName = "AUTOMOBILEADMIN" },
                new IdentityRole("realestateadmin") { NormalizedName = "REALESTATEADMIN" },
                new IdentityRole("forumadmin") { NormalizedName = "FORUMADMIN" },
                new IdentityRole("blogadmin") { NormalizedName = "BLOGADMIN" },
                new IdentityRole("newsadmin") { NormalizedName = "NEWSADMIN" },
                new IdentityRole("commentmoderator") { NormalizedName = "COMMENTMODERATOR" }
            };
        }
    }
}