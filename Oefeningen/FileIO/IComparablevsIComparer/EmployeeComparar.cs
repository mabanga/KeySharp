using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablevsIComparer
{
    public class EmployeeComparar : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            //if (x.Salary<y.Salary)
            //{
            //    return -1;
            //}
            //else if (x.Salary > y.Salary)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            return x.ID - y.ID;
        }
    }
}
