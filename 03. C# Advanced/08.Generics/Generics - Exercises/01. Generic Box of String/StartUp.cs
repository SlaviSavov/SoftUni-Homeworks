using System;

namespace GenericExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<string> myBox = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                myBox.Add(Console.ReadLine());
            }

            var result = myBox.ToString();

            Console.WriteLine(result);
        }
    }
}
