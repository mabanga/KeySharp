using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FileIO
{
    class Program
    {
        static string seedDay = DateTime.Now.Day.ToString();
        static string seedHour = DateTime.Now.Hour.ToString();
        static string seedMinute = DateTime.Now.Minute.ToString();
        static string seedSecond = DateTime.Now.Second.ToString();
        static string seedMonth = DateTime.Now.Month.ToString();
        static string seedYear = DateTime.Now.Year.ToString();
        static string rootDir = @"c:\intec\data\";
        static string lottoFile = $"{seedDay}.{seedMonth}.{seedYear}_{seedHour}.{seedMinute}.{seedSecond}.txt";
        static string fullPath = $"{rootDir + lottoFile}";
        public static List<int> Numbers = new List<int>();
        public static int random;
        static void Main(string[] args)
        {
            CreateDirectory(rootDir);
            PickAnumber();
            Write(fullPath, Numbers);
            Quit();
        }
        static void PickAnumber()
        {
            for (int i = 1; i < 7; i++)
            {
                random = new Random().Next(1, 45);
                Thread.Sleep(500);
                Numbers.Add(random);
                Console.WriteLine($"Random({i}): {random}");
            }
            Numbers.Sort();
        }
        static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(rootDir))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Directory \"{path}\" has been created.");
                }
                else
                {
                    Console.WriteLine($"RootPath: \"{path}\" ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        static void Write(string path, List<int> list)
        {
            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);

            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
            writer.Flush();
            writer.Close();
        }
        static void Quit()
        {
            Console.SetCursorPosition(7, 25);
            Console.CursorVisible = false;
            Console.Write("Press any key to quit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
