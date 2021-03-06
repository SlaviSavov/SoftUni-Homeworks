﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var comming = Console.ReadLine()
                .Split()
                .ToList();

            ExecuteCommands(comming);
            PrintCommingList(comming);
        }

        private static void PrintCommingList(List<string> comming)
        {
            if (comming.Any())
            {
                var names = string.Join(", ", comming);
                Console.WriteLine($"{names} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ExecuteCommands(List<string> comming)
        {
            var input = Console.ReadLine();

            while (input != "Party!")
            {
                var command = input.Split();

                switch (command[1])
                {
                    case "StartsWith":
                        ForeachName(command[0], comming, n => n.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ForeachName(command[0], comming, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForeachName(command[0], comming, n => n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void ForeachName(string command, List<string> comming, Func<string, bool> condition)
        {
            for (int i = comming.Count - 1; i >= 0; i--)
            {
                if (condition(comming[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            comming.RemoveAt(i);
                            break;
                        case "Double":
                            comming.Add(comming[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
