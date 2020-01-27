using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> iInt = new List<int>();
            iInt.Add(5);
            iInt.Add(6);
            iInt.Add(7);
            Console.WriteLine(iInt.Count);
            Console.WriteLine(iInt[0]);
            Console.WriteLine(iInt[2]);



            Console.ReadKey();
        }
    }
}
