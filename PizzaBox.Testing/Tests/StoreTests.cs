using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore()
        {
            //arrange
            var sut = new ChicagoStore();

            //act
            var actual = sut.Name;
            //sut.Name = "ditnet";

            //assert
            Assert.True(actual == "ChicagoStore");
            Assert.True(sut.ToString() == actual);
        }

        [Fact]
        public void Test_NewYorkStore()
        {
            //arrange
            var sut = new NewYorkStore();

            //act
            //var actual = sut.Name;
            //sut.Name = "ditnet";

            //assert
            //Assert.True(actual == "NewYorkStore");
            Assert.True(sut.Name.Equals("NewYorkStore"));
        }
    }
}