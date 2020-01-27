using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 getallen

            int a;
            int b;
            
            string s_input;
            string s_input2;


            Console.WriteLine("first Number");
            s_input = Console.ReadLine();
            while (int.TryParse(s_input, out a) == false)
            {
                Console.WriteLine("Oops!! Een cijfer, aub.");
                s_input = Console.ReadLine();

            }

            Console.WriteLine("Second Number");
            s_input2 = Console.ReadLine();
            while (int.TryParse(s_input2, out b) == false)
            {
                Console.WriteLine("Oops!! Een cijfer, aub.");
                s_input2 = Console.ReadLine();

            }


            Console.WriteLine("Het resultaat a+b is: " + (a + b));
            Console.WriteLine("Ordre croissant: " + Math.Min(a,b) + ";" + Math.Max(a,b) );


            Console.WriteLine("echt volgorde");
            if (a<b)
            {
                Console.WriteLine("{0}, {1}", a,b);
            }
            else
            {
                Console.WriteLine("{1}, {0}", b, a);

            }
            Console.ReadKey();
        }
    }
}
