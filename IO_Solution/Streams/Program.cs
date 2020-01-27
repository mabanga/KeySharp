using System;
using System.IO;
using System.Text;
namespace Streams
{
    class Program
    {
        static string file = @"C:\tmp\test.txt";
        static void Main(string[] args)
        {
            stWriter(file);
            stReader(file);
            Console.ReadKey();
        }

        static void stWriter(string file) 
        {
            //string tempString = "";
            int tempInt = 0;
            StreamWriter writer = new StreamWriter(file, true,Encoding.UTF8);

            do
            {
                //Console.Write($"enter a name: ");
                Console.Write($"enter a number: ");
                tempInt = Convert.ToInt32(Console.ReadLine());
                //tempString = Console.ReadLine();
                if ((tempInt != -1))
                {
                    writer.WriteLine(tempInt);
                }
                else
                {
                    writer.Flush();
                    writer.Close();
                }
                //if ((tempInt != -1))
                //{
                //    writer.WriteLine(tempInt);
                //}
                //else
                //{
                //    writer.Flush();
                //    writer.Close();
                //}

            } while (tempInt != -1);

        }
        static void stReader(string file) 
        {
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                Console.WriteLine($"{reader.ReadLine()}");
            }
            reader.Close();
        }
    }
}
