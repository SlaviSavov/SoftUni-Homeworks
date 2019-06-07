using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => Char.IsUpper(w[0]));

            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}
