using System;

namespace _05._Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDaysBetweenDates (firstDate,secondDate));
        }
    }
}
