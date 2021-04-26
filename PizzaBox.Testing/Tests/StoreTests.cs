using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        public static IEnumerable<object[]> values = new List<object[]>() //IEnumerable is an interface that contains all collections, its the abstractions
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

        [Theory]
        [MemberData(nameof(values))]
        public void Test_StoreName(AStore store)
        {
            Assert.NotNull(store.name);
            Assert.Equal(store.name, store.ToString());
        }

        // <param name = "storeName" ></ param >
        // < param name = "x"></param>
        // [Theory]
        // [IncludeData("ChicagoStore")]
        // [IncludeData("NewYorkStore")]
        // public void Test_StoreNameSimple(string storeName)
        // {
        //     Assert.NotNull(storeName);
        // }
    }
}