using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablevsIComparer
{
    public class Employee:IComparable<Employee>
    {
        public int ID { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            //if (other.ID < this.ID)
            //{
            //    return 1;
            //}
            //else if (other.ID > this.ID)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"{ID} {Name} {Salary}";
        }
    }
}
