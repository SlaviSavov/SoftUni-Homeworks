using System;

namespace _01._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);
            double S = x * y;
            double P = 2 * (x + y);
            Console.WriteLine($"{S:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
