using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class Zad4
    {
        const string INPUT1 = @"..\..\zad4\input1.txt";
        const string INPUT2 = @"..\..\zad4\input2.txt";
        const string OUTPUT = @"..\..\zad4\output.txt";

        public static void start()
        {
            StreamReader read1 = new StreamReader(INPUT1);
            StreamReader read2 = new StreamReader(INPUT2);
            StreamWriter write = new StreamWriter(OUTPUT,true);
            List<string> text1 = new List<string>();
            List<string> text2 = new List<string>();
         
                using (read1)
                {
                    string textline = read1.ReadLine();
                    while (textline!=null)
                    {
                        text1.Add(textline);
                        textline = read1.ReadLine();
                    }
                }

                using (read2)
                {
                    string textline2 = read2.ReadLine();
                    while (textline2 != null)
                    {
                        text2.Add(textline2);
                        textline2 = read2.ReadLine();
                    }
                }

                using (write)
                {
                    for (int i = 0; i < text1.Count; i++)
                    {
                        for (int j = 0; j < text2.Count; j++)
                        {
                            if (text1[i] == text2[j])
                            {
                                write.WriteLine("{0} line from first={1} line from second: {2}", i+1, j+1, text1[i]);
                            }
                        }
                    }
                }
        }
    }
}
