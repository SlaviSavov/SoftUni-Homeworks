using System;
using System.Linq;

namespace _08._Threeuple
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
            string adress = personInfo[2];
            string town = personInfo[3];

            string name = nameBeerInfo[0];
            int litersBeer = int.Parse(nameBeerInfo[1]);
            bool thirdParam = true;
            if (nameBeerInfo[2]=="not")
            {
                thirdParam = false;
            }


            string anyName = numbersInfo[0];
            double myDouble = double.Parse(numbersInfo[1]);
            string bankName = numbersInfo[2];


            var personTuple = new Tuple<string, string, string>(nameOfPerson, adress, town);
            var nameBeerTuple = new Tuple<string, int, bool>(name, litersBeer, thirdParam);
            var numTuple = new Tuple<string, double, string>(anyName, myDouble, bankName);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(nameBeerTuple.GetInfo());
            Console.WriteLine(numTuple.GetInfo());
        }
    }
}
