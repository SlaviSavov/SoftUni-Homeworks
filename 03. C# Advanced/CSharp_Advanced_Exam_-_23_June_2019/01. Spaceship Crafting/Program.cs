using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var liquids = new Queue<int>(input);

            var items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var materials = new Dictionary<string,int>();
            materials.Add("Glass", 25);
            materials.Add("Aluminium", 50);
            materials.Add("Lithium", 75);
            materials.Add("Carbon fiber", 100);

            var makeMat = new Dictionary<string,int>();
            makeMat.Add("Glass", 0);
            makeMat.Add("Aluminium", 0);
            makeMat.Add("Lithium", 0);
            makeMat.Add("Carbon fiber", 0);

            while (liquids.Count>0&&items.Count>0)
            {
                int currentValue = liquids.Dequeue()+items[items.Count-1] ;
                bool canMake = false;

                foreach (var (key,value) in materials)
                {
                    if (value == currentValue)
                    {
                        makeMat[key]++;
                        items.RemoveAt(items.Count - 1);
                        canMake = true;
                    }
                }
                if (!canMake)
                {
                    items[items.Count - 1] += 3;
                }
            }

            if (!makeMat.ContainsValue(0))
            {
                Console.WriteLine( "Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            if (liquids.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                items.Reverse();
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            foreach (var (key,value) in makeMat.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }

        }
    }
}
