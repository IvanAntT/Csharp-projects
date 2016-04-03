using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroiniSistemi
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal-500 ==> Binary-{0}",DecimalToBinary(500));
            Console.WriteLine();
            Console.WriteLine("Binary-110110 ==> Decimal-{0}",BinaryToDecimal("110110"));
            Console.WriteLine();
            Console.WriteLine("Decimal-500 ==> Hexadecimal-{0}",DecimalToHexadecimal(500));
            Console.WriteLine();
            Console.WriteLine("Hexadecimal-9786 ==> Decimal-{0}",HexadecimalToDecimal("9786"));
            Console.WriteLine();
            Console.WriteLine("Hexadecimal-3F2 ==> Binary-{0}", HexadecimalToBinary("3F2"));
            Console.WriteLine();
            Console.WriteLine("Binary-111100101001 ==> Hexadecimal-{0}", BinaryToHexadecimal("111100101001"));
            Console.WriteLine();
          //  start();
            LastТаsk.start();
           
        }

        public static void start()
        {
            string SourceSistem = NormalizationSourceDestination();
            string DestinationSistem = NormalizationSourceDestination();
            if (SourceSistem=="2")
            {
                string FirstNum=NumberBinary();
                if (DestinationSistem=="10")
                {
                    Console.WriteLine("From Bin({0}) to Dec({1})",FirstNum,BinaryToDecimal(FirstNum));
                }
                if (DestinationSistem == "16")
                {
                    Console.WriteLine("From Bin({0}) to Hex({1})", FirstNum, BinaryToHexadecimal(FirstNum));
                }
            }

            if (SourceSistem == "10")
            {
                int FirstNum = NumberDec();
                if (DestinationSistem == "2")
                {
                    Console.WriteLine("From Dec({0}) to Bin({1})", FirstNum, DecimalToBinary(FirstNum));
                }
                if (DestinationSistem == "16")
                {
                    Console.WriteLine("From Dec({0}) to Hex({1})", FirstNum, DecimalToHexadecimal(FirstNum));
                }
            }

            if (SourceSistem == "16")
            {
                string FirstNum = NumberHex();
                if (DestinationSistem == "2")
                {
                    Console.WriteLine("From Hex({0}) to Bin({1})", FirstNum, HexadecimalToBinary(FirstNum));
                }
                if (DestinationSistem == "10")
                {
                    Console.WriteLine("From Hex({0}) to Dec({1})", FirstNum, HexadecimalToDecimal(FirstNum));
                }
            }
        }

        public static string NormalizationSourceDestination()
        {
            while (true)
            {
                int normal = 0;
                Console.Write("Vuvedete S/D=");
                string number = Console.ReadLine();
                
                    if (int.Parse(number)!=2&&int.Parse(number)!=10&&int.Parse(number)==16)
                    {
                        Console.WriteLine("Nevalidna stoinost");
                        normal = 1;
                    }
                
                if (normal == 0) { return number; }
            }
        }

        public static string NumberBinary()
        {
            while (true)
            {
                int normal = 0;
                Console.Write("Molq vuvedete dvoui4no 4islo:");
                string Number =Console.ReadLine();
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] != '1' && Number[i] != '0')
                    {
                        Console.WriteLine("Nevalidna stoinost");
                        normal = 1;
                        break;
                    }
                }
                if (normal==0)
                {
                    return Number;
                }
            }
        }

        public static string NumberHex()
        {
            while (true)
            {
                int normal = 0;
                Console.Write("Vuvedete shesnaiseti4no 4islo: ");
                string Number = Console.ReadLine();
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] !='0' &&Number[i] != '1'&&Number[i] != '2'&&Number[i] != '3' && Number[i] != '4' &&
                        Number[i]!='5'&&Number[i]!='6'&&Number[i]!='7'&&Number[i]!='8'&&
                        Number[i]!='9'&&Number[i]!='A'&&Number[i]!='B'&&Number[i]!='C'&&
                        Number[i]!='D'&&Number[i]!='E'&&Number[i]!='F')
                    {
                        Console.WriteLine("Vuvedete validni stoinosti");
                        normal = 1;
                        break;
                    }
                }
                if (normal==0)
                {
                    return Number;
                }
            }
        }

        public static int NumberDec()
        {
            while (true)
            {
                int normal = 0;
                Console.Write("Vuvedete deseti4no 4islo: ");
                string Number = Console.ReadLine();
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] != '0'&&Number[i] != '1' && Number[i] != '2' && Number[i] != '3' 
                        && Number[i] != '4' && Number[i] != '5' && Number[i] != '6'
                        && Number[i] != '7' && Number[i] != '8' &&
                        Number[i] != '9')
                    {
                        Console.WriteLine("Vuvedete validni stoinosti");
                        normal = 1;
                        break;
                    }
                }
                if (normal == 0)
                {
                    return int.Parse(Number);
                }
            }
        }
        public static string DecimalToBinary(int Decimalnumber)
        {
            string binaryNumber = "";
            List<string> str = new List<string>();
            while (true)
            {
                str.Add((Decimalnumber % 2).ToString());
                Decimalnumber = Decimalnumber / 2;
                if (Decimalnumber==0)
                {
                    break;
                }
            }
            str.Reverse();
            for (int i = 0; i < str.Count; i++)
            {
                binaryNumber = binaryNumber + str[i];
            }
            return binaryNumber;
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            int stage = 0;
            int sum = 0;
            for (int i = binaryNumber.Length-1; i >= 0; i--)
            {
                sum = sum + int.Parse(binaryNumber[stage].ToString()) * Pow(2, i);
                stage++;
            }
            return sum;
        }

        public static int Pow(int number,int state)
        {
            int curNumber = number;
            if (state==0)
            {
                return 1;
            }
            for (int i = 1; i < state; i++)
            {
                number = curNumber * number;
            }
            return number;
        }

        public static string DecimalToHexadecimal(int decimalNumber)
        {
            string hexadecimal = "";
            List<string> str = new List<string>();
            while (true)
            {
                str.Add((decimalNumber % 16).ToString());
                decimalNumber = decimalNumber / 16;
                if (decimalNumber == 0)
                {
                    break;
                }
            }
            str.Reverse();
            for (int i = 0; i < str.Count; i++)
            {
                switch (str[i])
                {
                    case "10": str[i] = "A";break;
                    case "11": str[i] = "B"; break;
                    case "12": str[i] = "C"; break;
                    case "13": str[i] = "D"; break;
                    case "14": str[i] = "E"; break;
                    case "15": str[i] = "F"; break;
                    default:
                        break;
                }
                hexadecimal = hexadecimal+str[i];
            }
            return hexadecimal;
        }

        public static int HexadecimalToDecimal(string Hexadecimal)
        {
            List<string> NormalizeNumber = new List<string>();
            for (int i = 0; i < Hexadecimal.Length; i++)
            {
                if (Hexadecimal[i] == 'A') { NormalizeNumber.Add("10"); }
                else if (Hexadecimal[i] == 'B') { NormalizeNumber.Add("11"); }
                else if (Hexadecimal[i] == 'C') { NormalizeNumber.Add("12"); }
                else if (Hexadecimal[i] == 'D') { NormalizeNumber.Add("13"); }
                else if (Hexadecimal[i] == 'E') { NormalizeNumber.Add("14"); }
                else if (Hexadecimal[i] == 'F') { NormalizeNumber.Add("15"); }
                else { NormalizeNumber.Add(Hexadecimal[i].ToString());}
            }

            int state = NormalizeNumber.Count-1;
            int sum = 0;
            for (int i = 0; i < NormalizeNumber.Count; i++)
            {
                sum = sum + int.Parse(NormalizeNumber[i]) * Pow(16, state);
                state--;
            }
            return sum;
        }

        public static string HexadecimalToBinary(string Hexadecimal)
        {
            List<int> NormalizeHexadec = new List<int>();
            for (int i = 0; i < Hexadecimal.Length; i++)
            {
                NormalizeHexadec.Add(NormalizationHexadecimal("0X" + Hexadecimal[i].ToString()));
            }
            string result = "";

            for (int i = 0; i < NormalizeHexadec.Count; i++)
            {
                result = result + Convert.ToString(NormalizeHexadec[i], 2).PadLeft(4,'0');
            }
            return result;
        }

        public static int NormalizationHexadecimal(string hex)
        {
            if (hex[2] == 'A') { return 10; }
            if (hex[2] == 'B') { return 11; }
            if (hex[2] == 'C') { return 12; }
            if (hex[2] == 'D') { return 13; }
            if (hex[2] == 'E') { return 14; }
            if (hex[2] == 'F') { return 15; }
            else { return int.Parse(hex[2].ToString());}
        }

        public static string BinaryToHexadecimal(string binary)
        {
            string Hexadecimal = "";
            int br = 0;
            while (br<binary.Length)
            {
                string curNum = "";
                for (int j = 0; j < 4; j++)
                {
                    curNum = curNum + binary[br];
                    br++;
                }
                Hexadecimal = Hexadecimal + DecimalToHexadecimal(Convert.ToInt32(curNum, 2));
              
            }
            return Hexadecimal;
        }
    }
}
