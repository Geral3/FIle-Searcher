using System.IO;
using System;
namespace File_Searcher
{
    public class Search
    {
        
        public static string[] searchEXT(string dir, string ext)
        {
            try
            {
                string[] dirs = Directory.GetFiles(dir, "*." + ext, SearchOption.AllDirectories);
                foreach (var x in dirs)
                {
                    Console.WriteLine($"{x}: {new FileInfo(x).Length} Bytes");
                }

                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
                return dirs;
            }
            catch
            {
                Console.WriteLine("No results found press any key to exit");
                Console.ReadLine();
                return null;
            }
        }
        public static string[] searchNAME(string dir, string file)
        {
            try
            {
                string[] dirs = Directory.GetFiles(dir, file + ".*", SearchOption.AllDirectories);
                foreach (var x in dirs)
                {
                    Console.WriteLine($"{x}: {new FileInfo(x).Length} Bytes");
                }

                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
                return dirs;
            }
            catch
            {
                Console.WriteLine("No results found press any key to exit");
                Console.ReadLine();
                return null;
            }
        }
        
    }
}