using System;
using System.Linq;

namespace GenericExercise
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
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex  = indexes[1];

            myBox.Swap(firstIndex, secondIndex);


            var result = myBox.ToString();

            Console.WriteLine(result);
        }
    }
}
