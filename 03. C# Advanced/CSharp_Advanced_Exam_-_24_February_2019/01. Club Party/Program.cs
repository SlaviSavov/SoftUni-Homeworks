using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split().ToArray();

            var elements = new Stack<string>(input);
            var halls = new Queue<string>();
            var reservation = new List<int>();

            var capacity = 0;

            while (elements.Count != 0)
            {
                var element = elements.Pop();

                bool isLeter = int.TryParse(element, out int result);

                if (!isLeter)
                {
                    halls.Enqueue(element);
                }
                else
                {
                    if (capacity + result > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", reservation)}");
                        capacity = 0;
                        reservation.Clear();
                    }
                    if (halls.Count != 0)
                    {
                        capacity += result;
                        reservation.Add(result);
                    }
                }
            }

        }
    }
}
