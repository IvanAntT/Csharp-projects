using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad6
    {
        public static string ReturnFinalString(string firststring)
        {
            StringBuilder finalstr = new StringBuilder();
            finalstr.Append(firststring);
            int lenght = firststring.Length;
            while (lenght<20)
            {
                finalstr.Append('*');
                lenght++;
            }
            return finalstr.ToString();
        }
    }
}
