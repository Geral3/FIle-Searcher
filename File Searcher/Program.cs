using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using static File_Searcher.Search;

namespace File_Searcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir, name, ext;
            Console.WriteLine("Please Pick an option\n1. Search for files in a directory based on name\n2. Search for files in a directory based on extension\n3. Exit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please enter the directory of the desired location");
                    dir = Console.ReadLine();
                    Console.WriteLine("Please enter the name of the desired file");
                    name = Console.ReadLine();
                    Search.searchNAME(dir, name);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please enter the directory of the desired location");
                    dir = Console.ReadLine();
                    Console.WriteLine("Please enter the extension of the desired file");
                    ext = Console.ReadLine();
                    Search.searchEXT(dir, ext);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please pick an option between the ranges 1-3");
                    break;
            }
        }
    }
}