using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studenst = new Dictionary<int, string>();
            studenst.Add(1, "Jan");
            studenst.Add(2, "Arek");
            studenst.Add(3, "Sadia");
            studenst.Add(4, "Joran");
            studenst.Add(5, "Steven");
            studenst.Add(6, "Anna");

            Dictionary<int, string> ecoliers = new Dictionary<int, string>();
            studenst.Add(7, "CM1");
            studenst.Add(8, "CM2");
            studenst.Add(9, "CM1");
            studenst.Add(10, "CM2");
            studenst.Add(11, "CM3");
            studenst.Add(12, "CM1");

            foreach (KeyValuePair<int, string> item in studenst)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(new string('-', 15));

            Console.WriteLine($"{studenst[1]}");

            Console.WriteLine(new string('-', 15));

            foreach (var group in studenst.GroupBy(p => p.Value))
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            Console.WriteLine(new string('-', 15));
            if (studenst.ContainsKey(3))
            {
                Console.WriteLine($"The value is: {studenst[3]}");
            }
            else
            {
                Console.WriteLine($"The item not found");
            }

            Console.ReadKey();
        }
    }
}
