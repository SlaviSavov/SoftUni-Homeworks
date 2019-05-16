using System;

namespace _04._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double saveMoney = double.Parse(Console.ReadLine());
            double saveSum = 0 + saveMoney;
            int badDay = 0;
            int day = 0;

            while (true)
            {
                string saveOrSpend = Console.ReadLine();
                double sOsSum = double.Parse(Console.ReadLine());
                day++;
                if (saveOrSpend == "save")
                {
                    saveSum += sOsSum;
                    badDay = 0;
                }
                else if (saveOrSpend == "spend")
                {
                    badDay++;
                    if (sOsSum > saveSum) saveSum = 0;
                    else saveSum -= sOsSum;
                }


                if (badDay == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(day);
                    return;
                }
                else if (moneyForVacation <= saveSum)
                {
                    Console.WriteLine($"You saved the money for {day} days.");
                    return;
                }
            }
        }
    }
}
