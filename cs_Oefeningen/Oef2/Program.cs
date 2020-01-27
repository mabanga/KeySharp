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


            //Invoer getal
            string s_vraagGetal = "voer een getal in, aub!";
            string S_vraagGetal = s_vraagGetal.ToUpper();
            Console.WriteLine(S_vraagGetal);
            string s_getal = Console.ReadLine();
            int i_getal;
            Boolean isGetal = int.TryParse(s_getal, out i_getal);

            //addition 15
            i_getal += 15;
            Console.WriteLine("We add 15");
            Console.WriteLine(i_getal);

            //multiplication 2
            i_getal *= 2;
            Console.WriteLine("We multiply by 2");
            Console.WriteLine(i_getal);

            //Soustraction 4
            i_getal -= 4;
            Console.WriteLine("We subtract by 2");
            Console.WriteLine(i_getal);

            //Division 2
            i_getal /= 2;
            Console.WriteLine("We divide by 2");
            Console.WriteLine(i_getal);


            Console.ReadKey();
        }
    }
}
