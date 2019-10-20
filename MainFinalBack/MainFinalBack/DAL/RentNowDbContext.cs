using MainFinalBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.DAL
{
    public class RentNowDbContext : IdentityDbContext<ApplicationUser>
    {
        public RentNowDbContext(DbContextOptions<RentNowDbContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetailImage> BlogDetailImages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<WheelDrive> WheelDrives { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDetailImage> CarDetailImages { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AdvertisementMessage> AdvertisementMessages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TermHeader> TermHeaders { get; set; }
        public DbSet<TermContent> TermContents { get; set; }
        public DbSet<OurVisionAboutUs> OurVisions { get; set; }
        public DbSet<OurPassionAboutUs> OurPassions { get; set; }
        public DbSet<SectionBanner> SectionBanners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
