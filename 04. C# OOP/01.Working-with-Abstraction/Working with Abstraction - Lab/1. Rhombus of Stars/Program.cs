using System;

namespace _1._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                printRow(i,count);
            }

            for (int i = count -1; i > 0; i--)
            {
                printRow(i, count);
            }
        }

        private static void printRow(int stars, int total)
        {
            int leadingSpaces = total - stars;
            Console.Write(new string(' ',leadingSpaces));

            for (int i = 0; i < stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
