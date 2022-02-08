using Xunit;
using Prime.Services;


// tutorial: https://docs.microsoft.com/en-gb/dotnet/core/testing/unit-testing-with-dotnet-test
// format file : ctr shit i
// ctrl shift p - command pallete

// dotnet build - build project
// dotnet test - test project

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {

        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }


        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }

}