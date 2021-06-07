﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    partial class PizzaBoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CrustEntityID")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SizeEntityID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ToppingEntityID")
                        .HasColumnType("bigint");

                    b.HasKey("EntityID");

                    b.HasIndex("CrustEntityID");

                    b.HasIndex("SizeEntityID");

                    b.HasIndex("ToppingEntityID");

                    b.ToTable("Pizzas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("APizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityID");

                    b.ToTable("Stores");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("EntityID");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            EntityID = 1L,
                            name = "Original",
                            price = 0.0
                        },
                        new
                        {
                            EntityID = 2L,
                            name = "Pretzel",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 3L,
                            name = "Thin",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 4L,
                            name = "Deep Dish",
                            price = 2.0
                        },
                        new
                        {
                            EntityID = 5L,
                            name = "Gluten Free",
                            price = 2.0
                        },
                        new
                        {
                            EntityID = 6L,
                            name = "Stuffed",
                            price = 3.0
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            EntityID = 1L,
                            name = "Ashley Johnson"
                        },
                        new
                        {
                            EntityID = 2L,
                            name = "Elizabeth Gainor"
                        },
                        new
                        {
                            EntityID = 3L,
                            name = "Timothy Horton"
                        },
                        new
                        {
                            EntityID = 4L,
                            name = "Mario Jumpman Mario"
                        },
                        new
                        {
                            EntityID = 5L,
                            name = "Doge Coin"
                        },
                        new
                        {
                            EntityID = 6L,
                            name = "Ronald Rump"
                        },
                        new
                        {
                            EntityID = 7L,
                            name = "Slope Flinton"
                        },
                        new
                        {
                            EntityID = 8L,
                            name = "Just Monika"
                        },
                        new
                        {
                            EntityID = 9L,
                            name = "Plague Doctor"
                        },
                        new
                        {
                            EntityID = 10L,
                            name = "Darth Plagueis"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CustomerEntityID")
                        .HasColumnType("bigint");

                    b.Property<long?>("PizzaEntityID")
                        .HasColumnType("bigint");

                    b.Property<long?>("StoreEntityID")
                        .HasColumnType("bigint");

                    b.HasKey("EntityID");

                    b.HasIndex("CustomerEntityID");

                    b.HasIndex("PizzaEntityID");

                    b.HasIndex("StoreEntityID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            EntityID = 1L
                        },
                        new
                        {
                            EntityID = 2L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("EntityID");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            EntityID = 1L,
                            name = "Small",
                            price = 10.0
                        },
                        new
                        {
                            EntityID = 2L,
                            name = "Medium",
                            price = 13.0
                        },
                        new
                        {
                            EntityID = 3L,
                            name = "Large",
                            price = 15.0
                        },
                        new
                        {
                            EntityID = 4L,
                            name = "XL",
                            price = 20.0
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("EntityID");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            EntityID = 1L,
                            name = "Mozzerella",
                            price = 0.0
                        },
                        new
                        {
                            EntityID = 2L,
                            name = "Pizza Sauce",
                            price = 0.0
                        },
                        new
                        {
                            EntityID = 3L,
                            name = "BBQ Sauce",
                            price = 0.5
                        },
                        new
                        {
                            EntityID = 4L,
                            name = "Buffalo Sauce",
                            price = 0.5
                        },
                        new
                        {
                            EntityID = 5L,
                            name = "Garlic",
                            price = 0.5
                        },
                        new
                        {
                            EntityID = 6L,
                            name = "Ranch",
                            price = 0.5
                        },
                        new
                        {
                            EntityID = 7L,
                            name = "Extra Cheese",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 8L,
                            name = "Mushroom",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 9L,
                            name = "Olives",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 10L,
                            name = "Onion",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 11L,
                            name = "Pepperoni",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 12L,
                            name = "Peppers",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 13L,
                            name = "Sausage",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 14L,
                            name = "Scallions",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 15L,
                            name = "Spinach",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 16L,
                            name = "Tomato",
                            price = 1.0
                        },
                        new
                        {
                            EntityID = 17L,
                            name = "Anchovies",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 18L,
                            name = "Bacon",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 19L,
                            name = "Chicken",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 20L,
                            name = "Ham",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 21L,
                            name = "Pineapple",
                            price = 1.5
                        },
                        new
                        {
                            EntityID = 22L,
                            name = "Scallops",
                            price = 2.0
                        },
                        new
                        {
                            EntityID = 23L,
                            name = "Shrimp",
                            price = 2.0
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.Custom", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("Custom");

                    b.HasData(
                        new
                        {
                            EntityID = 1L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.Hawaiian", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("Hawaiian");

                    b.HasData(
                        new
                        {
                            EntityID = 2L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.Meatlovers", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("Meatlovers");

                    b.HasData(
                        new
                        {
                            EntityID = 3L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.Veggie", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("Veggie");

                    b.HasData(
                        new
                        {
                            EntityID = 4L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.ChicagoStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("ChicagoStore");

                    b.HasData(
                        new
                        {
                            EntityID = 1L,
                            name = "Main St."
                        },
                        new
                        {
                            EntityID = 2L,
                            name = "West Rd."
                        },
                        new
                        {
                            EntityID = 3L,
                            name = "North Ave."
                        },
                        new
                        {
                            EntityID = 4L,
                            name = "East St."
                        },
                        new
                        {
                            EntityID = 5L,
                            name = "South Cir."
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.NewYorkStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("NewYorkStore");

                    b.HasData(
                        new
                        {
                            EntityID = 6L,
                            name = "South James St."
                        },
                        new
                        {
                            EntityID = 7L,
                            name = "Erie Blvd."
                        },
                        new
                        {
                            EntityID = 8L,
                            name = "Black River Blvd."
                        },
                        new
                        {
                            EntityID = 9L,
                            name = "Name_Pending Rd."
                        },
                        new
                        {
                            EntityID = 10L,
                            name = "Artist Ln."
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", null)
                        .WithMany()
                        .HasForeignKey("CrustEntityID");

                    b.HasOne("PizzaBox.Domain.Models.Size", null)
                        .WithMany()
                        .HasForeignKey("SizeEntityID");

                    b.HasOne("PizzaBox.Domain.Models.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingEntityID");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerEntityID");

                    b.HasOne("PizzaBox.Domain.Abstracts.APizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaEntityID");

                    b.HasOne("PizzaBox.Domain.Abstracts.AStore", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityID");

                    b.Navigation("Customer");

                    b.Navigation("Pizza");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
