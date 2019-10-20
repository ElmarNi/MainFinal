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
    [Migration("20190916140130_Initial")]
    partial class Initial
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

                    b.Property<int>("CarId");

                    b.Property<DateTime>("PublishDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Advertisements");
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

            modelBuilder.Entity("MainFinalBack.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvertisementId");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(300);

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

            modelBuilder.Entity("MainFinalBack.Models.Advertisement", b =>
                {
                    b.HasOne("MainFinalBack.Models.Car", "Car")
                        .WithOne("Advertisement")
                        .HasForeignKey("MainFinalBack.Models.Advertisement", "CarId")
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

            modelBuilder.Entity("MainFinalBack.Models.Review", b =>
                {
                    b.HasOne("MainFinalBack.Models.Advertisement", "Advertisement")
                        .WithMany("Reviews")
                        .HasForeignKey("AdvertisementId");
                });
#pragma warning restore 612, 618
        }
    }
}
