using Prime.Services;

namespace Prime.UnitTests.Services
{
  public class PrimeService_IsPrimeShould
  {
    private PrimeService? _primeService;
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_InputIs1_ReturnFalse(int value)
    {
      _primeService = new PrimeService();
      bool result = _primeService.IsPrime(value);

      Assert.False(result, "1 should not be prime");
    }
  }
}