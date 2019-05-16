using System;

namespace _06._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int payment = 0;
            double sum = 0;

            int target = int.Parse(Console.ReadLine());

            while (target > payment)
            {
                double input = double.Parse(Console.ReadLine());
                if (input > 0)
                {
                    Console.WriteLine($"Increase: {input:F2}");
                    sum += input;
                    ++payment;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum}");
                    return;
                }
            }
            Console.WriteLine($"Total: {sum}");
        }
    }
}
