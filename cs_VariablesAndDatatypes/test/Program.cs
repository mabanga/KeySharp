using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            string s_title = Console.Title = "ZM Co";


            Action<string> sCWL = s => Console.WriteLine(s);
            Action<string> sCRK = s => Console.ReadKey();


            Console.WriteLine("Default Title: " + s_title);




            int origWidth, width;
            int origHeight, height;
            string m1 = "The current window width is {0}, and the " +
                        "current window height is {1}.";
            string m2 = "The new window width is {0}, and the new " +
                        "window height is {1}.";
            string m4 = "  (Press any key to continue...)";

            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Console.WriteLine(m1, Console.WindowWidth,
                                  Console.WindowHeight);

            width = origWidth / 2;
            height = origHeight / 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine(m2, Console.WindowWidth,
                                  Console.WindowHeight);


            //Attente d'une touche pour quitter
            sCRK("quit");
        }
    }
}
