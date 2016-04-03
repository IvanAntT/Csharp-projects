using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class Zad5
    {
        const string FILEPATH = @"../../zad5.txt";
        const string OPENTAG = "<upcase>";
        const string CLOSETAG = "</upcase>";
        public static string FinalText()
        {
            string text = "";
            StreamReader file = new StreamReader(FILEPATH);
            using (file)
            {
                string alltext = file.ReadToEnd();
                int indexbegin = alltext.IndexOf(OPENTAG, 0);
                int indexend = alltext.IndexOf(CLOSETAG, 0);
                char[] alltextpresentwithchars = alltext.ToCharArray();
                StringBuilder atext = new StringBuilder();
                atext.Append(alltext);
                
                while (indexbegin>-1)
                {
                    int index = indexbegin + 8;
                    string wordtoup=alltext.Substring(index, indexend - index);
                    atext = atext.Replace(wordtoup, wordtoup.ToUpper());
                    indexbegin = alltext.IndexOf(OPENTAG, indexbegin+1);
                    indexend = alltext.IndexOf(CLOSETAG, indexend+1);
                }
                atext = atext.Replace(OPENTAG, "");
                atext = atext.Replace(CLOSETAG, "");
                text = atext.ToString();
            }
            return text;
        }
    }
}
