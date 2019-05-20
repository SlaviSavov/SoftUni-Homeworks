namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var cupsCapacity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var bottlesCapacity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(bottlesCapacity);

            int wastedLittersOfWater = 0;

            while (cups.Count!=0&&bottles.Count!=0)
            {
                if (bottles.Peek()>=cups.Peek())
                {
                    wastedLittersOfWater += bottles.Pop() - cups.Dequeue();
                }
                else
                {
                    int remainderFreeSpace = cups.Dequeue() - bottles.Pop();

                    while (true)
                    {
                        if (bottles.Peek() >= remainderFreeSpace)
                        {
                            wastedLittersOfWater += bottles.Pop() - remainderFreeSpace;
                            break;
                        }
                        else
                        {
                            remainderFreeSpace -= bottles.Pop();
                        }
                    }

                }
            }
            if (bottles.Count==0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");


        }
    }
}
