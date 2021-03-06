﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileArray = Directory.GetFiles(".", "*.*");

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(".");

            FileInfo[] allFile = directoryInfo.GetFiles();

            foreach (var currentFile in allFile)
            {
                double size = currentFile.Length / 1024d;
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";


            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (extension, value) in sortedDictionary)
            {
                File.AppendAllText(path, extension + Environment.NewLine);
                foreach (var (fileName, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{fileName} - {size:f3}kb" + Environment.NewLine);
                }
            }

        }
    }
}
