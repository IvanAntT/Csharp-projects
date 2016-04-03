using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class zad23
    {
        public static void RemoveRepeatedLetter()
        {
            Console.Write("Vuvedete duma: ");
            string word = Console.ReadLine();
            StringBuilder wor = new StringBuilder();
            wor.Append(word);
            char[] masswithletters = word.ToCharArray();
            int[] masswithcounters = new int[word.Length];

            for (int i = 0; i < word.Length; i++)  //mahane na povtarq6tite se simvoli
            {
                int count = 0;
                for (int j = 0; j < wor.Length; j++)
                {
                    if (word[i] == wor[j])
                    {
                        count++;
                        if (count > 1)
                        {
                            wor.Remove(j, 1);
                        }
                    }

                }
            }
            Console.WriteLine("Krainata duma e {0}",wor);
        }
    }
}
