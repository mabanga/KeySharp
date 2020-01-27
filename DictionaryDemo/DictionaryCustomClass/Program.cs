using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> keyValuePairs = new Dictionary<int, Employee>();

            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "Eric";
            e1.Salary = 1100.00;

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.Name = "Zekira";
            e2.Salary = 3500.50;

            Employee e3 = new Employee();
            e3.ID = 3;
            e3.Name = "Mabanga";
            e3.Salary = 1500.90;

            Employee e4 = new Employee();
            e4.ID = 4;
            e4.Name = "Swap";
            e4.Salary = 500.05;


            Employee e5 = new Employee();
            e5.ID = 5;
            e5.Name = "Test";
            e5.Salary = 500.25;

            keyValuePairs.Add(e1.ID, e1);
            keyValuePairs.Add(e2.ID, e2);
            keyValuePairs.Add(e3.ID, e3);
            keyValuePairs.Add(e4.ID, e4);


            //keyValuePairs.Add(e5.ID, e5);
            if (!keyValuePairs.ContainsKey(5))
            {
                keyValuePairs.Add(e5.ID, e5);
                Console.WriteLine($"Record toegevoegd. {keyValuePairs[5]}");

            }
            else
            {
                Console.WriteLine($"The record exists.");
            }
            Employee emp = keyValuePairs[3];
            Console.WriteLine($"{emp}");

            Console.WriteLine($"{keyValuePairs[4]}");

            foreach (KeyValuePair<int, Employee> kvp in keyValuePairs)
            {
                Console.WriteLine($"Key: {kvp.Key}");
                Console.WriteLine($"Value: {kvp.Value.Name} - {kvp.Value.Salary}");
            }


            Console.ReadKey();
        }
    }
}
