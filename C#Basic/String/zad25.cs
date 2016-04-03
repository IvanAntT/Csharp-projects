using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class zad25
    {
        const string FILEPATH = "../../zad25.txt";
        public static void ExtractFromText()
        {
            StreamReader file = new StreamReader(FILEPATH);
            using (file)
            {
                string alltext = file.ReadToEnd();
                //string title = "";
                StringBuilder title = new StringBuilder();
                StringBuilder body = new StringBuilder();
                int beginoftitle = alltext.IndexOf("<title>", 0)+7;
                int endoftitle = alltext.IndexOf("</title>", 0);
                for (int i = beginoftitle; i < endoftitle; i++)
                {
                    title.Append(alltext[i]);
                }
                Console.WriteLine(title.ToString());
                Console.WriteLine();
                int beginofbody = alltext.IndexOf("<body>")+6;
                int endofbody = alltext.IndexOf("</body>");
                bool inside = false;
                for (int i = beginofbody; i < endofbody; i++)
                {
                    if (alltext[i]=='<')
                    {
                        inside = true;
                        continue;
                    }
                    if (alltext[i]=='>')
                    {
                        inside = false;
                        body.Append(" ");
                        continue;
                    }
                    if (inside==false)
                    {
                        body.Append(alltext[i]);
                    }
                }
                Console.WriteLine(body.ToString());
            }
        }
    }
}
