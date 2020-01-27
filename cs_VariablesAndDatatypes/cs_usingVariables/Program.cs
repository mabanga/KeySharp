using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_usingVariables
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
            //Declaration d'amour
            string s_prenom;
            string s_nomFamille;
            string s_birthYear;
            int i_year;
            int i_birthYear;


            //Demande Prénom
            sCWL("Prénom: ");
            s_prenom = Console.ReadLine();

            //Demande Nom de Famille
            sCWL("Nom de famille: ");
            s_nomFamille = Console.ReadLine();

            //Demande d'année de naissance
            sCWL("Année de naissance: ");
            s_birthYear = Console.ReadLine();
            i_birthYear = int.Parse(s_birthYear);
            i_year = DateTime.Now.Year;


            //Calcul l'age
            int i_old = i_year - i_birthYear;

            string s_nom = s_prenom + " - " + s_nomFamille;

            string s_personne = "Vous etes bien " + s_nom + ", agé de " + i_old + " année(s).";
            sCWL(s_personne);


            //Char Datatype
            char c_c = 'a';

            sCWL(c_c.ToString());

            sCWL("Tapez votre age et vous le recevez en CHAR: ");
            int i_age = Console.Read();
            char theAge = (char)i_age;
            sCWL(theAge.ToString());

            //Décimal Datatype
            #region Floatingpoint numberrs
            decimal d = 10.5m;
            double dd = 10.15;
            double ddd = 10.24d;
            float f = 0.12f;
            #endregion

            sCWL($" decimal => {d} \n double => {dd} \n double => {ddd} \n float => {f}");

            //var

            var a = 'f';
            var b = "ZM Co";
            var c = 36.67d;
            var e = false;
            var g = 54544;

            sCWL("Type of 'a' est : '" + a + "' " + a.GetType());
            sCWL("Type of 'b' est : '" + b + "' " + b.GetType());
            sCWL("Type of 'c' est : '" + c + "' " + c.GetType());
            sCWL("Type of 'e' est : '" + e + "' " + e.GetType());
            sCWL("Type of 'g' est : '" + g + "' " + g.GetType());


            //Attente d'une touche pour quitter
            sCRK("quit");


        }
    }
}
