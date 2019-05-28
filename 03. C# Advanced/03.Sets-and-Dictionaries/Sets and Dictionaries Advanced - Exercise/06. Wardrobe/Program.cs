using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = input[0];
                var item = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j  = 0; j < item.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(item[j]))
                    {
                        wardrobe[color].Add(item[j], 0);
                    }
                    wardrobe[color][item[j]]++;
                }
            }
            var searchedItem = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothes in item.Value)
                {
                    Console.Write($"* {clothes.Key} - {clothes.Value} ");
                    if (item.Key == (searchedItem[0]) && clothes.Key == (searchedItem[1]))
                    {
                        Console.Write("(found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
