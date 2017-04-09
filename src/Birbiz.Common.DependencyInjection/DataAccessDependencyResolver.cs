using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Birbiz.DataAccess.DataContracts;
using Birbiz.DataAccess.DataContracts.Initializers;
using Birbiz.DataAccess.SqlDataAccess;
using Birbiz.DataAccess.StartData;

namespace Birbiz.Common.DependencyInjection
{
    public static class DataAccessDependencyResolver
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IDatabaseInitializer, DatabaseInitializer>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}