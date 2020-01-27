using System;
using System.IO;

namespace Binaries
{
    class Program
    {
        static string file = @"C:\tmp\binary.txt";

        static void Main(string[] args)
        {
            //binaryWriter(file);
            binaryReader(file);

            Console.ReadKey();
        }
        static void binaryWriter(string file) 
        {
            using(BinaryWriter writer =new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                writer.Write(202.50m);
                writer.Write(2.35);
                writer.Write(file);
                writer.Write($"I'm magnificient");
                writer.Write(true);
            }
        }
        static void binaryReader(string file) 
        {
            using(BinaryReader reader=new BinaryReader(File.Open(file,FileMode.Open)))
            {
                Console.WriteLine($"Decimal Value = {reader.ReadDecimal()}");
                Console.WriteLine($"Double Value = {reader.ReadDouble()}");
                Console.WriteLine($"{reader.ReadString()}");
                Console.WriteLine($"Magnificient Value = {reader.ReadString()}");
                Console.WriteLine($"True or False = {reader.ReadBoolean()}");
                //reader.Read(file);
            }
        }
    }
}
