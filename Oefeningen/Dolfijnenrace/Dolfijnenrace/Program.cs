using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolfijnenrace
{
    class Program
    {
        public Random rndZwemmen = new Random();//10 en 35
        public Random rndLucht = new Random();//5 en 35

        public Random rndAdemHalen = new Random();//15 en 45

        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen?\n 1. Dolfijn laten zwemmen\n 2. Dolfijn laten adem happen");
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
