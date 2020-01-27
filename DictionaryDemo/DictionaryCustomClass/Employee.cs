using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCustomClass
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"Id: {ID} - Name: {Name} - Salary: {Salary}";
        }
    }
}
