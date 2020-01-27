using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef7
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


            Console.WriteLine("Tapez le numéro de compte pour avoir le IBAN: ");
            string bban = Console.ReadLine();

            //Schrap alle niet-alfanumerieke tekens

            bban = bban.Replace("-", "");
            string bban1 = bban + "111400";


            long l_bban = long.Parse(bban1);

            //Modulo
            long modulo = l_bban % 97;

            //98-Modulo
            long sub_modulo = 98 - modulo;

            string iban = "BE" + sub_modulo + bban;
            Console.WriteLine("withoutSpace " +iban);

            Console.Write("WithSpace " + "BE" + sub_modulo + " ");

            Console.Write(bban[0]);
            Console.Write(bban[1]);
            Console.Write(bban[2]);
            Console.Write(bban[3]);
            Console.Write(" ");
            Console.Write(bban[4]);
            Console.Write(bban[5]);
            Console.Write(bban[6]);
            Console.Write(bban[7]);
            Console.Write(" ");
            Console.Write(bban[8]);
            Console.Write(bban[9]);
            Console.Write(bban[10]);
            Console.Write(bban[11]);





            Console.Read();
        }
    }
}
