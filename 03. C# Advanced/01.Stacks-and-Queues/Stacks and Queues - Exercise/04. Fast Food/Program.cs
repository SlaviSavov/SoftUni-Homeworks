using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int bigestOrder = queue.Max();

            while (queue.Count != 0 && quantity >= queue.Peek())
            {
                quantity -= queue.Dequeue();
            }


            Console.WriteLine(bigestOrder);

            if (quantity>=0 && queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join( " ",queue)}");
            }

        }
    }
}
