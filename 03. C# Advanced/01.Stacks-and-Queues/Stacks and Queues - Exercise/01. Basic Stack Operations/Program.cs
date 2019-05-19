using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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
            var stack = new Stack<int>(numbers);

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = int.MaxValue;
                while (stack.Count!=0)
                {
                    if (stack.Peek()<min)
                    {
                        min = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                Console.WriteLine(min);
            }

        }
    }
}
