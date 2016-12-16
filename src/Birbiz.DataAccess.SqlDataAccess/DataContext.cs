using Birbiz.Common.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Birbiz.DataAccess.SqlDataAccess
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
    }
}