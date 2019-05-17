using System;

namespace _01._Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int firstNumber = a; firstNumber <= b; firstNumber++)
            {
                for (int secondNumber = a; secondNumber <= b; secondNumber++)
                {
                    for (int thirdNumber = c; thirdNumber <= d; thirdNumber++)
                    {
                        for (int fourthNumber = c; fourthNumber <= d; fourthNumber++)
                        {
                            if (firstNumber != secondNumber && thirdNumber != fourthNumber)
                            {
                                if (firstNumber + fourthNumber == secondNumber + thirdNumber)
                                {
                                    Console.WriteLine($"{firstNumber}{secondNumber}");
                                    Console.WriteLine($"{thirdNumber}{fourthNumber}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
