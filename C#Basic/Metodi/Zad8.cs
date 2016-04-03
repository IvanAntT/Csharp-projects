using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Metodi
{
    public class Zad8
    {
        public static BigInteger SumTwoInteger(int[] mass1,int[] mass2)
         {
             Array.Reverse(mass1, 0, mass1.Length);
             Array.Reverse(mass2, 0, mass2.Length);
             string firstNumberString = "";
             string secondNumberString = "";
             for (int i = 0; i < mass1.Length; i++)
             {
                 firstNumberString = firstNumberString + mass1[i];
             }
             for (int i = 0; i < mass2.Length; i++)
             {
                 secondNumberString = secondNumberString + mass2[i];
             }
             BigInteger result = BigInteger.Parse(firstNumberString) +
                                 BigInteger.Parse(secondNumberString);
             return result;

         }
    }
}
