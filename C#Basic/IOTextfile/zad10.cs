using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    public class zad10
    {
        const string FILE = @"..\..\zad10\file.txt";
        const string FFILE = @"..\..\zad10\ffile.txt";

        public static void start()
        {
            StreamReader read = new StreamReader(FILE);
            List<char> endmass=new List<char>();
            using (read)
            {
                string text = read.ReadToEnd();
                char[] mass = text.ToCharArray();
                bool intag = false;
                for (int i = 0; i < mass.Length-1; i++)
                {
                    if (mass[i]=='<')
                    {
                        intag = true;
                    }
                    if (mass[i]=='>')
                    {
                        intag = false;
                        continue;
                    }
                    if (intag==false)
                    {
                        endmass.Add(mass[i]);
                    }
                }
            }

            StreamWriter write = new StreamWriter(FFILE);
            using (write)
            {
                foreach (var item in endmass)
                {
                    write.Write(item);
                }
            }
        }
    }
}
