using System;
using System.IO;
using Birbiz.DataAccess.DataContracts;
using Birbiz.Common.DependencyInjection;
using Birbiz.Common.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
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

        [Fact]
        public void AddRegionTest()
        {
            var repo = UnitOfWork.GetRepository<Region>();
            var country = UnitOfWork.GetRepository<Country>().GetById(1);

            var region = repo.Create(new Region
            {
                IsDeleted = false,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
                Name = "Region",
                UpdatedBy = 1,
                Country = country,
                CountryId = country.Id
            });

            UnitOfWork.Save();

            Assert.True(region != null && region.Id > 0);
        }
    }
}
