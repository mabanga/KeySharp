using System;


namespace cs_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> sCWL = s => Console.WriteLine(s);
            Action<string> sCW = s => Console.Write(s);
            Action<string> sCRK = s => Console.ReadKey();
            Action<string> sCRL = s => Console.ReadLine();

            byte b_nombre = 15;
            int i_nombre = 15;
            uint u_nombre = 16;
            Int16 i_nombre16 = -32766;
            UInt16 u_nombre16 = 32500;
            Int32 i_nombre32 = -2589635;
            UInt32 u_nombre32 = 2589635;
            Int64 i_nombre64 = -45879885566;
            UInt64 u_nombre64 = 45879965822145;
            char c_nombre ='4';

            //UInt16 u16_age = 15;

            //sCWL("you are " + i_age.ToString());

            sCW("SIGNED\t\t\t\t\t\t\t");sCWL(" UNSIGNED");
            sCW("------\t\t\t\t\t\t\t"); sCWL(" --------");
            sCWL("MinValue byte: " + byte.MinValue.ToString());

            sCWL("MaxValue byte: " + byte.MaxValue.ToString());

            sCWL("MinValue sbyte: " + sbyte.MinValue.ToString());
            sCWL("MaxValue sbyte: " + sbyte.MaxValue.ToString());

            sCW("MinValue short: " + short.MinValue.ToString());
            sCW("\t\t\t\t\t ");
            sCWL("MinValue ushort: " + ushort.MinValue.ToString());
            sCW("MaxValue short: " + short.MaxValue.ToString());
            sCW("\t\t\t\t\t");
            sCWL(" MaxValue ushort: " + ushort.MaxValue.ToString());

            sCWL("MinValue char: " + Char.MinValue.ToString());
            sCWL("MaxValue char: " + Char.MaxValue.ToString());

            sCWL("MinValue decimal: " + decimal.MinValue.ToString());
            sCWL("MaxValue decimal: " + decimal.MaxValue.ToString());

            sCWL("MinValue double: " + double.MinValue.ToString());
            sCWL("MaxValue double: " + double.MaxValue.ToString());

            sCWL("MinValue float: " + float.MinValue.ToString());
            sCWL("MaxValue float: " + float.MaxValue.ToString());

            sCW("MinValue long: " + long.MinValue.ToString());
            sCW("\t\t\t "); 
            sCWL("MinValue ulong: " + ulong.MinValue.ToString());
            sCW("MaxValue long: " + long.MaxValue.ToString());
            sCW("\t\t\t "); 
            sCWL("MaxValue ulong: " + ulong.MaxValue.ToString());

            sCWL("MinValue int: " + int.MinValue.ToString());
            sCWL("MaxValue int: " + int.MaxValue.ToString());

            sCW("MinValue 16int: " + Int16.MinValue.ToString());
            sCW("\t\t\t\t\t "); 
            sCWL("MinValue 16uint: " + UInt16.MinValue.ToString());
            sCW("MaxValue 16int: " + Int16.MaxValue.ToString());
            sCW("\t\t\t\t\t "); 
            sCWL("MaxValue 16uint: " + UInt16.MaxValue.ToString());

            sCW("MinValue 32int: " + Int32.MinValue.ToString());
            sCW("\t\t\t\t ");
            sCWL("MinValue 32uint: " + UInt32.MinValue.ToString());
            sCW("MaxValue 32int: " + Int32.MaxValue.ToString());
            sCW("\t\t\t\t "); 
            sCWL("MaxValue 32uint: " + UInt32.MaxValue.ToString());

            sCW("MinValue 64int: " + Int64.MinValue.ToString());
            sCW("\t\t\t "); 
            sCWL("MinValue 64uint: " + UInt64.MinValue.ToString());
            sCW("MaxValue 64int: " + Int64.MaxValue.ToString());
            sCW("\t\t\t ");
            sCWL("MaxValue 64uint: " + UInt64.MaxValue.ToString());

            sCRK("quit");
        }
    }
}
