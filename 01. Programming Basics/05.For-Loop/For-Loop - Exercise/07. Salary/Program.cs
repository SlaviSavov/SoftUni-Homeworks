using System;

namespace _07._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabSite = int.Parse(Console.ReadLine());
            double salary = int.Parse(Console.ReadLine());
            double lost = 0;


            for (int i = 0; i < tabSite; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook") lost += 150;
                if (site == "Instagram") lost += 100;
                if (site == "Reddit") lost += 50;

                if (salary <= lost)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary - lost);

        }
    }
}
