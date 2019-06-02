using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (FileStream streamReader=new FileStream(picPath,FileMode.Open))
            {
                
            }
        }
    }
}
