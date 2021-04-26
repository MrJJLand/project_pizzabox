using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Storing
{
    public class PizzaBoxContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<AStore> Stores { get; set; } //implicit serialization, implicit casting
        public DbSet<APizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; } // These are the File Writer, Reader and Serializer
        public DbSet<Size> Sizes { get; set; }

        public PizzaBoxContext()
        {
            _configuration = new ConfigurationBuilder().AddUserSecrets<PizzaBoxContext>().Build();
        }

        /// <param name="builder"></param>

        protected override void OnConfiguring(DbContextOptionsBuilder builder) //This is the path in the 
        {
            builder.UseSqlServer(_configuration["mssql"]);
        }

        /// <param name="builder"></param>

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AStore>().HasKey(e => e.EntityID);
            builder.Entity<ChicagoStore>().HasBaseType<AStore>(); // Same concept as XmlInclude, wont be recognized otherwise
            builder.Entity<NewYorkStore>().HasBaseType<AStore>(); //Structure of Serilaization

            builder.Entity<APizza>().HasKey(e => e.EntityID);
            builder.Entity<Custom>().HasBaseType<APizza>();
            builder.Entity<Meatlovers>().HasBaseType<APizza>();
            builder.Entity<Veggie>().HasBaseType<APizza>();
            builder.Entity<Hawaiian>().HasBaseType<APizza>();

            builder.Entity<Crust>().HasKey(e => e.EntityID);
            builder.Entity<Size>().HasKey(e => e.EntityID);
            builder.Entity<Topping>().HasKey(e => e.EntityID);
            builder.Entity<Order>().HasKey(e => e.EntityID);

            builder.Entity<Customer>().HasKey(e => e.CustomerID); ;

            OnDataSeeding(builder);
        }

        /// <param name = "builder" ></ param >
        private void OnDataSeeding(ModelBuilder builder)
        {
            builder.Entity<ChicagoStore>().HasData(new ChicagoStore[]
            {
                new ChicagoStore() {EntityID = 1, name = "Main St."},
                new ChicagoStore() {EntityID = 2, name = "West Rd."},
                new ChicagoStore() {EntityID = 3, name = "North Ave."},
                new ChicagoStore() {EntityID = 4, name = "East St."},
                new ChicagoStore() {EntityID = 5, name = "South Cir."}
            });

            builder.Entity<NewYorkStore>().HasData(new NewYorkStore[]
            {
                new NewYorkStore() {EntityID = 6, name = "South James St."},
                new NewYorkStore() {EntityID = 7, name = "Erie Blvd."},
                new NewYorkStore() {EntityID = 8, name = "Black River Blvd."},
                new NewYorkStore() {EntityID = 9, name = "Name_Pending Rd."},
                new NewYorkStore() {EntityID = 10, name = "Artist Ln."}
            });

            builder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer() {CustomerID = 1, name = "Ashley Johnson"},
                new Customer() {CustomerID = 2, name = "Elizabeth Gainor"},
                new Customer() {CustomerID = 3, name = "Timothy Horton"},
                new Customer() {CustomerID = 4, name = "Mario Jumpman Mario"},
                new Customer() {CustomerID = 5, name = "Doge Coin"}
            });

            builder.Entity<Crust>().HasData(new Crust[]
            {
                new Crust() { EntityID = 1, name = "Original", price = 0.00},
                new Crust() { EntityID = 2, name = "Stuffed", price = 3.00},
                new Crust() { EntityID = 3, name = "Pretzel", price = 1.50}
            });

            builder.Entity<Size>().HasData(new Size[]
            {
                new Size() { EntityID = 1, name = "Small", price = 10.00},
                new Size() { EntityID = 2, name = "Medium", price = 13.00},
                new Size() { EntityID = 3, name = "Large", price = 15.00},
                new Size() { EntityID = 4, name = "XL", price = 20.00}
            });

            builder.Entity<Topping>().HasData(new Topping[]
            {
                new Topping() { EntityID = 1, name = "Pepperoni", price = 1.00},
                new Topping() { EntityID = 2, name = "Extra Cheese", price = 1.00},
                new Topping() { EntityID = 3, name = "Sausage", price = 1.00},
                new Topping() { EntityID = 4, name = "Ham", price = 1.50},
                new Topping() { EntityID = 5, name = "Bacon", price = 1.50},
                new Topping() { EntityID = 6, name = "Chicken", price = 1.50},
                new Topping() { EntityID = 7, name = "Buffalo Chicken", price = 1.50},
                new Topping() { EntityID = 8, name = "Tomato", price = 1.00},
                new Topping() { EntityID = 9, name = "Onion", price = 1.00},
                new Topping() { EntityID = 10, name = "Olives", price = 1.00},
                new Topping() { EntityID = 11, name = "Mushroom", price = 1.00},
                new Topping() { EntityID = 12, name = "Spinach", price = 1.00},
                new Topping() { EntityID = 13, name = "Peppers", price = 1.00},
                new Topping() { EntityID = 14, name = "Shrimp", price = 2.00},
                new Topping() { EntityID = 15, name = "Garlic", price = 0.50},
                new Topping() { EntityID = 16, name = "BBQ Sauce", price = 0.50},

                new Topping() { EntityID = 17, name = "Scallions", price = 1.00},
                new Topping() { EntityID = 18, name = "Scallops", price = 2.00},
                new Topping() { EntityID = 19, name = "Pineapple", price = 1.50},
            });

            builder.Entity<Order>().HasData(new Order[]
            {
                new Order() { EntityID = 1 }
            });
        }
    }
}
