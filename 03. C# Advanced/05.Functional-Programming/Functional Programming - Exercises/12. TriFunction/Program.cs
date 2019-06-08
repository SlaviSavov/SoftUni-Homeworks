using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split()
                .ToArray();

            Func<string, int, bool> isLarger = (name, charLenght)
                     => name.Sum(x => x) >= charLenght;
            Func<string[], Func<string, int, bool>, string> nameFilter =
                (inputNames, isLargerFilter)
                => inputNames.FirstOrDefault(x => isLargerFilter(x, lenght));

            string result = nameFilter(names, isLarger);

            Console.WriteLine(result);
        }
    }
}
