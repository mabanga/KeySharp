using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
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
            int intGetal, index;
            string strGetal;
            int[] tblGetal;
            List<string> Cartes = new List<string>();
            //int[] Cartes;



            //Uitleg
            Console.WriteLine("De som van alle ingegeven data");
            Console.Write("Typ uw cijfer : ");
            strGetal = Console.ReadLine();
            index = 0;

            for (int i = 0; i < Cartes.Count; i++)
            {
                Cartes.Add(strGetal);
                Console.WriteLine(Cartes[0]);
                Console.WriteLine(strGetal);
            }

            //Gegevens
            //while (intGetal!=0)
            //{
            //    Console.Write("Typ uw cijfer : ");
            //    strGetal = Console.ReadLine();
            //    Cartes.Add(strGetal);
            //}



            //Console.WriteLine((Cartes.Count)/2);
            Console.WriteLine();
            //for (int i = 0; i < (Cartes.Count); i++)
            //{


            //    Console.WriteLine(Cartes[i]);

            //}


            //Console.WriteLine(Cartes[0]);
            //Console.WriteLine(Cartes[1]);
            //Console.WriteLine(Cartes[2]);


            Console.WriteLine();
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
