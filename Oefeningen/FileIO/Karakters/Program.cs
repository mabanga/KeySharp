using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Karakters
{
    class Program
    {
        static string rootDir = @"c:\intec\data\";
        static string lottoFile = "CharAndRegels.txt";
        static string fullPath = $"{rootDir + lottoFile}";
        static void Main(string[] args)
        {

            Write(fullPath);
            FileInfo fileInfo = new FileInfo(fullPath);
            //fileInfo.
            Console.WriteLine($"Aantal Lijnen : {File.ReadAllLines(fullPath).Length}");
            File.ReadAllLines(fullPath);
            //Console.WriteLine($"The Length FileLines: {fileInfo.} lines");
            Console.WriteLine($"The Length FileContent: {fileInfo.Length} characters");
            //Console.WriteLine($"The Length FileName: {fullPath.Length} characters");
            Console.ReadKey();
        }
        static void Write(string path)
        {
            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);


            writer.WriteLine($"Je suis");
            writer.WriteLine($"{45}");
            writer.WriteLine($"{rootDir}");
            writer.WriteLine($"{fullPath}");

            writer.Flush();
            writer.Close();
        }
    }
}
