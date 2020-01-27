using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Serialization.Models;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization
{
    class Program
    {
        static string file = @"C:\tmp\serialization.txt";

        static void Main(string[] args)
        {
            stWriter(file);
            stReader(file);
            Console.ReadKey();
        }
        static void stWriter(string file)
        {
            Student student = new Student()
            {
                Id = 1,
                Address = "Rouppe 16",
                FirstName = "Eric",
                LastName = "Kunga"
            };
            Student student2 = new Student()
            {
                Id = 2,
                Address = "Rouppe 16",
                FirstName = "Jan",
                LastName = "Martens"
            };

            Student[] studentArray = new Student[2];
            studentArray[0] = student;
            studentArray[1] = student2;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;
            stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < studentArray.Length; i++)
            {
                formatter.Serialize(stream, studentArray[i]);
            }

            stream.Close();
        }
        static void stReader(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;
            stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            Student student = (Student)formatter.Deserialize(stream);
            Console.WriteLine($"{student.Id}");
            Console.WriteLine($"{student.FirstName}");
            Console.WriteLine($"{student.LastName}");
        }
    }
}
