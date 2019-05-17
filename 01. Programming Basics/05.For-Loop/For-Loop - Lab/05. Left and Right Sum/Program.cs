using System;

namespace _05._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double leftSum = 0;
            double rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                double sum = double.Parse(Console.ReadLine());
                leftSum += sum;
            }
            for (int i = 0; i < n; i++)
            {
                double sum = double.Parse(Console.ReadLine());
                rightSum += sum;
            }

            if (rightSum == leftSum) Console.WriteLine($"Yes, sum = {leftSum}");
            else Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}
