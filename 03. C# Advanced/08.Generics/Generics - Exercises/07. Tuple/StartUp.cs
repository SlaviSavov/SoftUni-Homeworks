using System;
using System.Linq;

namespace _07._Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine()
                .Split()
                .ToArray();
            var nameBeerInfo = Console.ReadLine()
                .Split()
                .ToArray();
            var numbersInfo = Console.ReadLine()
                .Split()
                .ToArray();

            string nameOfPerson = personInfo[0] + " " + personInfo[1];
            string town = personInfo[2];

            string name = nameBeerInfo[0];
            int litersBeer = int.Parse(nameBeerInfo[1]);

            int myInt = int.Parse(numbersInfo[0]);
            double myDouble = double.Parse(numbersInfo[1]);

            var personTuple = new Tuple<string, string>(nameOfPerson, town);
            var nameBeerTuple = new Tuple<string, int>(name, litersBeer);
            var numTuple = new Tuple<int, double>(myInt, myDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(nameBeerTuple.GetInfo());
            Console.WriteLine(numTuple.GetInfo());
        }
    }
}
