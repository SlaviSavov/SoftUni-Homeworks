using System;

namespace _03._Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 1; i <= num; i++)
            {
                double inPut = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inPut;
                    if (inPut < evenMin) evenMin = inPut;
                    if (inPut > evenMax) evenMax = inPut;
                }
                else
                {
                    oddSum += inPut;
                    if (inPut < oddMin) oddMin = inPut;
                    if (inPut > oddMax) oddMax = inPut;
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != int.MaxValue) Console.WriteLine($"OddMin={oddMin:f2},");
            else Console.WriteLine("OddMin=No,");
            if (oddMax != int.MinValue) Console.WriteLine($"OddMax={oddMax:f2},");
            else Console.WriteLine("OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin != int.MaxValue) Console.WriteLine($"EvenMin={evenMin:f2},");
            else Console.WriteLine("EvenMin=No,");
            if (evenMax != int.MinValue) Console.WriteLine($"EvenMax={evenMax:f2}");
            else Console.WriteLine("EvenMax=No");
        }
    }
}
