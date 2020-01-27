using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
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


            //Gegevens
            Console.Write("Volgende birthdate : ");
            dteBirthDate = Convert.ToDateTime(Console.ReadLine());
            //Oplossingen

            //Weergave
            Console.WriteLine(dteBirthDate);
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
