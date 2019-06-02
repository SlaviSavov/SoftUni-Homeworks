using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";

            string[] text = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordsPath);

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordLowerCase = word.ToLower();
                if (!wordsCount.ContainsKey(wordLowerCase))
                {
                    wordsCount.Add(wordLowerCase, 0);
                }
            }
            foreach (var currentLine in text)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] { ' ', '-', '?', '!', '.', ',', '\'', ':', ';' });
                foreach (var currentWord in currentLineWords)
                {
                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
            }
            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";


            foreach (var (word,count) in wordsCount)
            {
                File.AppendAllText(actualResultPath, $"{word} - {count}{Environment.NewLine}");
            }

            foreach (var (word, count) in wordsCount.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{word} - {count}{Environment.NewLine}");

            }
        }
    }
}
