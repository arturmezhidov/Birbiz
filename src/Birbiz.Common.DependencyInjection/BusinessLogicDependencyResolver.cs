using Microsoft.Extensions.DependencyInjection;
using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.BusinessLogic.CommonComponents;

namespace Birbiz.Common.DependencyInjection
{
    public static class BusinessLogicDependencyResolver
    {
        public static IServiceCollection AddBusinessComponents(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseService, DatabaseService>();

            return services;
        }
    }
}