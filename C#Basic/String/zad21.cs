using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class zad21
    {
        public static void CountLetters()
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
                    if (word[i]==wor[j])
                    {
                        count++;
                        if (count > 1)
                        {
                            wor.Remove(j, 1);
                        }
                    }
                   
                }
            }

            for (int i = 0; i < wor.Length; i++)
            {
                int br = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (wor[i]==word[j])
                    {
                        br++;
                    }
                }
                Console.WriteLine("Bukvata {0} se sre6ta {1} puti",wor[i],br);
            }
        }
    }
}
