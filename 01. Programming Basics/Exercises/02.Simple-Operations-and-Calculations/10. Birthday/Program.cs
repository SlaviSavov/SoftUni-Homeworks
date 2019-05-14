using System;

namespace _10._Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var litersNeed = ((l * w * h) * 0.001) * (1 - (percent * 0.01));

            Console.WriteLine($"{litersNeed:F3}");
        }
    }
}
