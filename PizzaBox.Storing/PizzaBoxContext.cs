using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
    public class PizzaBoxContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<AStore> Stores { get; set; } //implicit serialization, implicit casting
        public DbSet<APizza> Pizzas { get; set; }

        public DbSet<Customer> Customers { get; set; }



        public PizzaBoxContext()
        {
            _configuration = new ConfigurationBuilder().AddUserSecrets<PizzaBoxContext>().Build();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_configuration["mssql"]);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AStore>().HasKey(e => e.EntityID);
            builder.Entity<APizza>().HasKey(e => e.EntityID);
            builder.Entity<Crust>().HasKey(e => e.EntityID);
            builder.Entity<Size>().HasKey(e => e.EntityID);
            builder.Entity<Topping>().HasKey(e => e.EntityID);
            builder.Entity<Customer>().HasKey(e => e.EntityID);
            builder.Entity<Order>().HasKey(e => e.EntityID);
        }
    }
}
