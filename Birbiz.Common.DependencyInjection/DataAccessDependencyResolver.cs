using Birbiz.DataAccess.DataContracts;
using Birbiz.DataAccess.SqlDataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Birbiz.Common.DependencyInjection
{
    public static class DataAccessDependencyResolver
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IUnitOfWork>(provider => new UnitOfWork(connectionString));
            return services;
        }
    }
}