using System;

namespace _05._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floor; i >= 1; i--)
            {
                if (i == floor)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    Console.WriteLine();
                }
                if (i % 2 != 0 && i != floor)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    Console.WriteLine();
                }
                else if (i % 2 == 0 && i != floor)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
