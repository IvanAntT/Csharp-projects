using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    public class zad13
    {
        const string FIRSTFILE = @"..\..\zad13\test.txt";
        const string SECONDFILE = @"..\..\zad13\words.txt";
        const string FINALFILE = @"..\..\zad13\result.txt";

        public static void start()
        {
            StreamReader readfile1 = new StreamReader(FIRSTFILE);
            StreamReader readfile2 = new StreamReader(SECONDFILE);
            List<string> masswithword = new List<string>();
            using (readfile2)
            {
                    string textwithwords = readfile2.ReadToEnd();
                    for (int i = 0; i < textwithwords.Length; i++)
                    {
                        string word = "";
                        while (textwithwords[i]!=' ')
                        {
                            word = word + textwithwords[i];
                            i++;
                            if (i==textwithwords.Length)
                            {
                                break;
                            }
                        }
                        masswithword.Add(word);
                    }
            }
            StreamWriter writefile=new StreamWriter(FINALFILE);
            using (readfile1)
            {
                using (writefile)
                {
                    string alltext=readfile1.ReadToEnd();
                    foreach (var word in masswithword)
                    {
                        int br = 0;
                        int index = alltext.IndexOf(word, 0);
                        while (index!=-1)
                        {
                            br++;
                            index = alltext.IndexOf(word, index + 1);
                        }
                        writefile.WriteLine("dumata {0} se sre6tna {1} puti", word, br);
                    }
                }
            }
            
        }
    }
}
