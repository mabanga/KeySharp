using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            foreach (var item in people.GetPeople())
            {
                Console.WriteLine($"Name: {item.Name} - Age: {item.Age}");
            }
            
            Console.WriteLine(new string('-', people.GetPeople().Count()));

            IEnumerable<Person> p = people.GetPeople();
            foreach (var item in p)
            {
                Console.WriteLine($"Name: {item.Name} - Age: {item.Age}");
            }
            

            Console.ReadKey();
        }
    }
}
