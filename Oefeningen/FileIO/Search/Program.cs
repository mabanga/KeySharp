using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Search
{
    class Program
    {
        static string rootDir = @"c:\intec\data\";
        static string file = "Films.txt";
        static string fullPath = $"{rootDir + file}";
        static bool found = false;
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(fullPath).Split(' ');
            string searchFor = "2004";
            int index = 0;
            foreach (var item in words)
            {
                if (item.Contains(searchFor))
                {
                    found = true;
                    Console.WriteLine($"Found: {++index} {item}");
                }
            }
            Console.WriteLine($"Number of Found: {index}");

            Console.ReadKey();
        }
    }
}
