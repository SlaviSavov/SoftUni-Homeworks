using System;

namespace _06._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekendsInSofia = (48.0 - h) * 0.75;
            double gamesInHolidays = p * 2 / 3.0;
            double sumGames = weekendsInSofia + h + gamesInHolidays;

            if (year == "leap")
            {
                sumGames = sumGames + (sumGames * 0.15);
            }

            Console.WriteLine(Math.Truncate(sumGames));
        }
    }
}
