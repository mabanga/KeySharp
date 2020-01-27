using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening = new Rekening(-5);
            Rekening ericrekening = new Rekening(0);
            rekening.Afbeelden();
            rekening.Storten(100);
            rekening.Afbeelden();
            Console.WriteLine(new string('-',15));

            ericrekening.Afbeelden();
            ericrekening.Storten(5000);
            ericrekening.Afbeelden();
            Console.ReadKey();
        }
    }
}
