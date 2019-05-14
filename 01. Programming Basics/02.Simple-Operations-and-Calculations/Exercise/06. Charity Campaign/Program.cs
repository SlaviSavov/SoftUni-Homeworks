using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int caker = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int wafer = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());
            double prcake = cake * 45;
            double prwafer = wafer * 5.80;
            double prpancake = pancake * 3.20;
            double perday = (prcake + prwafer + prpancake) * caker;
            double dday = perday * day;
            double finish = dday - dday / 8;
            Console.WriteLine("{0:F2}", finish);
        }
    }
}
