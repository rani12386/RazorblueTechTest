namespace RazorblueTechTest.UnitTest
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("abc", "cba", true)]
        [InlineData("abcd", "dcba", true)]
        [InlineData("abcd", "abda", false)]
        public void IsAnagramTests(string input1, string input2, bool expected)
        {
            Assert.Equal(expected, Anagram.Anagram.IsAnagram(input1, input2));
        }
    }
}