using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad14
    {
        public static void Dictionary(string word)
        {
            string[] dictionary =
            {".NET - platform for application from Microsoft",
             "CLR - managed execution environment for .NET",
             "namespace - hierarchical organization of classes"
            };

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].Contains(word+" -"))
                {
                    Console.WriteLine(dictionary[i]);
                }
            }
        }
    }
}
