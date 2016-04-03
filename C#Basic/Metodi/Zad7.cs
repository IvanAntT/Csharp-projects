using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad7
    {
        public static int ConvertNumber(int number)
        {
            string num = number.ToString();
            string convertedNumberString = "";
            string[] mass = new string[num.Length];
            int br = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                mass[br] = num[i].ToString();
                convertedNumberString = convertedNumberString + mass[br];
                br++;
            }
            int convertedNumberInteger = int.Parse(convertedNumberString);
            return convertedNumberInteger;
        }
    }
}
