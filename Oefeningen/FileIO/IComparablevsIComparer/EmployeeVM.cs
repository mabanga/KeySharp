using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablevsIComparer
{
    public class EmployeeVM
    {
        public List<Employee> Employees;
        public EmployeeVM()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee() { ID = 4, Name = "Modja", Salary = 11000 });

            Employees.Add(new Employee() { ID = 1, Name = "Zekira", Salary = 1100 });
            Employees.Add(new Employee() { ID = 2, Name = "Mabanga", Salary = 1200 });
            Employees.Add(new Employee() { ID = 3, Name = "Clerbeau", Salary = 2100 });
            Employees.Add(new Employee() { ID = 5, Name = "Madigala", Salary = 510 });
        }
    }
}
