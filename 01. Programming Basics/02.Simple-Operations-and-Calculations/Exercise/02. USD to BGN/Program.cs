using System;

namespace _02._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine("{0:f2} BGN", bgn);
        }
    }
}
