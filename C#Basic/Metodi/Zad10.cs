using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Metodi
{
    public class Zad10
    {
        public static BigInteger Faktoriel(int number)
        {
            BigInteger finalSum = 1;
            for (int i = 1; i <=number ; i++)
            {
                finalSum = finalSum * i;
            }
            return finalSum;
        }
    }
}
