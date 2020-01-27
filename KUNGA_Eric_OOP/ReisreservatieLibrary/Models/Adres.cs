namespace ReisreservatieLibrary.Models
{
    public class Adres
    {
        public string Gemeente { get; set; }
        public string Huisnr { get; set; }
        public string straat { get; set; }
        public int   Postcode { get; set; }
        public override string ToString()
        {
            return $"{straat} {Huisnr}\n{Postcode} {Gemeente}";
        }
        public Adres()
        {

        }

    }
}