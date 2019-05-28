using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToCharArray();
            var charCount = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!charCount.ContainsKey(item))
                {
                    charCount.Add(item, 0);
                }
                charCount[item]++;
            }
            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
