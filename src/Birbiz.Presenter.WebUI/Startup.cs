using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Birbiz.Common.DependencyInjection;
using Birbiz.WebServices.Auth.Extensions;
using Birbiz.WebServices.Common.Filters;

namespace Birbiz.Presenter.WebUI
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public bool IsDevelopment { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            Configuration = builder.Build();
            IsDevelopment = env.IsDevelopment();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddDataAccess(Configuration.GetConnectionString(Config.ConnectionStringDevName));

            services.AddAuthOpenId();

            services.AddMvc(options =>
            {
                if (!IsDevelopment)
                {
                    options.Filters.Add(new ExceptionFilterAttribute("Ошибка при выполнении операции. Пожалуйста, попробуйте позже."));
                }
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            if (IsDevelopment)
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseStaticFiles();

            app.UseAuthOpenId();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}