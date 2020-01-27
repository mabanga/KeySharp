using System;


namespace cs_ConvertToType
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> sCRK = s => Console.ReadKey();
            Action<string> sCWL = s => Console.WriteLine(s);
            int i_getal = 500;
            byte b_getal = (byte)i_getal;
            byte bb_getal = Convert.ToByte(b_getal);
            //byte bbb_getal = Convert.ToByte(i_getal);

            sCWL("casting int into byte " + b_getal.ToString());
            sCWL("convert byte to byte " + bb_getal.ToString());
            //sCWL("convert int to byte " + bbb_getal.ToString());

            int b1 = 300;
            int b2 = 2;

            byte sum = checked((byte)(b1 + b2));
            sCWL("The sum is : " + sum);

            sCRK("quit");
            
        }
    }
}
