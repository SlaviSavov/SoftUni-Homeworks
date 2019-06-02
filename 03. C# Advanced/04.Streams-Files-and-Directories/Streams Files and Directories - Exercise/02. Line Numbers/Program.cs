using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string outputPath = "output.txt";

            var textLine = File.ReadAllLines(textPath);
            int lineCount = 1;

            foreach (var line in textLine)
            {
                int lettersCount = line.Count(char.IsLetter);
                int punctsCount = line.Count(char.IsPunctuation);

                
                File.AppendAllText(outputPath, $"Line {lineCount}: {line} ({lettersCount})({punctsCount}){Environment.NewLine}");

                lineCount++;
            }

        }
    }
}
