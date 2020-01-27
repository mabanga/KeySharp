using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public class Vliegtuigvakantie:Reis
    {
        private double _vliegtuigticketprijs;
        public double VliegtuigticketPrijs { get { return _vliegtuigticketprijs; } set {; } }
        public override double BerekenPrijs()
        {
            double price = 0;
            price = AaantalPersonen * VliegtuigticketPrijs;
            return price;

        }
        public Vliegtuigvakantie(DateTime vertrekdatum, DateTime terugkeerdatum, double vliegtuigticketprijs, int aantalpersonen)
        : base(vertrekdatum, terugkeerdatum)
        {
            AaantalPersonen = aantalpersonen;
            _vliegtuigticketprijs = vliegtuigticketprijs;
            double TotalPrice = _vliegtuigticketprijs * aantalpersonen;
        }
    }
}
