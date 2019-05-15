using System;

namespace _05._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string Type = Console.ReadLine();
            int Rows = int.Parse(Console.ReadLine());
            int Columns = int.Parse(Console.ReadLine());
            double Premiere = Rows * Columns * 12;
            double Normal = Rows * Columns * 7.5;
            double Discount = Rows * Columns * 5;
            if (Type == "Premiere")
                Console.WriteLine("{0:f2} leva", Premiere);
            else if (Type == "Normal")
                Console.WriteLine("{0:f2} leva", Normal);
            else if (Type == "Discount")
                Console.WriteLine("{0:f2} leva", Discount);
        }
    }
}
