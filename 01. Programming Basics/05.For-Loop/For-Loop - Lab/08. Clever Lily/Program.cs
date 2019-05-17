using System;

namespace _08._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double machine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            double sum = 0;
            double toy = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (i / 2) * 10;
                    sum -= 1;
                }
                else toy++;
            }
            sum += toy * priceToy;

            if (sum >= machine) Console.WriteLine($"Yes! {sum - machine:F2}");
            else Console.WriteLine($"No! {Math.Abs(machine - sum):f2}");

        }
    }
}
