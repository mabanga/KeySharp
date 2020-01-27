using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2._2
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
            int intGetal;
            string strGetal;
            //int[] tblGetal;
            List<string> Cartes = new List<string>();

            //Uitleg
            Console.WriteLine("De som van alle ingegeven data");
            Console.Write("Typ uw cijfer : ");
            strGetal = Console.ReadLine();

            while (int.TryParse(strGetal, out intGetal))
            {
                Cartes.Add(strGetal);
                Console.Write("Typ uw cijfer : ");
                strGetal = Console.ReadLine();
            }
            int intSom=0;
            for (int i = 0; i < Cartes.Count; i++)
            {
                Console.Write(Convert.ToInt32(Cartes[i]) + "  ");
                intSom += Convert.ToInt32(Cartes[i]);

                //Console.WriteLine(Convert.ToInt32(Cartes[i])+ Convert.ToInt32(Cartes[i]));
            }

            Console.WriteLine();


            Console.WriteLine(intSom);


            Console.WriteLine();
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
