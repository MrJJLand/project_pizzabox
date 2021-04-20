using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing
{
    public class PizzaBoxContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<AStore> Stores { get; set; } //implicit serialization, implicit casting
        public DbSet<APizza> Pizzas { get; set; }

        public PizzaBoxContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_configuration["mssql"]);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AStore>().HasKey(e => e.EntityID);
            builder.Entity<APizza>().HasKey(e => e.EntityID);
        }
    }
}