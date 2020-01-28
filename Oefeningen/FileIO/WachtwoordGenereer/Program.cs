using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WachtwoordGenereer
{
    class Program
    {
        static void Main(string[] args)
        {
            string familieNaam = "kunga";
            string zoneNummer = "032";
            string postCode = "9300";
            string naam = familieNaam.Substring(1,1).ToUpper() + familieNaam.Substring(0, 1).ToLower();
            string zone = zoneNummer.Substring(0, 1);
            string post = postCode.Substring(0, 1);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{naam}{zone}{post}{Math.Pow(int.Parse(post), 2).ToString()}");
            Console.WriteLine($"Het wachwoord is : {sb}");


            Console.ReadKey();
        }
    }
}
