using System;

namespace _05._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p1n = 0;
            double p2 = 0;
            double p2n = 0;
            double p3 = 0;
            double p3n = 0;
            double p4 = 0;
            double p4n = 0;
            double p5 = 0;
            double p5n = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1 += num;
                    p1n++;
                }
                else if (num < 400)
                {
                    p2 += num;
                    p2n++;
                }
                else if (num < 600)
                {
                    p3 += num;
                    p3n++;
                }

                else if (num < 800)
                {
                    p4 += num;
                    p4n++;
                }
                else
                {
                    p5 += num;
                    p5n++;
                }
            }
            Console.WriteLine($"{(p1n / n * 100):f2}%");
            Console.WriteLine($"{(p2n / n * 100):f2}%");
            Console.WriteLine($"{(p3n / n * 100):f2}%");
            Console.WriteLine($"{(p4n / n * 100):f2}%");
            Console.WriteLine($"{(p5n / n * 100):f2}%");

        }
    }
}
