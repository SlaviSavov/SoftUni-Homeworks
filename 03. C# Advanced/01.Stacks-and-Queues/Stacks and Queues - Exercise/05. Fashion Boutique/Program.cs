using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(box);
            int capacity = int.Parse(Console.ReadLine());
            int busyRack = 1;

            int itemsOnRack = 0;

            while (stack.Count!=0)
            {
                if (itemsOnRack+stack.Peek()<=capacity)
                {
                    itemsOnRack += stack.Pop();
                }
                else
                {
                    busyRack++;
                    itemsOnRack = 0;
                }
            }
            Console.WriteLine(busyRack);
        }
    }
}
