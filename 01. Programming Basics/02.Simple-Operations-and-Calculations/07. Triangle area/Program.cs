using System;

namespace _07._Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = a * h / 2;

            Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");
        }
    }
}
