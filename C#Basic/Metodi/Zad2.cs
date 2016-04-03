using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad2
    {
        public static int GetMax(int firstnum, int secondnum)
        {
            int max = firstnum;
            if (secondnum>firstnum)
            {
                max = secondnum;
            }
            return max;
        }
    }
}
