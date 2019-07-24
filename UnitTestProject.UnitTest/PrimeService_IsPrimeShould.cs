using UnitTestProject.Domain;
using Xunit;
namespace UnitTestProject.UnitTest
{
    public class PrimeService_IsPrimeShould
    {
        private readonly IPrimeService primeService;
        public PrimeService_IsPrimeShould()
        {
            primeService = new PrimeService();
        }
        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            //Arrange
            var testData = 1;
            //Act
            var result = primeService.IsPrime(testData);
            //Assert
            Assert.False(result, "1 should not be prime");
        }
        [Fact]
        public void ReturnTrueGivenValueOf2()
        {
            //Arrange
            var testData = 2;
            //Act
            var result = primeService.IsPrime(testData);
            //Assert
            Assert.True(result, "2 should  be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        public void ReturnFalseGivenEvenValues(int value)
        {
            var result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(11)]
        public void ReturnTrueGivenPimeValues(int value)
        {
            var result = primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }
    }
}
