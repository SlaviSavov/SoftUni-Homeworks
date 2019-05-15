using System;

namespace _04._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int mins = min + 15;
            if (mins > 59)
            {
                mins = mins - 60;
                hour = hour + 1;
                if (hour >= 24)
                {
                    hour = hour - 24;
                }
            }
            if (mins < 10)
            {
                Console.WriteLine(hour + ":0" + mins);
            }
            else
            {
                Console.WriteLine(hour + ":" + mins);
            }
        }
    }
}
