using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Space_Station_Establishment
{
    class Program
    {
        static char[][] galaxy;

        static List<int> blackHoleRow=new List<int>();
        static List<int> blackHoleCol=new List<int>();

        static int spaceShipRow;
        static int spaceShipCol;

        static int starPower = 0;


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            galaxy = new char[n][];

            Initialize();

            while (starPower<50)
            {
                var command = Console.ReadLine();

                if (command=="right")
                {
                    spaceShipCol++;

                    galaxy[spaceShipRow][spaceShipCol-1] = '-';

                    if (spaceShipCol == galaxy[spaceShipRow].Length)
                    {
                        OutOfGalaxy();
                    }
                    if (char.IsDigit(galaxy[spaceShipRow][spaceShipCol]))
                    {
                        CollectStar();
                    }
                    if (galaxy[spaceShipRow][spaceShipCol]=='O')
                    {
                        FindBlackHole();
                    }
                    galaxy[spaceShipRow][spaceShipCol] = 'S';

                }
                else if (command == "left")
                {
                    spaceShipCol--;

                    galaxy[spaceShipRow][spaceShipCol+1] = '-';

                    if (spaceShipCol < 0)
                    {
                        OutOfGalaxy();
                    }
                    if (char.IsDigit(galaxy[spaceShipRow][spaceShipCol]))
                    {
                        CollectStar();
                    }
                    if (galaxy[spaceShipRow][spaceShipCol] == 'O')
                    {
                        FindBlackHole();
                    }
                    galaxy[spaceShipRow][spaceShipCol] = 'S';


                }
                else if (command == "up")
                {
                    spaceShipRow--;

                    galaxy[spaceShipRow+1][spaceShipCol] = '-';

                    if (spaceShipRow <0)
                    {
                        OutOfGalaxy();
                    }
                    if (char.IsDigit(galaxy[spaceShipRow][spaceShipCol]))
                    {
                        CollectStar();
                    }
                    if (galaxy[spaceShipRow][spaceShipCol] == 'O')
                    {
                        FindBlackHole();
                    }
                    galaxy[spaceShipRow][spaceShipCol] = 'S';

                }
                else if (command == "down")
                {
                    spaceShipRow++;

                    galaxy[spaceShipRow-1][spaceShipCol] = '-';

                    if (spaceShipRow == galaxy[spaceShipCol].Length)
                    {
                        OutOfGalaxy();
                    }
                    if (char.IsDigit(galaxy[spaceShipRow][spaceShipCol]))
                    {
                        CollectStar();
                    }
                    if (galaxy[spaceShipRow][spaceShipCol] == 'O')
                    {
                        FindBlackHole();
                    }
                    galaxy[spaceShipRow][spaceShipCol] = 'S';

                }



            }
            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            End();
        }

        private static void FindBlackHole()
        {
            galaxy[spaceShipRow][spaceShipCol] = '-';
            blackHoleCol.Remove(spaceShipCol);
            blackHoleRow.Remove(spaceShipRow);

            spaceShipRow = blackHoleRow.FirstOrDefault();
            spaceShipCol = blackHoleCol.FirstOrDefault();

            galaxy[spaceShipRow][spaceShipCol] = 'S';
        }

        private static void CollectStar()
        {
            var findedStar = int.TryParse($"{galaxy[spaceShipRow][spaceShipCol]}", out int result );
           starPower += result;
            galaxy[spaceShipRow][spaceShipCol] = 'S';
        }

        private static void OutOfGalaxy()
        {
            Console.WriteLine("Bad news, the spaceship went to the void.");
            End();
        }
        private static void End()
        {
            Console.WriteLine($"Star power collected: {starPower}");

            for (int row = 0; row < galaxy.Length; row++)
            {
                for (int col = 0; col < galaxy.Length; col++)
                {
                    Console.Write(galaxy[row][col]);
                }
                Console.WriteLine();
            }

            Environment.Exit(0);
        }


        private static void Initialize()
        {
            for (int row = 0; row < galaxy.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                galaxy[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    galaxy[row][col] = input[col];

                    if (input[col]=='O')
                    {
                        blackHoleCol.Add(col);
                        blackHoleRow.Add(row);
                    }
                    if (input[col] == 'S')
                    {
                        spaceShipRow = row;
                        spaceShipCol = col;
                    }
                }
            }
        }
    }
}
