using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad6
    {
        public static int IndexOfTheFirstDigitBiggerThanNeighbour(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (Zad5.BiggerThanNeighbours(mass, i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
