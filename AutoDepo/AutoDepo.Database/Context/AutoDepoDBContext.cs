using AutoDepoDB.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoDepoDB.Database.Context
{
    public class AutoDepoDBContext : DbContext
    {
        public DbSet<CarBrand> CarBrand { get; set; }

        public DbSet<CarModel> CarModel { get; set; }

        public AutoDepoDBContext(DbContextOptions<AutoDepoDBContext> options) : base(options) { }
    }
}
