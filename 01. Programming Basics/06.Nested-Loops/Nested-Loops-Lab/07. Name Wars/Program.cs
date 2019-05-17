using System;

namespace _07._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int maxSum = 0;
            string nameMax = "";
            maxSum = int.MinValue;
            while (true)
            {
                name = Console.ReadLine();
                int sum = 0;

                if (name == "STOP")
                {
                    break;
                }
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];

                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    nameMax = name;
                }

            }
            Console.WriteLine($"Winner is {nameMax} - {maxSum}!");
        }
    }
}
