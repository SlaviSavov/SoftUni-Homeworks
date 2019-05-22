using System;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] board = new char[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < rows; col++)
                {
                    board[row, col] = inputRow[col];
                }
            }
            int counter = 0;


            while (true)
            {
                int maxSum = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int knightsCount = 0;

                        if (board[row, col] == 'K')
                        {
                            if (isInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (isInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                knightsCount++;
                            }
                            if (knightsCount > maxSum)
                            {
                                maxSum = knightsCount;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }
                if (maxSum==0)
                {
                    break;
                }
                board[knightRow, knightCol] = '0';
                counter++;
                maxSum = 0;
            }
            Console.WriteLine(counter);
        }

        private static bool isInside(char[,] board, int desRow, int desCol)
        {
            return desRow < board.GetLength(0) && desRow >= 0 &&
                desCol < board.GetLength(1) && desCol >= 0;
        }
    }
}
