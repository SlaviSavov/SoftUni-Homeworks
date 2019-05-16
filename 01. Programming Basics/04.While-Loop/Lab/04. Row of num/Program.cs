using System;

namespace _04._Row_of_num
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;



            while (command != "END")
            {
                int number = int.Parse(command);

                if (number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                command = Console.ReadLine();

            }

            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);
        }
    }
}
