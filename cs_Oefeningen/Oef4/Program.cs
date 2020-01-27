using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef4
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
            Console.WriteLine("voer het eerste cijfer in, aub");
            string s_getal1 = Console.ReadLine();
            int i_getal1;
            Console.WriteLine("voer het tweede cijfer in, aub");
            string s_getal2 = Console.ReadLine();
            int i_getal2;
            Boolean boGetal1 = int.TryParse(s_getal1, out i_getal1);
            Boolean boGetal2 = int.TryParse(s_getal2, out i_getal2);

            int i_add = i_getal1 + i_getal2;
            int i_sub = i_getal1 - i_getal2;
            int i_mul = i_getal1 * i_getal2;
            int i_div = i_getal1 / i_getal2;

            Console.WriteLine($"De add van {i_getal1} and {i_getal2} is : ");
            Console.WriteLine(i_add);

            Console.WriteLine($"De sub van {i_getal1} and {i_getal2} is : ");
            Console.WriteLine(i_sub);

            Console.WriteLine($"De mult van {i_getal1} and {i_getal2} is : ");
            Console.WriteLine(i_mul);

            Console.WriteLine($"De div van {i_getal1} and {i_getal2} is : ");
            Console.WriteLine(i_div);


            Console.ReadKey();
        }

    }
}
