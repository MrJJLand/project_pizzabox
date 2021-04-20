using System.Collections.Generic;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        public static IEnumerable<object[]> values = new List<object[]>()
        {
            new object[] { new ChicagoStore() },
            new object[] { new NewYorkStore() }
        };

        [Fact]
        public void Test_ChicagoStore()
        {
            // arrage
            var sut = new ChicagoStore();

            // act
            var actual = sut.name;

            //sut.name = "dotnet";
            //actual = "dotnet"; // this should not happen

            // assert
            Assert.True(actual == "ChicagoStore");
            Assert.True(sut.ToString() == actual);

        }

        [Fact]
        public void Test_NewYorkStore()
        {
            var sut = new NewYorkStore();

            Assert.True(sut.name.Equals("NewYorkStore"));
        }
    }
}