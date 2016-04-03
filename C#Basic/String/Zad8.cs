using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class Zad8
    {
        const string FILEPATH = @"../../zad8.txt";
        const string SEARCHWORD = " in ";
        public static string Sentenceswithsomestring()
        {
            StreamReader file = new StreamReader(FILEPATH);
            string final = "";
            using (file)
            {
                StringBuilder allsentences = new StringBuilder();
                string alltext = file.ReadToEnd();
                int indexdot = alltext.IndexOf(".", 0);
                int lenght = 0;
                while (indexdot>0)
                {
                    string sentences = alltext.Substring(lenght, indexdot+1-lenght);
                    if (sentences.Contains(SEARCHWORD))
                    {
                        sentences = sentences.Replace("\r\n", " ");
                        sentences = sentences.Trim();
                        allsentences.Append(sentences);
                        allsentences.Append("\n");
                    }
                    lenght = indexdot+1;
                    indexdot=alltext.IndexOf(".", indexdot+1);
                }
                final = allsentences.ToString();
            }
            return final;
        }
    }
}
