using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveReplace
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


            //Schrap alle niet-alfanumerieke tekens
            string s_bban = "063-1547563-60";
            string[] st_bban = s_bban.Split('-');
            for (int i = 0; i < st_bban.Length; i++)
            {
                Console.WriteLine(st_bban[i]);
            }




            Console.ReadKey();
        }
    }
}
