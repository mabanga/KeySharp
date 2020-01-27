using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Rekening
    {
        private double _saldo;
        public string Rekeningnummer { get;}
        public double Saldo 
        {
            get { return _saldo; }
            set {
                if (_saldo < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
            } 
        }
        public DateTime Creatiedatum { get;}
        public void Afbeelden()
        {
            Console.WriteLine($"-Rekening: {Rekeningnummer} \n-Saldo: {Saldo} \n-Creatiedatum: {Creatiedatum}");
        }
        public double Storten(double saldo)
        {
            return Saldo += saldo;
        }
        public override string ToString()
        {
            return $"-Rekening: {Rekeningnummer} \n-Saldo: {Saldo} \n-Creatiedatum: {Creatiedatum}";
        }
        public Rekening(double saldo)
        {
            int l1 = 100000000;
            int l2 = 999999999;
            Random rnd = new Random();
            Rekeningnummer = rnd.Next(l1, l2).ToString();
            if (saldo < 0)
            {
                _saldo = 0;
            }
            else
            {
                _saldo = saldo;
            }
            Creatiedatum = DateTime.Now;
        }
    }
}
