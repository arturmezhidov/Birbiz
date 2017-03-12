using Birbiz.Common.Entities;
using Birbiz.Common.Entities.Catalog;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Birbiz.DataAccess.SqlDataAccess
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        /* COMMON */

        public DbSet<ProfileUser> ProfileUsers { get; set; }

        //public DbSet<Company> Companies { get; set; }

        //public DbSet<Country> Countries { get; set; }
        //public DbSet<City> Cities { get; set; }
        //public DbSet<Region> Regions { get; set; }
        //public DbSet<Street> Streets { get; set; }
        //public DbSet<Home> Homes { get; set; }
        //public DbSet<Flat> Flats { get; set; }

        //public DbSet<Message> Messages { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Favorite> Favorites { get; set; }
        //public DbSet<Like> Likes { get; set; }
        //public DbSet<Rating> Ratings { get; set; }

        //public DbSet<EnumValue> EnumValues { get; set; }
        //public DbSet<RangeValue> RangeValues { get; set; }
        //public DbSet<MeasurementUnit> MeasurementUnits { get; set; }

        //public DbSet<Currency> Currencies { get; set; }
        //public DbSet<Rate> Rates { get; set; }

        //public DbSet<Folder> Folders { get; set; }
        //public DbSet<File> Files { get; set; }

        /* CATALOG */

        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<ProductGroup> ProductGroups { get; set; }
        //public DbSet<ProductSchema> ProductSchemas { get; set; }
        //public DbSet<Product> Products { get; set; }

        //public DbSet<ProductAttributeGroup> ProductAttributeGroups { get; set; }
        //public DbSet<ProductAttributeSchema> ProductAttributeSchemas { get; set; }
        //public DbSet<ProductAttribute> ProductAttributes { get; set; }
        //public DbSet<ProductAttributeEnumValue> ProductAttributeEnumValues { get; set; }
        //public DbSet<ProductAttributeRangeValue> ProductAttributeRangeValues { get; set; }

        //public DbSet<ProductOrder> ProductOrders { get; set; }
        //public DbSet<Discount> Discounts { get; set; }

        //public DbSet<Shop> Shops { get; set; }
        //public DbSet<ShopProduct> ShopProducts { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}