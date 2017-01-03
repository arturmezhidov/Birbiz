using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Birbiz.DataAccess.DataContracts;
using Birbiz.Common.DependencyInjection;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.SqlDataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.Configuration;

namespace Birbiz.DataAccess.SqlDataAccessTest
{
    public class UnitOfWorkTest
    {
        private const string connectionStringName = "TestConnection";
        protected IUnitOfWork UnitOfWork { get; set; }

        public UnitOfWorkTest()
        {
            string path = Directory.GetCurrentDirectory();
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                //.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            IConfigurationRoot config = builder.Build();

            IServiceCollection services = new ServiceCollection()
                .AddDataAccess(config.GetConnectionString(connectionStringName));

            IServiceProvider provider = services.BuildServiceProvider();
            UnitOfWork = provider.GetService<IUnitOfWork>();
        }

        [Fact]
        public void AddCountryTest()
        {
            var repo = UnitOfWork.GetRepository<Country>();

            var country = repo.Create(new Country()
            {
                IsDeleted = false,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
                Name = "dsdasdas",
                UpdatedBy = 1
            });

            UnitOfWork.Save();

            Assert.True(country != null && country.Id > 0);
        }
    }
}
