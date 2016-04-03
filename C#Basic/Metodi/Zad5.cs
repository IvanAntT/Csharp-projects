using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad5
    {
        public static bool BiggerThanNeighbours(int[] mass,int number)
          {
              for (int i = 0; i < mass.Length ; i++)
			    {
                   
                    if (i==number-1)
                    {
                        if (mass[i] > mass[i + 1] && mass[i] > mass[i - 1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
			    }
              return false;
          }
    }
}
