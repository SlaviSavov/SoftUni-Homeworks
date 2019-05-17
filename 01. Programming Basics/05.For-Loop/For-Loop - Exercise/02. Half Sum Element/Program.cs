using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                double inPut = double.Parse(Console.ReadLine());

                if (inPut > max) max = inPut;
                sum += inPut;
            }
            double total = sum -= max;

            if (total != max)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(total - max)}");
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
        }
    }
}
