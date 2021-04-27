using Microsoft.EntityFrameworkCore;
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
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Order> Orders { get; set; }

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
            builder.Entity<AStore>().HasMany<Order>(s => s.Orders).WithOne(o => o.Store);

            builder.Entity<ChicagoStore>().HasBaseType<AStore>(); // Same concept as XmlInclude, wont be recognized otherwise
            builder.Entity<NewYorkStore>().HasBaseType<AStore>(); //Structure of Serilaization

            builder.Entity<APizza>().HasKey(e => e.EntityID);
            builder.Entity<Custom>().HasBaseType<APizza>();
            builder.Entity<Meatlovers>().HasBaseType<APizza>();
            builder.Entity<Veggie>().HasBaseType<APizza>();
            builder.Entity<Hawaiian>().HasBaseType<APizza>();

            builder.Entity<Crust>().HasKey(e => e.EntityID);
            builder.Entity<Crust>().HasMany<APizza>().WithOne();

            builder.Entity<Size>().HasKey(e => e.EntityID);
            builder.Entity<Size>().HasMany<APizza>().WithOne();

            builder.Entity<Topping>().HasKey(e => e.EntityID);
            builder.Entity<APizza>().HasMany<Topping>();

            builder.Entity<Order>().HasKey(e => e.EntityID);
            builder.Entity<APizza>().HasMany<Order>().WithOne(o => o.Pizza);

            builder.Entity<Customer>().HasKey(e => e.EntityID); ;
            builder.Entity<Customer>().HasMany<Order>().WithOne(o => o.Customer);

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
                new Customer() {EntityID = 1, name = "Ashley Johnson"},
                new Customer() {EntityID = 2, name = "Elizabeth Gainor"},
                new Customer() {EntityID = 3, name = "Timothy Horton"},
                new Customer() {EntityID = 4, name = "Mario Jumpman Mario"},
                new Customer() {EntityID = 5, name = "Doge Coin"},
                new Customer() {EntityID = 6, name = "Ronald Rump"},
                new Customer() {EntityID = 7, name = "Slope Flinton"},
                new Customer() {EntityID = 8, name = "Just Monika"},
                new Customer() {EntityID = 9, name = "Plague Doctor"},
                new Customer() {EntityID = 10, name = "Darth Plagueis"}
            });

            builder.Entity<Crust>().HasData(new Crust[]
            {
                new Crust() {EntityID = 1, name = "Original", price = 0.00},
                new Crust() {EntityID = 2, name = "Pretzel", price = 1.50},
                new Crust() {EntityID = 3, name = "Thin", price = 1.50},
                new Crust() {EntityID = 4, name = "Deep Dish", price = 2.00},
                new Crust() {EntityID = 5, name = "Gluten Free", price = 2.00},
                new Crust() {EntityID = 6, name = "Stuffed", price = 3.00}
            });

            builder.Entity<Size>().HasData(new Size[]
            {
                new Size() {EntityID = 1, name = "Small", price = 10.00},
                new Size() {EntityID = 2, name = "Medium", price = 13.00},
                new Size() {EntityID = 3, name = "Large", price = 15.00},
                new Size() {EntityID = 4, name = "XL", price = 20.00}
            });

            builder.Entity<Topping>().HasData(new Topping[]
            {
                new Topping() {EntityID = 1, name = "Mozzerella", price = 0},
                new Topping() {EntityID = 2, name = "Pizza Sauce", price = 0},
                new Topping() {EntityID = 3, name = "BBQ Sauce", price = 0.50},
                new Topping() {EntityID = 4, name = "Buffalo Sauce", price = 0.50},
                new Topping() {EntityID = 5, name = "Garlic", price = 0.50},
                new Topping() {EntityID = 6, name = "Ranch", price = 0.50},
                new Topping() {EntityID = 7, name = "Extra Cheese", price = 1.00},
                new Topping() {EntityID = 8, name = "Mushroom", price = 1.00},
                new Topping() {EntityID = 9, name = "Olives", price = 1.00},
                new Topping() {EntityID = 10, name = "Onion", price = 1.00},
                new Topping() {EntityID = 11, name = "Pepperoni", price = 1.00},
                new Topping() {EntityID = 12, name = "Peppers", price = 1.00},
                new Topping() {EntityID = 13, name = "Sausage", price = 1.00},
                new Topping() {EntityID = 14, name = "Scallions", price = 1.00},
                new Topping() {EntityID = 15, name = "Spinach", price = 1.00},
                new Topping() {EntityID = 16, name = "Tomato", price = 1.00},
                new Topping() {EntityID = 17, name = "Anchovies", price = 1.50},
                new Topping() {EntityID = 18, name = "Bacon", price = 1.50},
                new Topping() {EntityID = 19, name = "Chicken", price = 1.50},
                new Topping() {EntityID = 20, name = "Ham", price = 1.50},
                new Topping() {EntityID = 21, name = "Pineapple", price = 1.50},
                new Topping() {EntityID = 22, name = "Scallops", price = 2.00},
                new Topping() {EntityID = 23, name = "Shrimp", price = 2.00}
            });

            builder.Entity<Order>().HasData(new Order[]
            {
                new Order() {EntityID = 1},
                new Order() {EntityID = 2}
            });

            // builder.Entity<APizza>().HasData(new Custom[]
            // {
            //     new Custom() {EntityID = 1, name = "Custom"}
            // });
        }
    }
}
