using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
   public class Zad6
    {
        const string INPUTFILE = @"..\..\zad6\inputfile.txt";
        const string OUTPUTFILE = @"..\..\zad6\outputfile.txt";

        public static void start()
        {
            StreamReader read = new StreamReader(INPUTFILE);
            StreamWriter write = new StreamWriter(OUTPUTFILE);
            List<string> namemass = new List<string>();
            using (read)
            {
                string readline = read.ReadLine();
                while (readline!=null)
                {
                    namemass.Add(readline);
                    readline = read.ReadLine();
                }
            }

            namemass.Sort();

            using (write)
            {
                foreach (var item in namemass)
                {
                    write.WriteLine(item);
                }
            }
        }
            	
    }
}
