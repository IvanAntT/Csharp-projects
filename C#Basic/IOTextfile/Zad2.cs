using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class Zad2
    {
        const string INPUTFILE1 = "input1.txt";
        const string INPUTFILE2 = "input2.txt";
        public static void start()
        {
            StreamReader read1 = new StreamReader(INPUTFILE1);
            StreamReader read2 = new StreamReader(INPUTFILE2);
            StreamWriter text = new StreamWriter("final-text");
            using (read1)
            {
                using (read2)
                {
                    using (text)
                    {
                        string str = read1.ReadToEnd();
                        
                        string str2 =read2.ReadToEnd();
                        text.WriteLine(str);
                        text.WriteLine(str2);
                    }
                }
            }

        }

    }
}
