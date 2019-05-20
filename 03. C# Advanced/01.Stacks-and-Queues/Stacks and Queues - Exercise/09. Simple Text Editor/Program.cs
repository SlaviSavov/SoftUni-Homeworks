namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> undoStack = new Stack<string>();

            int count = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];

                if (command == "1")
                {
                    undoStack.Push(text.ToString());
                    text.Append(input[1]);
                }
                else if (command == "2")
                {
                    undoStack.Push(text.ToString());
                    int index = int.Parse(input[1]);
                    text = text.Remove(text.Length - index, index);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    text.Clear();
                    text.Append(undoStack.Pop());
                }
            }
        }
    }
}
