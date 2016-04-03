using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class Zad4
    {
        const string FILEPATH = "../../stringzad4.txt";
        public static int NumOfFindStr(string wordtofind)
        {
            StreamReader file = new StreamReader(FILEPATH);
            using (file)
            {
                string alltext = file.ReadToEnd();
                int numfindword = 0;
                int index = alltext.IndexOf(wordtofind, 0, StringComparison.CurrentCultureIgnoreCase);
                while (index > 0)
                {
                    numfindword++;
                    index = alltext.IndexOf(wordtofind, index + 1, StringComparison.CurrentCultureIgnoreCase);
                }
                return numfindword;
            }
        }
    }
}
