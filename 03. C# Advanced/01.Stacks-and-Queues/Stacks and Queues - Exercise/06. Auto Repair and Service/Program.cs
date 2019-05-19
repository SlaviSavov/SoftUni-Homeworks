namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var carModels = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var queue = new Queue<string>(carModels);
            var history = new Stack<string>();

            string command = Console.ReadLine();

            while (command?.ToLower() != "end")
            {
                if (command == "Service" && queue.Count > 0)
                {
                    Console.WriteLine($"Vehicle {queue.Peek()} got served.");
                    history.Push(queue.Dequeue());
                }
                else if (command.Contains("CarInfo"))
                {
                    var carInfo = command.Split('-')[1];
                    if (queue.Contains(carInfo))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }

                else if (command == "History" && history.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", history));
                }
                command = Console.ReadLine();
            }
            if (queue.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }
            if (history.Count != 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", history)}");
            }
        }
    }
}
