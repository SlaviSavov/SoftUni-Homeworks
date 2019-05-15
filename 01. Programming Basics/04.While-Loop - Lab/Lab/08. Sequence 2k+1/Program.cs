using System;

namespace _08._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
            double n = double.Parse(Console.ReadLine());

            while (num <= n)
            {
                Console.WriteLine(num);
                num = (num * 2 + 1);
            }
        }
    }
}
