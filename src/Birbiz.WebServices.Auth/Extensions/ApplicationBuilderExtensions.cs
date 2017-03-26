using Microsoft.AspNetCore.Builder;

namespace Birbiz.WebServices.Auth.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseAuthOpenId(this IApplicationBuilder app)
        {
            // Add a middleware used to validate access
            // tokens and protect the API endpoints.
            app.UseOAuthValidation();

            // Alternatively, you can also use the introspection middleware.
            // Using it is recommended if your resource server is in a
            // different application/separated from the authorization server.
            //
            // app.UseOAuthIntrospection(options =>
            // {
            //     options.AutomaticAuthenticate = true;
            //     options.AutomaticChallenge = true;
            //     options.Authority = "http://localhost:58795/";
            //     options.Audiences.Add("resource_server");
            //     options.ClientId = "resource_server";
            //     options.ClientSecret = "875sqd4s5d748z78z7ds1ff8zz8814ff88ed8ea4z4zzd";
            // });
          
            app.UseOpenIddict(); 
        }
    }
}