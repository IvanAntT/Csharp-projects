using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad9
    {
        public static int IndexOfTheMaxDigitFrom(int[] mass2, int positionToStart)
        {
            int positionOfmax = 0;
            int max=0;
            for (int i = positionToStart; i < mass2.Length; i++)
            {
                if (mass2[i]>max)
                {
                    max = mass2[i];
                    positionOfmax = i;
                }    
            }
            return positionOfmax;
        }

        public static int[] SortedArray(int[] mass)
        {
            int position = 0;
            int indexMax=0;
            while (position<mass.Length)
            {
               indexMax = IndexOfTheMaxDigitFrom(mass, position);
               int currentElement=mass[position];
               int maxElement=mass[indexMax];
               mass[position] = maxElement;
               mass[indexMax] = currentElement;
               position++;
            }
            return mass;
        }
    }
}
