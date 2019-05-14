using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double pokrivka = num * (length + 2 * 0.30) * (width + 2 * 0.30);
            double kare = num * (length / 2) * (length / 2);
            double dollar = pokrivka * 7 + kare * 9;
            double lev = dollar * 1.85;
            Console.WriteLine("{0:f2} USD", dollar);
            Console.WriteLine("{0:f2} BGN", lev);
        }
    }
}
