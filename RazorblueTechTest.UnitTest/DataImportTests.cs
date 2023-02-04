using System.Text.RegularExpressions;

namespace RazorblueTechTest.UnitTest
{
    public class DataImportTests
    {
        [Theory]
        [InlineData("AB12 ABC", true)]
        [InlineData("ab12 abc", true)]
        [InlineData("AB12345", false)]
        [InlineData("1234567", false)]
        public void VehickleRegExTest(string number, bool expected)
        {
            Assert.Equal(expected, Regex.Match(number, DataImport.DataImport.ValidVehicleRegExpression).Success);
        }
    }
}
