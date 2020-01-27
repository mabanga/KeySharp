using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public abstract class Reis
    {
        public const double BASISDAGPRIJS= 40.00;
        private int _aantaldagen;
        private int _aantalpersonen;
        private DateTime _terugkeerdatum;
        private DateTime _vertrekdatum;
        public int AantalDagen 
        { 
            get {
                _aantaldagen = _terugkeerdatum.Subtract(_vertrekdatum).Days;
                return _aantaldagen;
                }
        }
        public int AaantalPersonen { get { return _aantalpersonen; } set {; } }
        public DateTime TerugkeerDatum 
        { 
            get { return _terugkeerdatum; } 
            set {
                    if (_terugkeerdatum<=value)
                    {
                        Console.WriteLine($"De terugkeerdatum is niet mogelijk");
                    }
                    else
                    {
                        _terugkeerdatum = value;
                    }
                 } 
        }
        public DateTime VertrekkeerDatum { get { return _vertrekdatum; } set
            {
                if (_vertrekdatum < value)
                {
                    Console.WriteLine($"De Vertrekdatum is niet mogelijk");
                }
                else
                {
                    _terugkeerdatum = value;
                }
            } }
        public Reis(DateTime vertrekdatum, DateTime terugkeerdatum)
        {
            _vertrekdatum = vertrekdatum;
            _terugkeerdatum = terugkeerdatum;
            _aantalpersonen = AaantalPersonen;
        }
        public virtual double BerekenPrijs()
        {
            return AantalDagen* BASISDAGPRIJS;
        }
    }
}
