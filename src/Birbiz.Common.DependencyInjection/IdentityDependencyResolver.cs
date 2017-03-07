using Birbiz.Common.Entities;
using Birbiz.DataAccess.SqlDataAccess;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Birbiz.Common.DependencyInjection
{
    public static class IdentityDependencyResolver
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}