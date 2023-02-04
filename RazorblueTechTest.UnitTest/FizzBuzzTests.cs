namespace RazorblueTechTest.UnitTest
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(11, "11")]
        public void FizzBuzzPrintTests(int number, string expected)
        {
            Assert.Equal(expected, FizzBuzz.FizzBuzz.Print(number));
        }
    }
}
