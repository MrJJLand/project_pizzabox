using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
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
            Assert.True(sut.ToString() == sut.name);
            
        }

        [Fact]
        public void Test_NewYorkStore()
        {
            var sut = new NewYorkStore();

            var actual = sut.name;

            Assert.True(actual.Equals("NewYorkStore"));
        }
    }
}