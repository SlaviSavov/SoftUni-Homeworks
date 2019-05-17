using System;

namespace _09._Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int i = 0; i <= 9; i++)
                            {
                                for (int f = 0; f <= 9; f++)
                                {
                                    if (a * b * c * d * i * f == n)
                                    {
                                        Console.Write($"{a}{b}{ c}{ d}{ i}{ f} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
