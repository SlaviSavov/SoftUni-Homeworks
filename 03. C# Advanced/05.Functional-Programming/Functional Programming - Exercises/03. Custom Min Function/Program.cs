using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Print(MinFunc(inputNum));
        }


        public static Action<int> Print = n => Console.WriteLine(n);

        public static Func<int[], int> MinFunc = numbers =>
        {
            int minNumb = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < minNumb)
                {
                    minNumb = number;
                }
            }

            return minNumb;
        };
    }
}
