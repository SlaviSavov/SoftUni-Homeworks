using System;

namespace _06._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double even = 0;
            double odd = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0) even += num;
                else odd += num;
            }
            if (even == odd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(odd - even)}");
            }
        }
    }
}
