using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input =>
              Console.WriteLine(string.Join(Environment.NewLine, input));

            var inputNames = Console.ReadLine()
                .Split();

            print(inputNames);
        }
    }
}
