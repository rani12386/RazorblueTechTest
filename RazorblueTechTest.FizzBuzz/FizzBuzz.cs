namespace RazorblueTechTest.FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Print(int i)
        {
            return (i % 3, i % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                (_, _) => i.ToString(),
            };
        }
    }
}