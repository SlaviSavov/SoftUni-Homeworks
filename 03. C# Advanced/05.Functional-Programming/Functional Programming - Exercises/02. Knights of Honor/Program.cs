using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input =>
  Console.WriteLine("Sir " + string.Join(Environment.NewLine + $"Sir ", input));

            var inputNames = Console.ReadLine()
                .Split();

            print(inputNames);

        }
    }
}
