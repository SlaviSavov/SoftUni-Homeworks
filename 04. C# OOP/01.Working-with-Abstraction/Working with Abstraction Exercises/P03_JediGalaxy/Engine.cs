﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_JediGalaxy
{
    public class Engine
    {
        private int[,] matrix;

        private long totalSum;
        public void Run()
        {
            int[] dimensions = Splitter(Console.ReadLine());

            int rows = dimensions[0];
            int cols = dimensions[1];

            this.InitializeMatrix(rows, cols);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] playerCordinates = Splitter(command);

                int[] evilCordinates = Splitter(Console.ReadLine());

                int evilRow = evilCordinates[0];
                int evilCol = evilCordinates[1];

                MoveElivToTopLeftCorner(evilRow, evilCol);

                int playerRow = playerCordinates[0];
                int playerCol = playerCordinates[1];

                MovePlayerToRightCorner(playerRow, playerCol);

                command = Console.ReadLine();
            }

            Console.WriteLine(totalSum);


        }

        private static int[] Splitter(string input)
        {
            return input
    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
        }

        private void MovePlayerToRightCorner(int playerRow, int playerCol)
        {
            while (playerRow >= 0 && playerCol < matrix.GetLength(1))
            {
                if (IsInside(playerRow, playerCol))
                {
                    totalSum += matrix[playerRow, playerCol];
                }

                playerCol++;
                playerRow--;
            }
        }

        private void MoveElivToTopLeftCorner(int evilRow, int evilCol)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (this.IsInside(evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }

        private bool IsInside(int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                && targetCol >= 0 && targetCol < matrix.GetLength(1);
        }

        private void InitializeMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
            int value = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }
    }
}
