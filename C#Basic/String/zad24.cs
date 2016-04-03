using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class zad24
    {
        public static void SortText()
        {
            string alltext = "";
            try
            {
                Console.WriteLine("Vuvedete spisuk s dumi");
                alltext = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Vuvedi dumata pravilno");
                return;
            }

            string[] masswithword = alltext.Split(' ');
            Array.Sort(masswithword);
            foreach (var word in masswithword)
            {
                Console.WriteLine(word);
            }
        }
    }
}
