using System;

namespace _06._Generic_Count_Method_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var myBox = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                myBox.Add(double.Parse(Console.ReadLine()));
            }

            double compareDouble = double.Parse(Console.ReadLine());

            myBox.Compare(compareDouble);

            Console.WriteLine(myBox.GreaterCount);
        }
    }
}
