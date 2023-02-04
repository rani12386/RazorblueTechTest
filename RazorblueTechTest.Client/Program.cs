using RazorblueTechTest.Anagram;
using RazorblueTechTest.FizzBuzz;

//Test-1
Console.WriteLine("-----Task-1(Anagram)-----");
Console.WriteLine($"Is that given string is Anagram? : {Anagram.IsAnagram("silent", "listen")} ");
Console.ReadLine();

//Test-2
Console.WriteLine("-----Task-2(FizzBuzz)-----");
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(FizzBuzz.Print(i));
}
Console.ReadLine();
