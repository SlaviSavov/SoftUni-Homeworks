using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<String>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var item in input)
                {
                    uniqueElements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",uniqueElements));
        }
    }
}
