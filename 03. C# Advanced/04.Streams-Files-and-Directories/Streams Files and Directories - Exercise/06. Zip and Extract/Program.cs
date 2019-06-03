using System;
using System.IO;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "copyMe.png";
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/zipPic.zip";

            using (var archive=ZipFile.Open(targetPath,ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
