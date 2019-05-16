using System;

namespace _01._Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int oldb = b;
                b = a % b;
                a = oldb;
            }
            Console.WriteLine(a);
        }
    }
}
