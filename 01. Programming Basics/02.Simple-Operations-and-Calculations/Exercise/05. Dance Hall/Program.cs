using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double area = (L * 100) * (W * 100);
            double wardrobe = ((A * 100) * (A * 100));
            double bench = area / 10;
            double free = area - wardrobe - bench;
            double result = free / (40 + 7000);
            Console.WriteLine(Math.Truncate(result));
        }
    }
}
