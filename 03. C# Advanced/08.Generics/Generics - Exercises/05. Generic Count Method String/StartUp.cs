using System;
using System.Linq;

namespace _05._Generic_Count_Method_String
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var myBox = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                myBox.Add(Console.ReadLine());
            }

            string compareString = Console.ReadLine();

            myBox.Compare(compareString);

            Console.WriteLine(myBox.GreaterCount);
        }
    }
}
