using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {

            string un = "Pseduo";
            //string deux = "zekira";
            string un1 = "pierr";

            int x = String.Compare(un1, un);

            if (x <0)
            {
                Console.WriteLine($"{un} - {un1}");
            }
            else if (x==0)
            {
                Console.WriteLine($"{un}");
            }
            else
            {
                Console.WriteLine($"{un1 } - {un }");
            }

            //Console.WriteLine(String.Compare(un1, un));

            Console.ReadKey();
        }
    }
}
