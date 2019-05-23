namespace _09._Miner
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var field = new char[size, size];

            int minerRow = 0;
            int minerCol = 0;
            int allCoal = 0;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = input[col];
                    if (input[col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (input[col] == 'c')
                    {
                        allCoal++;
                    }
                }
            }
            int coal = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                if (command == "left" && minerCol > 0)
                {
                    if (field[minerRow, minerCol - 1] == 'c')
                    {
                        field[minerRow, minerCol - 1] = 's';
                        field[minerRow, minerCol] = '*';
                        minerCol -= 1;
                        coal++;
                        if (allCoal == coal)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                    }
                    else if (field[minerRow, minerCol - 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerRow}, {minerCol - 1})");
                        return;
                    }
                    else if (field[minerRow, minerCol - 1] == '*')
                    {
                        field[minerRow, minerCol - 1] = 's';
                        field[minerRow, minerCol] = '*';
                        minerCol -= 1;
                    }
                }
                else if (command == "right" && minerCol < size - 1)
                {
                    if (field[minerRow, minerCol + 1] == 'c')
                    {
                        field[minerRow, minerCol + 1] = 's';
                        field[minerRow, minerCol] = '*';
                        minerCol += 1;
                        coal++;
                        if (allCoal == coal)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                    }
                    else if (field[minerRow, minerCol + 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerRow}, {minerCol + 1})");
                        return;
                    }
                    else if (field[minerRow, minerCol + 1] == '*')
                    {
                        field[minerRow, minerCol + 1] = 's';
                        field[minerRow, minerCol] = '*';
                        minerCol += 1;
                    }
                }
                else if (command == "up" && minerRow > 0)
                {
                    if (field[minerRow - 1, minerCol] == 'c')
                    {
                        field[minerRow - 1, minerCol] = 's';
                        field[minerRow, minerCol] = '*';
                        minerRow -= 1;
                        coal++;
                        if (allCoal == coal)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                    }
                    else if (field[minerRow - 1, minerCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerRow - 1}, {minerCol })");
                        return;
                    }
                    else if (field[minerRow - 1, minerCol] == '*')
                    {
                        field[minerRow - 1, minerCol] = 's';
                        field[minerRow, minerCol] = '*';
                        minerRow -= 1;
                    }
                }
                else if (command == "down" && minerRow < size - 1)
                {
                    if (field[minerRow + 1, minerCol] == 'c')
                    {
                        field[minerRow + 1, minerCol] = 's';
                        field[minerRow, minerCol] = '*';
                        minerRow += 1;
                        coal++;
                        if (allCoal == coal)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                    }
                    else if (field[minerRow + 1, minerCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerRow + 1}, {minerCol })");
                        return;
                    }
                    else if (field[minerRow + 1, minerCol] == '*')
                    {
                        field[minerRow + 1, minerCol] = 's';
                        field[minerRow, minerCol] = '*';
                        minerRow += 1;
                    }
                }
            }
            Console.WriteLine($"{allCoal-coal} coals left. ({minerRow}, {minerCol})");
        }
    }
}
