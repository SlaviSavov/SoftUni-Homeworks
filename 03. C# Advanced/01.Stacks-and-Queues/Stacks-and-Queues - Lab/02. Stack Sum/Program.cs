using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse);
            var stack = new Stack<int>(input);

            string[] command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else
                {
                    if (int.Parse(command[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
