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
            StreamReader fileWords = new StreamReader(Path.Combine("files", "words.txt"));
            StreamReader fileText = new StreamReader(Path.Combine("files", "text.txt"));
            StreamWriter fileDestination = new StreamWriter(Path.Combine("files", "output.txt"));
            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            using (fileWords)
            {
                string line = fileWords.ReadLine();

                while (line != null)
                {
                    string[] lineWords = line.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < lineWords.Length; i++)
                    {
                        lineWords[i] = lineWords[i].ToLower();

                        if (!(wordsDictionary.ContainsKey(lineWords[i])))
                        {
                            wordsDictionary.Add(lineWords[i], 0);
                        }
                    }

                    line = fileWords.ReadLine();
                }

                using (fileText)
                {
                    using (fileDestination)
                    {
                        string lineText = fileText.ReadLine();

                        while (lineText != null)
                        {
                            string[] lineTextSplited = lineText.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                                StringSplitOptions.RemoveEmptyEntries);

                            for (int j = 0; j < lineTextSplited.Length; j++)
                            {
                                lineTextSplited[j] = lineTextSplited[j].ToLower();

                                if (wordsDictionary.ContainsKey(lineTextSplited[j]))
                                {
                                    wordsDictionary[lineTextSplited[j]] += 1;
                                }
                            }

                            lineText = fileText.ReadLine();
                        }

                        foreach (var wordCount in wordsDictionary.OrderByDescending(key => key.Value))
                        {
                            fileDestination.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
                        }
                    }
                }
            }
        }
    }
}

