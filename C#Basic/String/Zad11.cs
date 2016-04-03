using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad11
    {
        public static void NumberConventor(string number)
        {
            Console.WriteLine(string.Format("{0:D15}",int.Parse(number)));
            Console.WriteLine(string.Format("{0:X15}",int.Parse(number)));
            Console.WriteLine(string.Format("{0:P15}",(int.Parse(number)/100)));
            Console.WriteLine(string.Format("{0:E15}",int.Parse(number)));
        }
    }
}
