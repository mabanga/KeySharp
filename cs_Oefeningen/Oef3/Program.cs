using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Setting
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Title = "ZMCo - Getalen";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int width = 60;
            int height = 30;
            int left = width / 3;
            int top = height / 3;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(90, 30);
            Console.SetCursorPosition(left, top);


            //invoer getal
            Console.WriteLine("voer een cijfer in, aub");
            string s_getal=Console.ReadLine();
            int i_getal;
            Boolean boGetal = int.TryParse(s_getal, out i_getal);
            int i_derde = i_getal * i_getal * i_getal;
            int i_kwadraat = i_getal *= i_getal;


            //au carré

            Console.WriteLine("Het kwadraat is : ");
            Console.WriteLine(i_kwadraat);

            //3e
            
            Console.WriteLine("De derde macht is : ");
            Console.WriteLine(i_derde);


            Console.ReadKey();
        }
    }
}
