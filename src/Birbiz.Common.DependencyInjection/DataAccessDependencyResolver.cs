using Birbiz.DataAccess.DataContracts;
using Birbiz.DataAccess.SqlDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Birbiz.Common.DependencyInjection
{
    public static class DataAccessDependencyResolver
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}