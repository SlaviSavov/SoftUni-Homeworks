using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();
            Console.WriteLine(num.Length);
            Console.WriteLine(num.Sum());
        }
        public static Func<string, int> Parse = n => int.Parse(n);
    }
}
