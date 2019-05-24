using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lair = new char[size[0], size[1]];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        playerCol = col;
                        playerRow = row;
                    }
                }
            }
            var commands = new Queue<char>(Console.ReadLine().ToCharArray());
            bool dead = false;
            bool win = false;

            while (commands.Count != 0)
            {
                char command = commands.Dequeue();
                if (command == 'L' && dead != true)
                {
                    if (playerCol == 0)
                    {
                        win = true;
                        lair[playerRow, playerCol] = '.';
                    }
                    else if (lair[playerRow, playerCol - 1] == '.')
                    {
                        lair[playerRow, playerCol - 1] = 'P';
                        lair[playerRow, playerCol] = '.';
                        playerCol -= 1;
                    }
                    else if (lair[playerRow, playerCol - 1] == 'B')
                    {
                        dead = true;
                        lair[playerRow, playerCol] = '.';
                        playerCol -= 1;
                    }
                }
                else if (command == 'R' && dead != true)
                {
                    if (playerCol == lair.GetLength(1) - 1)
                    {
                        win = true;
                        lair[playerRow, playerCol] = '.';
                    }

                    else if (lair[playerRow, playerCol + 1] == '.')
                    {
                        lair[playerRow, playerCol + 1] = 'P';
                        lair[playerRow, playerCol] = '.';
                        playerCol += 1;
                    }
                    else if (lair[playerRow, playerCol + 1] == 'B')
                    {
                        dead = true;
                        lair[playerRow, playerCol] = '.';
                        playerCol += 1;
                    }
                }
                else if (command == 'U' && dead != true)
                {
                    if (playerRow == 0)
                    {
                        win = true;
                        lair[playerRow, playerCol] = '.';
                    }

                    else if (lair[playerRow - 1, playerCol] == '.')
                    {
                        lair[playerRow - 1, playerCol] = 'P';
                        lair[playerRow, playerCol] = '.';
                        playerRow -= 1;
                    }
                    else if (lair[playerRow - 1, playerCol] == 'B')
                    {
                        dead = true;
                        lair[playerRow, playerCol] = '.';
                        playerRow -= 1;
                    }
                }
                else if (command == 'D' && dead != true)
                {
                    if (playerRow == lair.GetLength(0) - 1)
                    {
                        win = true;
                        lair[playerRow, playerCol] = '.';
                    }
                    else if (lair[playerRow + 1, playerCol] == '.')
                    {
                        lair[playerRow + 1, playerCol] = 'P';
                        lair[playerRow, playerCol] = '.';
                        playerRow += 1;
                    }
                    else if (lair[playerRow + 1, playerCol] == 'B')
                    {
                        dead = true;
                        lair[playerRow, playerCol] = '.';
                        playerRow += 1;
                    }
                }

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            if (IsInside(lair, row, col - 1))
                            {
                                if (lair[row, col - 1] == 'P')
                                {
                                    dead = true;
                                }
                                lair[row, col - 1] = 'C';
                            }
                            if (IsInside(lair, row, col + 1))
                            {
                                if (lair[row, col + 1] == 'P')
                                {
                                    dead = true;
                                }
                                lair[row, col + 1] = 'C';
                            }

                            if (IsInside(lair, row - 1, col))
                            {
                                if (lair[row - 1, col] == 'P')
                                {
                                    dead = true;
                                }
                                lair[row - 1, col] = 'C';
                            }

                            if (IsInside(lair, row + 1, col))
                            {
                                if (lair[row + 1, col] == 'P')
                                {
                                    dead = true;
                                }
                                lair[row + 1, col] = 'C';
                            }
                        }
                    }

                }
                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'C')
                        {
                            lair[row, col] = 'B';
                        }
                    }
                }
                if (dead)
                {
                    Print(lair);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                   return;
                }
                else if (win)
                {
                    Print(lair);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
            }
        }

        private static void Print(char[,] lair)
        {
            for (int i = 0; i < lair.GetLength(0); i++)
            {
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    Console.Write(lair[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(char[,] lair, int row, int col)
        {
            return row >= 0 && row < lair.GetLength(0)
                 && col >= 0 && col < lair.GetLength(1);
        }
    }

}
