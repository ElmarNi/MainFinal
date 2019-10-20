﻿// <auto-generated />
using System;
using MainFinalBack.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MainFinalBack.Migrations
{
    [DbContext(typeof(RentNowDbContext))]
    [Migration("20191009140240_Order")]
    partial class Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MainFinalBack.Models.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CarId");

                    b.Property<bool>("IsVerified");

                    b.Property<DateTime>("PublishDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("MainFinalBack.Models.AdvertisementMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementId");

                    b.Property<int>("MessageId");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementId");

                    b.HasIndex("MessageId")
                        .IsUnique();

                    b.ToTable("AdvertisementMessages");
                });

            modelBuilder.Entity("MainFinalBack.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsBlocked");

                    b.Property<string>("Lastname")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MainFinalBack.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("MainImageUrl");

                    b.Property<DateTime>("PublishDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("MainFinalBack.Models.BlogDetailImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogDetailImages");
                });

            modelBuilder.Entity("MainFinalBack.Models.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("BodyTypes");
                });

            modelBuilder.Entity("MainFinalBack.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("MainFinalBack.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyTypeId");

                    b.Property<int>("CarClassId");

                    b.Property<int>("CityId");

                    b.Property<int>("ColorId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<decimal>("Engine");

                    b.Property<int>("FuelTypeId");

                    b.Property<bool>("IsVip");

                    b.Property<string>("MainImageUrl");

                    b.Property<int>("ManufactureYear");

                    b.Property<int>("Milage");

                    b.Property<int>("ModelId");

                    b.Property<decimal>("Price");

                    b.Property<int>("TransmissionId");

                    b.Property<int>("WheelDriveId");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("CarClassId");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("WheelDriveId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("MainFinalBack.Models.CarClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("CarClasses");
                });

            modelBuilder.Entity("MainFinalBack.Models.CarDetailImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarDetailImages");
                });

            modelBuilder.Entity("MainFinalBack.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MainFinalBack.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("MainFinalBack.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MainFinalBack.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("MainFinalBack.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("From");

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MainFinalBack.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("MainFinalBack.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsResponded");

                    b.Property<string>("Lastname")
                        .HasMaxLength(200);

                    b.Property<DateTime>("OrderDate");

                    b.Property<DateTime>("PickDate");

                    b.Property<DateTime>("ResponseDate");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MainFinalBack.Models.OrderMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvertisementId");

                    b.Property<int>("MessageId");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementId");

                    b.HasIndex("MessageId")
                        .IsUnique();

                    b.HasIndex("OrderId");

                    b.ToTable("OrderMessages");
                });

            modelBuilder.Entity("MainFinalBack.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertisementId");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MainFinalBack.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Transmissions");
                });

            modelBuilder.Entity("MainFinalBack.Models.WheelDrive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Drive")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("WheelDrives");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MainFinalBack.Models.Advertisement", b =>
                {
                    b.HasOne("MainFinalBack.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Advertisements")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("MainFinalBack.Models.Car", "Car")
                        .WithOne("Advertisement")
                        .HasForeignKey("MainFinalBack.Models.Advertisement", "CarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.AdvertisementMessage", b =>
                {
                    b.HasOne("MainFinalBack.Models.Advertisement", "Advertisement")
                        .WithMany("AdvertisementMessages")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.Message", "Message")
                        .WithOne("AdvertisementMessage")
                        .HasForeignKey("MainFinalBack.Models.AdvertisementMessage", "MessageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.BlogDetailImage", b =>
                {
                    b.HasOne("MainFinalBack.Models.Blog", "Blog")
                        .WithMany("BlogDetailImages")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.Car", b =>
                {
                    b.HasOne("MainFinalBack.Models.BodyType", "BodyType")
                        .WithMany("Cars")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.CarClass", "CarClass")
                        .WithMany("Cars")
                        .HasForeignKey("CarClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.City", "City")
                        .WithMany("Cars")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.FuelType", "FuelType")
                        .WithMany("Cars")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.Transmission", "Transmission")
                        .WithMany("Cars")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.WheelDrive", "WheelDrive")
                        .WithMany("Cars")
                        .HasForeignKey("WheelDriveId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.CarDetailImage", b =>
                {
                    b.HasOne("MainFinalBack.Models.Car", "Car")
                        .WithMany("CarDetailImages")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.City", b =>
                {
                    b.HasOne("MainFinalBack.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.Model", b =>
                {
                    b.HasOne("MainFinalBack.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.Order", b =>
                {
                    b.HasOne("MainFinalBack.Models.Advertisement", "Advertisement")
                        .WithMany("Orders")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.OrderMessages", b =>
                {
                    b.HasOne("MainFinalBack.Models.Advertisement")
                        .WithMany("OrderMessages")
                        .HasForeignKey("AdvertisementId");

                    b.HasOne("MainFinalBack.Models.Message", "Message")
                        .WithOne("OrderMessages")
                        .HasForeignKey("MainFinalBack.Models.OrderMessages", "MessageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MainFinalBack.Models.Review", b =>
                {
                    b.HasOne("MainFinalBack.Models.Advertisement", "Advertisement")
                        .WithMany("Reviews")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MainFinalBack.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MainFinalBack.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainFinalBack.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MainFinalBack.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
