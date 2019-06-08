using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numbers = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;

            string type = Console.ReadLine();

            if (type == "odd")
            {
                numbers = numbers
                    .Where(n => isOdd(n))
                    .ToList();
            }
            else
            {
                numbers = numbers
                   .Where(n => isEven(n))
                   .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
