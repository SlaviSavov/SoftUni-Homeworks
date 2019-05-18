using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push($"{operand1 + operand2}");
                        break;
                    case "-":
                        stack.Push($"{operand1 - operand2}");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
