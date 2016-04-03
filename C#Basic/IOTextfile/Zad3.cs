using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class Zad3
    {
        const string INPUTFILE = @"zad3\input.txt";
        const string OUTPUTFILE = @"zad3\output.txt";

        public static void start()
        {
            StreamReader read = new StreamReader(INPUTFILE);
            StreamWriter write = new StreamWriter(OUTPUTFILE);
            using (read)
            {
                using (write)
                {
                    string readline="";
                    int br = 0;
                    while (readline!=null)
                    {
                        br++;
                        readline = read.ReadLine();
                        write.WriteLine("{0} line: {1}", br, readline);
                    }
                }
            }
        }
    }
}
