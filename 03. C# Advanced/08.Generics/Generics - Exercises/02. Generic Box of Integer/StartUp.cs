using System;

namespace GenericExercise
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

            var result = myBox.ToString();

            Console.WriteLine(result);
        }
    }
}
