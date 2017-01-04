using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Birbiz.DataAccess.SqlDataAccess;

namespace Birbiz.DataAccess.SqlDataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Birbiz.Common.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPresent");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ShopProductId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UpdatedBy");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ShopProductId")
                        .IsUnique();

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DisplayName");

                    b.Property<string>("HelpInfo");

                    b.Property<string>("HtmlContent");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ManufactureId");

                    b.Property<int>("SchemaId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("SchemaId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int?>("ProductId");

                    b.Property<int>("SchemaId");

                    b.Property<int>("UpdatedBy");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SchemaId");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeEnumValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeSchemaId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EnumValueId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("AttributeSchemaId");

                    b.HasIndex("EnumValueId");

                    b.ToTable("ProductAttributeEnumValues");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DisplayName");

                    b.Property<string>("HelpInfo");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ProductSchemaId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProductSchemaId");

                    b.ToTable("ProductAttributeGroups");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeRangeValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeSchemaId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("RangeValueId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("AttributeSchemaId");

                    b.HasIndex("RangeValueId");

                    b.ToTable("ProductAttributeRangeValues");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeSchema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeGroupId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DisplayName");

                    b.Property<string>("HelpInfo");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("MeasurementUnitId");

                    b.Property<int>("UpdatedBy");

                    b.Property<int>("ValueType");

                    b.HasKey("Id");

                    b.HasIndex("AttributeGroupId");

                    b.HasIndex("MeasurementUnitId");

                    b.ToTable("ProductAttributeSchemas");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("FriendlyName");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("FriendlyName");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ProductId");

                    b.Property<int>("ProfileUserId");

                    b.Property<int?>("ShopId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProfileUserId");

                    b.HasIndex("ShopId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductSchema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("FriendlyName");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("ProductSchemas");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CurrencyId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("ProfileUserId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ProfileUserId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ShopProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<decimal>("Price");

                    b.Property<int?>("ProductId");

                    b.Property<int>("ShopId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopProducts");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("RegionId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ParentId");

                    b.Property<int>("TargetId");

                    b.Property<string>("Text");

                    b.Property<int>("Type");

                    b.Property<int>("UpdatedBy");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Symbol");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.EnumValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("EnumValues");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("TargetId");

                    b.Property<int>("Type");

                    b.Property<int>("UpdatedBy");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("EnablePublishPeriod");

                    b.Property<string>("Extension");

                    b.Property<string>("FileName");

                    b.Property<int>("FolderId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<DateTime?>("PublishedEndDate");

                    b.Property<DateTime>("PublishedStartDate");

                    b.Property<int>("PublishedVersion");

                    b.Property<string>("SHA1Hash");

                    b.Property<int>("Size");

                    b.Property<string>("Title");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("HomeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("Number");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FolderPath");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int?>("ParentFolderId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ParentFolderId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Block");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<int>("Number");

                    b.Property<int>("StreetId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int?>("ProfileUserId");

                    b.Property<int>("TargetId");

                    b.Property<int>("Type");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProfileUserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.MeasurementUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Title");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnits");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsRead");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("ReceiverType");

                    b.Property<int>("SenderId");

                    b.Property<int>("SenderType");

                    b.Property<string>("Text");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.ProfileUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("MiddleName");

                    b.Property<int>("UpdatedBy");

                    b.Property<string>("WebSiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("ProfileUsers");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.RangeValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<double>("MaxValue");

                    b.Property<double>("MinValue");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("RangeValues");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Coefficient");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FirstCurrencyId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<double>("Ratio");

                    b.Property<int>("SecondCurrencyId");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("TargetId");

                    b.Property<int>("Type");

                    b.Property<int>("UpdatedBy");

                    b.Property<int>("UserId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FlatId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("UpdatedBy");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Discount", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ShopProduct", "ShopProduct")
                        .WithOne("Discount")
                        .HasForeignKey("Birbiz.Common.Entities.Catalog.Discount", "ShopProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Product", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.Company", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductSchema", "Schema")
                        .WithMany("Products")
                        .HasForeignKey("SchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttribute", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.Product", "Product")
                        .WithMany("Attributes")
                        .HasForeignKey("ProductId");

                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductAttributeSchema", "Schema")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("SchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeEnumValue", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductAttributeSchema", "AttributeSchema")
                        .WithMany("AttributeEnumValue")
                        .HasForeignKey("AttributeSchemaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.EnumValue", "EnumValue")
                        .WithMany()
                        .HasForeignKey("EnumValueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeGroup", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductSchema", "ProductSchema")
                        .WithMany("AttributeGroups")
                        .HasForeignKey("ProductSchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeRangeValue", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductAttributeSchema", "AttributeSchema")
                        .WithMany("AttributeRangeValue")
                        .HasForeignKey("AttributeSchemaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.RangeValue", "RangeValue")
                        .WithMany()
                        .HasForeignKey("RangeValueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductAttributeSchema", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductAttributeGroup", "AttributeGroup")
                        .WithMany("AttributeSchemas")
                        .HasForeignKey("AttributeGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.MeasurementUnit", "MeasurementUnit")
                        .WithMany()
                        .HasForeignKey("MeasurementUnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductGroup", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductCategory", "Category")
                        .WithMany("Groups")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductOrder", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "ProfileUser")
                        .WithMany("Orders")
                        .HasForeignKey("ProfileUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.Catalog.Shop", "Shop")
                        .WithMany("Orders")
                        .HasForeignKey("ShopId");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ProductSchema", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.ProductGroup", "Group")
                        .WithMany("ProductSchemas")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.Shop", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Flat", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "ProfileUser")
                        .WithMany("Shops")
                        .HasForeignKey("ProfileUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Catalog.ShopProduct", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Catalog.Product", "Product")
                        .WithMany("ShopProducts")
                        .HasForeignKey("ProductId");

                    b.HasOne("Birbiz.Common.Entities.Catalog.Shop", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.City", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Comment", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Favorite", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.File", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Folder", "Folder")
                        .WithMany("Files")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Flat", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Home", "Home")
                        .WithMany("Flats")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Folder", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Folder", "ParentFolder")
                        .WithMany()
                        .HasForeignKey("ParentFolderId");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Home", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Street", "Street")
                        .WithMany("Homes")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Like", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ProfileUser")
                        .WithMany("Likes")
                        .HasForeignKey("ProfileUserId");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.ProfileUser", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ApplicationUser", "ApplicationUser")
                        .WithOne("Profile")
                        .HasForeignKey("Birbiz.Common.Entities.ProfileUser", "ApplicationUserId");
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Rating", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Region", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.Street", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.City", "City")
                        .WithMany("Streets")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Birbiz.Common.Entities.UserAddress", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.Flat", "Flat")
                        .WithMany()
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.ProfileUser", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Birbiz.Common.Entities.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Birbiz.Common.Entities.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
