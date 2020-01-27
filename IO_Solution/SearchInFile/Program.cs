using System;
using System.IO;

namespace SearchInFile
{
    class Program
    {
        static string file = @"C:\tmp\test.txt";
        static bool found = false;
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(file).Split(' ');
           //int[] _r= File.ReadAllLines(file).Split(' ');
            //int[] numbers = File.ReadAllLines(file);
            string searchFor = "1000";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(searchFor))
                {
                    found = true;
                    break;
                }
            }
            if (found==true)
            {
                Console.WriteLine($"Record found");
            }
            else
            {
                Console.WriteLine($"Record not found");
            }
            Console.ReadKey();
        }
    }
}
