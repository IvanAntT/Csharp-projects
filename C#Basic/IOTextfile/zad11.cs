using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    public class zad11
    {
        const string FILE = @"..\..\zad11\file.txt";
        const string FFILE = @"..\..\zad11\ffile.txt";
        const string searchword = "test";
        public static void start()
        {
            StreamReader read = new StreamReader(FILE);
            char[] mass;
            using (read)
            {
                string text = read.ReadToEnd();
                mass = text.ToCharArray();
                for (int i = 0; i < mass.Length; i++)
                {

                    if (i == text.IndexOf(searchword, i))
                    {
                        while (mass[i]!=' ')
                        {
                            mass[i]=' ';
                            i++;
                            if (i==mass.Length)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            StreamWriter write = new StreamWriter(FFILE);
            using (write)
            {
                foreach (var item in mass)
                {
                    write.Write(item);
                }
            }
        }
        
    }
}
