using ReisreservatieLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public class Reisreservatie:ILoggable
    {
        public Persoon Persoon { get; set; }
        public LogMessage LogMessage { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }

        public override string ToString()
        {
            return $"{Persoon} {Reisbureau}"; 
        }
        static void AddLogMessage()
        {

        }
        public Reisreservatie(Persoon persoon, Reisbureau reisbureau, Reis reis)
        {
            Persoon = persoon;
            Reisbureau = reisbureau;

        }


    }
}
