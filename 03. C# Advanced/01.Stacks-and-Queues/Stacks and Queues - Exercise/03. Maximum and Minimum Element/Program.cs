using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        if (stack.Count != 0) stack.Pop();
                        break;
                    case 3:
                        if (stack.Count != 0)
                        {
                            var list1 = new List<int>(stack);
                            Console.WriteLine(list1.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count != 0)
                        {
                            var list2 = new List<int>(stack);
                            Console.WriteLine(list2.Min());
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
