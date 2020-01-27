using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 50, 30, 60 };
            string[] names = {"Peter","Marc","Francine"};

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine($"Name:{names[i]} Age:{names[i]}");
            }
        }
    }
}
