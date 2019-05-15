using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonuss = 0;
            if (score <= 100)
            {
                bonuss = 5;
            }
            else if (score > 100 && score < 1000)
            {
                bonuss = (score * 0.20);
            }
            else if (score > 1000)
            {
                bonuss = score * 0.10;
            }
            if (score % 2 == 0)
            {
                bonuss += 1;
            }
            else if (score % 10 == 5)
            {
                bonuss += 2;
            }
            Console.WriteLine(bonuss);
            Console.WriteLine(score + bonuss);

        }
    }
}
