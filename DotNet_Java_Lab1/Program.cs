using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests"), InternalsVisibleTo("GUIApp")]
namespace DotNet_Java_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of items: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Enter backpack capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.solve(capacity);

            Console.WriteLine(result.ToString());
        }
    }
}
