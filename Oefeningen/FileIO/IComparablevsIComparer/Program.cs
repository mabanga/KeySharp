using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablevsIComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List Sort Int
            //List<int> intList = new List<int>();
            //intList.Add(10);
            //intList.Add(36);
            //intList.Add(48);
            //intList.Add(95);
            //intList.Add(1025);
            //intList.Add(57);
            //intList.Add(1);

            //Console.WriteLine("Liste normale Int");
            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Sort List Int");
            //intList.Sort();
            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Reverse List Int");
            //intList.Reverse();
            //foreach (var item in intList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region List Sort String
            //List<string> strList = new List<string>();
            //strList.Add("10");
            //strList.Add("36");
            //strList.Add("48");
            //strList.Add("9");
            //strList.Add("10");
            //strList.Add("57");
            //strList.Add("1");

            //Console.WriteLine("Liste normale String");
            //foreach (var item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Sort List String");
            //strList.Sort();
            //foreach (var item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Reverse List String");
            //strList.Reverse();
            //foreach (var item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            //EmployeeVM objVM = new List<EmployeeComparar>();
            //List<Employee> employees = objVM.Employees;
            //List<Employee> employees = new List<E>();
            List<Employee> lstEmpl = new List<Employee>();
            {
                lstEmpl.Add(new Employee() { ID = 4, Name = "Modjaaa", Salary = 11000 });
                lstEmpl.Add(new Employee() { ID = 1, Name = "Zekiraa", Salary = 1100 });
                lstEmpl.Add(new Employee() { ID = 2, Name = "Mabanga", Salary = 1200 });
                lstEmpl.Add(new Employee() { ID = 3, Name = "Clerbeau", Salary = 2100 });
                lstEmpl.Add(new Employee() { ID = 5, Name = "Madigala", Salary = 510 });
            };
            lstEmpl.Sort();
            lstEmpl.Reverse();

            lstEmpl.ForEach(empl => Console.WriteLine(empl.ID + " " + empl.Name + "\t "+ empl.Salary ));
            Console.WriteLine("---");

            lstEmpl.Sort(new EmployeeComparar());
            lstEmpl.Reverse();

            lstEmpl.ForEach(empl => Console.WriteLine(empl.ID + " " + empl.Name + "\t " + empl.Salary));
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.ID + " " + item.Salary);
            //}
            Console.WriteLine("---");
            //EmployeeComparar objemcom = new EmployeeComparar();
            //employees.Sort(objemcom);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.ID + " " + item.Salary);
            //}
            Console.ReadKey();
        }
    }
}
