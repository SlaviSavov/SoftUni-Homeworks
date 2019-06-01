using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader firstFile = new StreamReader(Path.Combine("files", "FileOne.txt"));
            StreamReader secondFile = new StreamReader(Path.Combine("files", "FileTwo.txt"));
            StreamWriter output = new StreamWriter(Path.Combine("files", "output.txt"));

            var result = new List<int>();

            using (firstFile)
            {
                string line = string.Empty;

                while ((line = firstFile.ReadLine()) != null)
                {
                    int[] lineNum = line.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    for (int i = 0; i < lineNum.Length; i++)
                    {
                        result.Add(lineNum[i]);
                    }
                }
            }


            using (secondFile)
            {
                string lineSecondFile = string.Empty;

                while ((lineSecondFile = secondFile.ReadLine()) != null)
                {
                    int[] lineNum = lineSecondFile.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    for (int i = 0; i < lineNum.Length; i++)
                    {
                        result.Add(lineNum[i]);
                    }
                }
            }
            using (output)
            {
                foreach (var num in result.OrderBy(x => x))
                {
                    output.WriteLine(num);
                }

            }
        }
    }
}
