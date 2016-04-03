using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class zad22
    {
        public static void WordCounter()
        {

            string notrepeat = "";
            string alltext = "";
            Console.WriteLine("Vuvedete tekstut:");
            try
            {
                alltext = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Vuvedete pravilen teksta");
                return;
            }
            string[] masswithwords;
            masswithwords = alltext.Split(' ');
            for (int i = 0; i < masswithwords.Length; i++)
            {
                
            }

            foreach (var word in masswithwords)
            {
                string searchword = word.Trim(',','.','!','?');
                if (notrepeat.Contains(searchword))
                {
                    continue;
                }
                notrepeat = notrepeat + searchword;
                int br = 0;
                int index = alltext.IndexOf(searchword, 0);
                
                while (index>-1)
                {
                    br++;
                    index = alltext.IndexOf(searchword, index + 1);
                }
                Console.WriteLine("Dumata {0} se sre6ta {1} puti", searchword, br);
            }
        }
    }
}
