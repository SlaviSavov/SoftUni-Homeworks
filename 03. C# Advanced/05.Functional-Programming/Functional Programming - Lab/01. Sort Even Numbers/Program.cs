﻿using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n=>n%2==0)
                .OrderBy(n=>n)
                .ToArray();

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
