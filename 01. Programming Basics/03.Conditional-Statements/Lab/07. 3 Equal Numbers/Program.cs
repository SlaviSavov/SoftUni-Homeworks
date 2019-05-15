using System;

namespace _07._3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double a3 = double.Parse(Console.ReadLine());
            if (a1 == a2 && a2 == a3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
