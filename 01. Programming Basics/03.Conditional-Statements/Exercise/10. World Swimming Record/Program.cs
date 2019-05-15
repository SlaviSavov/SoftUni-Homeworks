using System;

namespace _10._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meter = double.Parse(Console.ReadLine());
            double onemet = double.Parse(Console.ReadLine());

            double swim = meter * onemet;
            double delay = (Math.Floor(meter / 15)) * 12.5;
            double swimtime = Math.Abs(swim + delay);
            if (swimtime < record)
            {
                Console.WriteLine(" Yes, he succeeded! The new world record is {0:F2} seconds.", swimtime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", Math.Abs(record - swimtime));
            }
        }
    }
}
