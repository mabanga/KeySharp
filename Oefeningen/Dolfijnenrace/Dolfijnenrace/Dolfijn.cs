using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolfijnenrace
{
    public class Dolfijn
    {
        public int Afstand { get; set; }
        public int Luchtvoorraad { get; set; }
        public bool Dood { get; set; }

        public void Zwem()
        {
            Console.WriteLine($"Is aan het zwemmen");
        }
        public void PakLucht() {
            Console.WriteLine($"Is aan het pakluchten");
        }


    }
}
