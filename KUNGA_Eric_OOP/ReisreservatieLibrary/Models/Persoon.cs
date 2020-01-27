using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get;}

        public override string ToString()
        {
            return $"{Voornaam} {Familienaam}";
        }

        public Persoon(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Naam = $"{Voornaam} {Familienaam}"; 
        }
    }
}
