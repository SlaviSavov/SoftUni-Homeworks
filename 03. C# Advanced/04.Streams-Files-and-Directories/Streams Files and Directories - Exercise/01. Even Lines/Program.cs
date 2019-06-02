using System;
using System.IO;
using System.Linq;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = Path.Combine("text.txt");
            int count = 0;

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                using (StreamWriter streamWriter = new StreamWriter("output.txt"))
                {
                    string currentLine = string.Empty;
                    while ((currentLine = streamReader.ReadLine()) != null)
                    {
                        if (count % 2 == 0)
                        {
                            string replacedSymbols = ReplaceSpecialCharacter(currentLine);
                            string reversedWords = ReverseWords(replacedSymbols);

                            streamWriter.WriteLine(reversedWords);
                        }
                        count++;
                    }
                }
            }
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split(" ").Reverse());
        }

        private static string ReplaceSpecialCharacter(string currentLine)
        {
            return currentLine.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
