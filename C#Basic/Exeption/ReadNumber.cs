using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    public class Read
    {
        public static void ReadNumberr(int startt,int endd)
        {
            int br = 0;
            while (br<10)
            {
                Console.Write("Vuvedete integer: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number < startt || number > endd)
                    {
                        throw new ArgumentException();
                    }
                    br++;
            }
        }
    }
}
