using System;

namespace _09._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(deg));
        }
    }
}
