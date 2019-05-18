using System;
using System.Collections.Generic;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            string command = Console.ReadLine();

            while (command?.ToLower()!="end")
            {
                if (command?.ToLower()!="paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while (queue.Count!=0)
                    {
                        Console.WriteLine(queue.Dequeue()); 
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
