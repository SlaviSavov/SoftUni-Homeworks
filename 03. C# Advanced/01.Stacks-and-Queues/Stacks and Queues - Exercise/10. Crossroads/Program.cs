namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueOfCar = new Queue<string>();

            int greenLine = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int count = 0;

            bool isHitted = false;
            string hittedCarName = string.Empty;
            char hittedSymbol = '\0';

            string input = Console.ReadLine();
            while (input?.ToLower() != "end")
            {
                if (input != "green")
                {
                    queueOfCar.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentGreenLine = greenLine;
                while (currentGreenLine>0 && queueOfCar.Count>0)
                {
                    string carName = queueOfCar.Dequeue();
                    int carLength = carName.Length;

                    if (currentGreenLine-carLength >= 0)
                    {
                        currentGreenLine -= carLength;
                        count++;
                    }
                    else
                    {
                        currentGreenLine += freeWindow;

                        if (currentGreenLine- carLength >= 0)
                        {
                            count++;
                            break; 
                        }
                        else
                        {
                            isHitted = true;
                            hittedCarName = carName;
                            hittedSymbol = carName[currentGreenLine];
                            break;

                        }
                    }
                }
                if (isHitted)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hittedCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
        }
    }
}
