using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class Zad15
    {
        public static void TextConventor()
        {
            const string INPUTFILEPATH = @"..\..\zad15.txt";
            const string OUTPUTFILEPATH = @"..\..\finalzad15.txt";
            StreamReader infile = new StreamReader(INPUTFILEPATH);
            StreamWriter outfile = new StreamWriter(OUTPUTFILEPATH);
            using (infile)
            {
                using (outfile)
                {
                    StringBuilder alltext = new StringBuilder();
                    string alltexts = infile.ReadToEnd();
                    alltexts=alltexts.Replace("\"","");
                    alltext.Append(alltexts);
                    
                    int indexofhref = alltexts.IndexOf("<a href", 0);
                    int indexofA = alltexts.IndexOf("</a",0)+3;
                    while (indexofhref>-1)
                    {
                        for (int i = indexofhref; i <= indexofA+1; i++)
                        {
                            if (alltext[i]=='<')
                            {
                                alltext[i] = '[';
                            }
                            if (alltext[i] == '>')
                            {
                                alltext[i] = ']';
                            }
                        }
                        indexofhref = alltexts.IndexOf("<a href", indexofhref+1);
                        indexofA = alltexts.IndexOf("</a",indexofA) + 3;
                    }
                    alltext = alltext.Replace("a href", "URL");
                    alltext = alltext.Replace("/a]", "/URL]");
                    
                    outfile.Write(alltext);
                }
            }
        }
    }
}
