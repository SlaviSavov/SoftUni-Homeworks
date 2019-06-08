using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> multiplyArr = n => n *= 2;
            Func<int, int> addArr = n => n += 1;
            Func<int, int> subtractArr = n => n -= 1;
            Action<int[]> print = n => Console.WriteLine(string.Join(" ",n));



            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var input = string.Empty;

            while ((input = Console.ReadLine())!="end")
            {
                if (input=="multiply")
                {
                    numbers = numbers.Select(multiplyArr).ToArray();
                }
                else if (input == "add")
                {
                    numbers = numbers.Select(addArr).ToArray();
                }
                else if (input == "subtract")
                {
                    numbers = numbers.Select(subtractArr).ToArray();
                }
                else if (input=="print")
                {
                    print(numbers);
                }

            }
        }
    }
}
