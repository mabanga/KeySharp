using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_Leeftijd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Setting
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Title = "ZMCo - Leeftijd";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int width = 60;
            int height = 10;
            int left = width / 3;
            int top = height / 3;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(90, 30);
            Console.SetCursorPosition(left, top);
            //Name
            string yourname = "your name, pls.";
            string yourName = yourname.ToUpper();
            Console.WriteLine(yourName);
            string s_name = Console.ReadLine();
            string S_name = s_name.ToUpper();

            //BirthYear
            Console.Clear();
            Console.SetCursorPosition(left, top);
            string s_birthyear = "your birth year, pls";
            string S_birthYear = s_birthyear.ToUpper();
            Console.WriteLine(S_birthYear);
            string s_birthYear = Console.ReadLine();


            //Now
            int i_NowYear = DateTime.Now.Year;

            //Calculate age
            int i_birthYear;
            int.TryParse(s_birthYear, out i_birthYear);

            int age;
            age = i_NowYear - i_birthYear;
            //
            //show Message
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"Bonjour, {S_name}.");
            Console.SetCursorPosition(left-15, top+2);
            Console.WriteLine($"Vous avez aujourd'hui {age} année(s) sur terre. ");





            Console.ReadKey();
        }
    }
}
