using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Setting
            Console.Title = "ZM CO";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //Declaratie
            DateTime dteBirthDate;
            DateTime dteNow = DateTime.Now;

            //Uitleg
            Console.WriteLine("Aantal dagen tussen je volgende verjaardag en vandaag!!!");

            //Gegevens
            Console.Write("Typ uw volgende birthdate : ");
            dteBirthDate = Convert.ToDateTime(Console.ReadLine());

            //Oplossingen
            //int intDays = dteBrithdate.Substract(DateTime.Now).Day

            //Weergave
            Console.WriteLine("Uw volgende birthday is op {0}", dteBirthDate.ToShortDateString());
            Console.WriteLine("Het is vandaag {0}", dteNow.ToShortDateString());
            Console.WriteLine("Nog {0} dagen voor uw verjaardag!", dteBirthDate.Subtract(dteNow).Days);
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
