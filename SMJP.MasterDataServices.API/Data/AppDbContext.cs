using Microsoft.EntityFrameworkCore;
using SMJP.MasterDataServices.API.Models;
using SMJP.MasterDataServices.API.Models.Dto;

namespace SMJP.MasterDataServices.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<Sites> Sites { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Shifts> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasData(new Users
            {
                UserID = 1,
                AvatarUrl = "https://example.com/avatar1.png",
                UserCode = "USER001",
                FullName = "John Doe",
                Phone = "1234567890",
                Email = "johndoe@example.com",
                CompanyID = 1,
                RegionID = 1,
                SiteID = 1,
                Username = "johndoe",
                Password = "hashed_password",
                RoleID = 1,
                IsAdmin = 0,
                SyncTime = 1,
                IsActive = 1,
                ActiveDate = DateTime.UtcNow,
                CreatedByIpAddress = "127.0.0.1",
                CreatedBy = 1,
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = 1,
                ModifiedDate = DateTime.UtcNow
            });

            modelBuilder.Entity<Companies>().HasData(new Companies
            {
                CompanyID = 1,
                LogoUrl = "https://pertamina.com/logo1.png",
                CompanyName = "Pertamina",
                CompanyEmail = "pertamina@example.com",
                CompanyPhone = "1234567890",
                CompanyAddress = "Jl. M.H.Thamrin No.10",
                ProvinceID = 1,
                Latitude = "40.7128",
                Longitude = "-74.0060",
                CreatedBy = 1,
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = 1,
                ModifiedDate = DateTime.UtcNow
            });

            modelBuilder.Entity<Regions>().HasData(new Regions
            {
                RegionID = 1,
                CompanyID = 1,
                RegionName = "Jakarta Pusat",
                RegionLatitude = "40.7128",
                RegionLongitude = "-74.0060",
                CreatedBy = 1,
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = 1,
                ModifiedDate = DateTime.UtcNow
            });

            modelBuilder.Entity<Sites>().HasData(new Sites
            {
                SiteID = 1,
                CompanyID = 1,
                RegionID = 1,
                SiteName = "Pertamina Training & Consulting",
                SiteDesc = "Description of Pertamina Site",
                SiteLatitude = "48.8584",
                SiteLongitude = "2.2945",
                CreatedBy = 1,
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = 1,
                ModifiedDate = DateTime.UtcNow
            });

            modelBuilder.Entity<Schedules>().HasData(new Schedules
            {
                ScheduleID = 1,
                CompanyID = 1,
                RegionID = 1,
                SiteID = 1,
                ShiftID = 1,
                Date = DateTime.Now,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now
            });

            modelBuilder.Entity<Shifts>().HasData(new Shifts
            {
                ShiftID = 1,
                Title = "Morning",
                StartAt = DateTime.Parse("07:00"),
                EndAt = DateTime.Parse("16:00"),
                CreatedBy = 1,
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = 1,
                ModifiedDate = DateTime.UtcNow
            });
        }

    }
}
