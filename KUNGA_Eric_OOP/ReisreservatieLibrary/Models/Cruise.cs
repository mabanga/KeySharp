using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReisreservatieLibrary.Models;

namespace ReisreservatieLibrary.Models
{
    public class Cruise:Reis
    {
        public const double CRUISEPRIJSEXTRADAGKOST = 10;
        public bool VIP { get { return false; } }
        public override double BerekenPrijs()
        {
            double price = 0;
            if (VIP==true)
            {
              price = AantalDagen * BASISDAGPRIJS*1.5;
            }
            else
            {
                price = AantalDagen * BASISDAGPRIJS;
            }
            return price;
        }
        public Cruise(DateTime vertrekdatum, DateTime terugkeerdatum)
        :base(vertrekdatum, terugkeerdatum)
        {
            //Console.WriteLine($"Vertrekdatum: {vertrekdatum}\nTerugkeerdatum: {terugkeerdatum}");
            //Console.WriteLine($"Aantaldagen: {AantalDagen}");
            //Console.WriteLine($"AantalPersonen: {aantalpersonen}");

        }
    }
}
