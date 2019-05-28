using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var first = new HashSet<int>();
            var second = new HashSet<int>();

            for (int i = 0; i < nums[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < nums[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));

            }

            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
