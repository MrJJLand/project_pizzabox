using System.Collections.Generic;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class FullTest
    {
        public static IEnumerable<object[]> values = new List<object[]>()
        {
            new object[] {new ChicagoStore() },
            new object[] {new NewYorkStore() },
            new object[] {new Crust() },
            new object[] {new Size() },
            new object[] {new Topping() },
            new object[] {new Customer() },
            new object[] {new Order() },
            new object[] {new Custom() },
            new object[] {new Meatlovers() },
            new object[] {new Veggie() },
            new object[] {new Hawaiian() }
        };

        [Fact]
        public void TestChicagoStore()
        {
            var sut = new ChicagoStore();
            var actual = sut.name;

            Assert.True(actual == "Chicago Store");
            Assert.True(sut.ToString() == actual);
        }

        [Fact]
        public void TestNewYorkStore()
        {
            var sut = new NewYorkStore();
            var actual = sut.name;

            Assert.True(sut.name.Equals("NewYork Store"));
            Assert.True(sut.ToString() == actual);
        }

        [Theory]
        [InlineData("ChicagoStore")]
        [InlineData("NewYorkStore")]
        public void TestStoreNameSimple(string storeName)
        {
            Assert.NotNull(storeName);
        }

        [Theory]
        [InlineData("Original", 1, 1)]
        [InlineData("Deep Dish", 2, 2)]
        public void TestCrust(string name, double price, long EntityID)
        {
            var tester = new Crust();
            tester.name = name;
            tester.price = price;
            tester.EntityID = EntityID;
            Assert.NotNull(tester.name);
            Assert.True(tester.price > 0);
            Assert.NotNull(tester.EntityID);
        }

        [Theory]
        [InlineData("Small", 1, 1)]
        [InlineData("Large", 2, 2)]
        public void TestSize(string name, double price, long EntityID)
        {
            var tester = new Size();
            tester.name = name;
            tester.price = price;
            tester.EntityID = EntityID;
            Assert.NotNull(tester.name);
            Assert.True(tester.price > 0);
            Assert.NotNull(tester.EntityID);
        }

        [Theory]
        [InlineData("Cheese", 1, 1)]
        [InlineData("Pepperoni", 2, 2)]
        public void TestTopping(string name, double price, long EntityID)
        {
            var tester = new Topping();
            tester.name = name;
            tester.price = price;
            tester.EntityID = EntityID;
            Assert.NotNull(tester.name);
            Assert.True(tester.price > 0);
            Assert.NotNull(tester.EntityID);
        }

        [Theory]
        [InlineData("Eileen Saradra", 1)]
        [InlineData("Katar", 2)]
        public void TestCustomer(string name, long EntityID)
        {
            var tester = new Customer();
            tester.name = name;
            tester.EntityID = EntityID;
            Assert.NotNull(tester.name);
            Assert.NotNull(tester.EntityID);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TestOrderCreation(long EntityID)
        {
            var tester = new Order();
            tester.EntityID = EntityID;
            Assert.True(tester.EntityID != 0);
        }

        [Theory]
        [InlineData(1, "Michael")]
        [InlineData(2, "Aralith")]
        public void TestOrderCustomer(long EntityID, string name)
        {
            var tester = new Order();
            tester.EntityID = EntityID;
            tester.Customer = new Customer();
            tester.Customer.EntityID = EntityID;
            tester.Customer.name = name;
            Assert.NotNull(tester.Customer.ToString());
            Assert.True(tester.Customer.EntityID != 0);
        }

        [Theory]
        [InlineData(1, "Mama Mia's")]
        [InlineData(2, "Luigi's")]
        public void TestOrderStore(long EntityID, string name)
        {
            var tester = new Order();
            tester.EntityID = EntityID;
            tester.Store = new ChicagoStore();
            tester.Store.EntityID = EntityID;
            tester.Store.name = name;
            Assert.NotNull(tester.Store.ToString());
            Assert.True(tester.Store.EntityID != 0);
        }

        [Theory]
        [InlineData(1, "That'sa One a-Spicy a-Meat-a-Ball")]
        [InlineData(2, "Hawaiian")]
        public void TestOrderPizza(long EntityID, string name)
        {
            var tester = new Order();
            tester.EntityID = EntityID;
            tester.Pizza = new Custom();
            Assert.True(tester.Pizza.pizzaPrice != 0);
        }

        [Fact]
        public void TestMeat()
        {
            var tester = new Meatlovers();
            Assert.NotNull(tester.Crust);
            Assert.NotNull(tester.Size);
            Assert.NotNull(tester.Toppings);
        }

        [Fact]
        public void TestVeggie()
        {
            var tester = new Veggie();
            var newCrust = new Crust();
            var newSize = new Size();
            var newTopping = new Topping();
            tester.AddCrust(newCrust);
            tester.AddSize(newSize);
            tester.AddToppings(newTopping);
            Assert.NotNull(tester.Crust);
            Assert.NotNull(tester.Size);
            Assert.NotNull(tester.Toppings);
        }

        [Fact]
        public void TestHawaiian()
        {
            var tester = new Hawaiian();
            var newCrust = new Crust();
            var newSize = new Size();
            var newTopping = new Topping();
            tester.AddCrust(newCrust);
            tester.AddSize(newSize);
            tester.AddToppings(newTopping);
            Assert.NotNull(tester.Crust);
            Assert.NotNull(tester.Size);
            Assert.NotNull(tester.Toppings);
        }
    }
}