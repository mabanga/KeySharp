using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReisreservatieLibrary.Models;

namespace ReisreservatieLibrary.Models
{
    public class Autovakantie: Reis
    {
        public const double EXTRAPRIJSHUURAUTO = 10;
        //public int AantalPersonen { get; set; }
        public bool EigenWagen { get { return false; }}
        public override double BerekenPrijs()
        {
            double price = AantalDagen * BASISDAGPRIJS * 1.5;

            if (EigenWagen == true)
            {
                price += AantalDagen * EXTRAPRIJSHUURAUTO;
            }
            return price;
        }
        public Autovakantie(DateTime vertrekdatum, DateTime terugkeerdatum)
         : base(vertrekdatum, terugkeerdatum)
        {
            
            if (AaantalPersonen > 5)
            {
                Console.WriteLine($"Please, Rent a second auto");
            }

        }
    }
}
