using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.SqlDataAccess;
using Birbiz.WebServices.Auth.Configuration;

namespace Birbiz.WebServices.Auth.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void AddAuthOpenId(this IServiceCollection services)
        {
            services.Configure<DbContextOptionsBuilder>(options =>
            {
                // Register the entity sets needed by OpenIddict.
                // Note: use the generic overload if you need
                // to replace the default OpenIddict entities.
                options.UseOpenIddict();
            });

            // Register the Identity services.
            services.AddIdentity<ApplicationUser, IdentityRole>(opts => {
                    opts.Password.RequiredLength = AuthOptions.PasswordMinLength;
                    opts.Password.RequireLowercase = AuthOptions.PasswordRequireLowercase;
                    opts.Password.RequireUppercase = AuthOptions.PasswordRequireUppercase;
                    opts.Password.RequireDigit = AuthOptions.PasswordRequireDigit;
                    opts.Password.RequireNonAlphanumeric = AuthOptions.PasswordRequireNonAlphanumeric;
                })
                .AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

            // Configure Identity to use the same JWT claims as OpenIddict instead
            // of the legacy WS-Federation claims it uses by default (ClaimTypes),
            // which saves you from doing the mapping in your authorization controller.
            services.Configure<IdentityOptions>(options =>
            {
                options.ClaimsIdentity.UserNameClaimType = AuthOptions.UserNameClaimType;
                options.ClaimsIdentity.UserIdClaimType = AuthOptions.UserIdClaimType;
                options.ClaimsIdentity.RoleClaimType = AuthOptions.RoleClaimType;
            });

            // Register the OpenIddict services.
            services.AddOpenIddict()

                // Register the Entity Framework stores.
                .AddEntityFrameworkCoreStores<DataContext>()

                // Register the ASP.NET Core MVC binder used by OpenIddict.
                // Note: if you don't call this method, you won't be able to
                // bind OpenIdConnectRequest or OpenIdConnectResponse parameters.
                .AddMvcBinders()

                // Enable the token endpoint.
                .EnableTokenEndpoint(AuthOptions.TokenEndpoint)

                // Enable the password flow.
                .AllowPasswordFlow()

                // During development, you can disable the HTTPS requirement.
                .DisableHttpsRequirement();
        }
    }
}