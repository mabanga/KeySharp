using System;
using System.Collections.Generic;
using System.Linq;
using ReisreservatieLibrary.Models;
using System.Text;
using System.Threading.Tasks;

namespace Resireservatie
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            #region Persoon
            Persoon persoon4 = new Persoon("Voornaam4", "Familie4") {Adres = new Adres() { Gemeente = "aalst", Postcode = 9300, Huisnr = "62", straat = "ledebaan" } };
            Persoon persoon1 = new Persoon("Voornaam1", "Familie1") {Adres = new Adres() { Gemeente = "aalst", Postcode = 9300, Huisnr = "62", straat = "ledebaan" } };
            Persoon persoon2 = new Persoon("Voornaam2", "Familie2") {Adres = new Adres() { Gemeente = "aalst", Postcode = 9300, Huisnr = "62", straat = "ledebaan" } };
            Persoon persoon3 = new Persoon("Voornaam3", "Familie3") {Adres = new Adres() { Gemeente = "aalst", Postcode = 9300, Huisnr = "62", straat = "ledebaan" } };
            #endregion
            #region Reisbureau
            Reisbureau reisbureau1 = new Reisbureau("Bruxelles") { Adres=new Adres() { straat="bxlstraat", Gemeente="bxl", Huisnr="10", Postcode=1000} };
            Reisbureau reisbureau2 = new Reisbureau("Paris");
            Reisbureau reisbureau3 = new Reisbureau("Tokyo");
            Reisbureau reisbureau4 = new Reisbureau("London");
            #endregion
            #region Cruise
            Console.WriteLine("Cruise");
            Cruise persoon1cruise = new Cruise(new DateTime(2020, 1, 25, 9, 30, 00), new DateTime(2020, 11, 25, 21, 15, 30));
            Console.WriteLine($"Aantaldagen: {persoon1cruise.AantalDagen} - maal basisdagprijs = {persoon1cruise.BerekenPrijs()}");
            Cruise persoon2cruise = new Cruise(new DateTime(2020, 1, 17, 9, 30, 00), new DateTime(2020, 1, 25, 21, 15, 30));
            Console.WriteLine($"Aantaldagen: {persoon2cruise.AantalDagen} - maal basisdagprijs = {persoon2cruise.BerekenPrijs()}");
            Cruise persoon3cruise = new Cruise(new DateTime(2020, 2, 14, 9, 30, 00), new DateTime(2020, 3, 20, 21, 15, 30));
            Console.WriteLine($"Aantaldagen: {persoon3cruise.AantalDagen} - maal basisdagprijs = {persoon3cruise.BerekenPrijs()}");
            Cruise persoon4cruise = new Cruise(new DateTime(2020, 2, 14, 9, 30, 00), new DateTime(2020, 3, 20, 21, 15, 30));
            Console.WriteLine($"Aantaldagen: {persoon4cruise.AantalDagen} - maal basisdagprijs = {persoon4cruise.BerekenPrijs()}");
            Console.WriteLine(new string('-',10));
            #endregion
            #region Autovakantie
            Console.WriteLine("Autovakantie");

            Autovakantie person1autovakantie = new Autovakantie(persoon1cruise.VertrekkeerDatum, persoon1cruise.TerugkeerDatum);
            person1autovakantie.AaantalPersonen = 6;
            Console.WriteLine($"{person1autovakantie.AaantalPersonen}");
            Console.WriteLine(new string('-', 10));

            #endregion
            #region Reservatie
            Console.WriteLine("Reservatie");
            Reisreservatie resiperson1 = new Reisreservatie(persoon1, reisbureau1, persoon1cruise);
            Reisreservatie resiperson2 = new Reisreservatie(persoon2, reisbureau2, persoon2cruise);
            Reisreservatie resiperson3 = new Reisreservatie(persoon3, reisbureau3, persoon3cruise);
            Reisreservatie resiperson4 = new Reisreservatie(persoon4, reisbureau4, persoon4cruise);
            #endregion
            #region Vliegtuigvakantie
            Console.WriteLine("Vliegtuigvakantie");
            Vliegtuigvakantie persoon1ticket = new Vliegtuigvakantie(new DateTime(2020, 2, 2), new DateTime(2020, 5, 5), 250, 1);
            Console.WriteLine($"TicketPrijs: {persoon1ticket.VliegtuigticketPrijs} - {persoon1ticket.AantalDagen} - {persoon1ticket.AaantalPersonen}");
            Vliegtuigvakantie persoon2ticket = new Vliegtuigvakantie(new DateTime(2020, 2, 2), new DateTime(2020, 5, 5), 670, 8);
            Vliegtuigvakantie persoon3ticket = new Vliegtuigvakantie(new DateTime(2020, 2, 2), new DateTime(2020, 5, 5), 880, 14);
            Vliegtuigvakantie persoon4ticket = new Vliegtuigvakantie(new DateTime(2020, 2, 2), new DateTime(2020, 5, 5), 195, 2);
            #endregion
            #region Main Program
            Console.WriteLine($"{resiperson1.Persoon} heeft een reis van {persoon1cruise.AantalDagen} dagen geboekt bij {resiperson1.Reisbureau} en dat kost {persoon1ticket.AaantalPersonen * (persoon1cruise.BerekenPrijs()):c}.");
            Console.WriteLine($"{resiperson2.Persoon} heeft een reis van {persoon2cruise.AantalDagen} dagen geboekt bij {resiperson2.Reisbureau} en dat kost {persoon2ticket.AaantalPersonen * persoon2ticket.VliegtuigticketPrijs:C}.");
            Console.WriteLine($"{resiperson3.Persoon} heeft een reis van {persoon3cruise.AantalDagen} dagen geboekt bij {resiperson3.Reisbureau} en dat kost {persoon3ticket.AaantalPersonen * persoon3ticket.VliegtuigticketPrijs:C}.");
            Console.WriteLine($"{resiperson4.Persoon} heeft een reis van {persoon4cruise.AantalDagen} dagen geboekt bij {resiperson4.Reisbureau} en dat kost {persoon4ticket.AaantalPersonen * persoon4ticket.VliegtuigticketPrijs:C}.");


            Console.ReadKey();
            #endregion
        }
    }
}
