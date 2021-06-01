using System;
using System.IO;

namespace Paths_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmpPath = @"C:\Users\Satya Maddila\source\repos\Paths Main\bin\Debug\netcoreapp3.1\file.txt";

            string fileExtension = Path.GetExtension(tmpPath);
            string filename = Path.GetFileName(tmpPath);
            string filenameWithoutExtension = Path.GetFileNameWithoutExtension(tmpPath);
            string rootPath = Path.GetPathRoot(tmpPath);
            string directory = Path.GetDirectoryName(tmpPath);
            string fullPath = Path.GetFullPath(tmpPath);

            Console.WriteLine(fileExtension);
            Console.WriteLine(filename);
            Console.WriteLine(filenameWithoutExtension);
            Console.WriteLine(rootPath);
            Console.WriteLine(directory);
            Console.WriteLine(fullPath);
        }
    }
}
