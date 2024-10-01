using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\myfile.txt";
            string path2 = @"D:\C_Sharp_FilePath\myfile2.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
                File.Copy(path, path2);
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
