using System;
using System.Collections.Generic;

namespace _07._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            Queue<string> carsAcross = new Queue<string>();
            int count = 0;

            string command = Console.ReadLine();

            while (command?.ToLower() != "end")
            {
                if (command?.ToLower() == "green")
                {
                    int num = Math.Min(n, queue.Count);
                    for (int i = 0; i < num; i++)
                    {
                        carsAcross.Enqueue(queue.Dequeue());
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            while (carsAcross.Count != 0)
            {
                Console.WriteLine($"{carsAcross.Dequeue()} passed!");
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
