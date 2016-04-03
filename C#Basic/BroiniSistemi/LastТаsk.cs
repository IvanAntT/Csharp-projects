using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroiniSistemi
{
    public static class LastТаsk
    {
        public static void start()
        {
            while (true)
            {
                Console.Write("Vuvedete 4islo SHORT= ");
                short number;
                if (short.TryParse(Console.ReadLine(), out number))
                {
                    Check(number);
                    break;
                }
            }
        }

        public static void Check(short number)
        {
            string num = number.ToString();
            string rez="";
            if (num[0] == '-')
            {
                rez = "1";
                rez = rez + Program.DecimalToBinary(short.MaxValue+1 + number);
                Console.WriteLine(rez.PadLeft(16,'0'));
            }
            else
            {
                rez = "0";
                rez = rez + Program.DecimalToBinary(number);
                Console.WriteLine(rez.PadLeft(16, '0'));
            }

        }
    }
}
