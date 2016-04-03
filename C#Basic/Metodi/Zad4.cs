using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public static class Zad4
    {
        public static int HowManyTimeAppearDigit(int[] mass, int searchNumber)
        {
            int br = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]==searchNumber)
                {
                    br++;
                }
            }
            return br;
        }
    }
}
