using RazorblueTechTest.Anagram;
using RazorblueTechTest.FizzBuzz;
using RazorblueTechTest.IPFiltering;

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

//Task-3
Console.WriteLine("-----Task-2(IP Filtering)-----");
Console.WriteLine($"Is that the given ip address is range of given IPaddress and CIDR? : {IPFiltering.IsInRange("192.168.0.0/24", "192.168.0.10")} ");
Console.ReadLine();
