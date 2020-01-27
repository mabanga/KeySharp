using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public class LogMessage
    {
        private int indexer;

        public string Boodschap { get;}
        public int ID { get { return indexer++; } }
        public LogMessage()
        {
            
        }
        public int GenereerID()
        {
            indexer++;
            return indexer;
        }
    }
}
