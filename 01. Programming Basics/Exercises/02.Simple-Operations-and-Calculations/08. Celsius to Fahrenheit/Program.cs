using System;

namespace _08._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());
            var fahr = cel * 1.8 + 32;

            Console.WriteLine(Math.Round(fahr, 2));
        }
    }
}
