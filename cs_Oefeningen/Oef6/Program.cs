using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
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


            int i_celsius = 37;
            decimal d_fahrenheit = i_celsius * (9 / 5m) + 32;
            Console.WriteLine("37° Celsius fait " + d_fahrenheit + "° Fahrenheit");


            Console.ReadKey();
        }
    }
}
