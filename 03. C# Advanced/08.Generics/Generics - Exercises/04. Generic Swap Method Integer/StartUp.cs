using System;
using System.Linq;

namespace _04._Generic_Swap_Method_Integer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var myBox = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                myBox.Add(int.Parse(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var index1 = indexes[0];
            var index2 = indexes[1];

            myBox.Swap(index1, index2);


            var result = myBox.ToString();

            Console.WriteLine(result);
        }
    }
}
