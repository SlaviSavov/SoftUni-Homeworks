using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = int.MaxValue;
                while (queue.Count != 0)
                {
                    if (queue.Peek() < min)
                    {
                        min = queue.Dequeue();
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
