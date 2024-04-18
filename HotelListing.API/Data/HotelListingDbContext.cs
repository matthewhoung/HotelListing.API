using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }
        //below are the tables that will be created in the database
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        //using fluent API(override OnModelCreating) to configure the relationship between the tables
        //seeding the database with fake data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Taiwan",
                    ShortName = "TW"
                 },
                new Country
                {
                    Id = 2,
                    Name = "United States",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 3,
                    Name = "Japan",
                    ShortName = "JP"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel Taiwan",
                    Address = "Taipei",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel US",
                    Address = "New York",
                    CountryId = 2,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Japan",
                    Address = "Tokyo",
                    CountryId = 3,
                    Rating = 4.3
                }
                );
        }
    }
}