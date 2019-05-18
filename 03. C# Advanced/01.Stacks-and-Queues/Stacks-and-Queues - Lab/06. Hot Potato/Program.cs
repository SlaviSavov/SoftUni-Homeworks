using System;
using System.Collections.Generic;

namespace _06._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
