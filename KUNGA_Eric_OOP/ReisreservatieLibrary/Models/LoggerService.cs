using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisreservatieLibrary.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;
        static LogMessage[] Logs { get; set; }
        static void AddLogMessage()
        {

            //logs.Length = logs.Length + 1;
        }
    }
}
