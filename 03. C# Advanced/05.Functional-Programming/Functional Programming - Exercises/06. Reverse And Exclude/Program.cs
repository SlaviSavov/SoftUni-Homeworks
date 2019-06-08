using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var input = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % input != 0;
            Func<int, bool> filterFunc = x => filter(x);

            Console.WriteLine(string.Join(" ",numbers.Reverse().Where(filterFunc)));
        }
    }
}
