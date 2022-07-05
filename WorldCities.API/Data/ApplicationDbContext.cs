using Microsoft.EntityFrameworkCore;
using WorldCities.API.Data.Models;

namespace WorldCities.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() { }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<City> Cities => Set<City>();
        public DbSet<Country> Countries => Set<Country>();
    }
}
