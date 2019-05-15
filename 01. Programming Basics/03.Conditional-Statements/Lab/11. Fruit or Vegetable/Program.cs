using System;

namespace _11._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine().ToLower();

            if (item == "banana" || item == "apple" || item == "kiwi" || item == "cherry" || item == "lemon" || item == "grapes")
                Console.WriteLine("fruit");
            else if (item == "tomato" || item == "cucumber" || item == "pepper" || item == "carrot")
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");
        }
    }
}
