using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Birbiz.DataAccess.SqlDataAccess
{
    public class TemporaryDataContextFactory : IDbContextFactory<DataContext>
    {
        private const string ConnectionStringName = "ConnectionStringDev";

        public DataContext Create(DbContextFactoryOptions options)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(options.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot config = builder.Build();

            var dbbuilder = new DbContextOptionsBuilder<DataContext>();
            dbbuilder.UseSqlServer(config.GetConnectionString(ConnectionStringName));
            return new DataContext(dbbuilder.Options);
        }
    }
}
