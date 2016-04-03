using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class Zad9
    {
        const string FILEPATH = @"../../zad9.txt";
        public static string FinalText(List<string> forbiddenword)
        {
            StreamReader file = new StreamReader(FILEPATH);
            string final = "";
            using (file)
            {
                string alltext = file.ReadToEnd();
                foreach (var word in forbiddenword)
                {
                    alltext = alltext.Replace(word, new string('*', word.Length));
                }
                final = alltext;
            }
            return final;
        }
    }
}
