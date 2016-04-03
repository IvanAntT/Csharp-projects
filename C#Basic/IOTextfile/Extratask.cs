using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    public class Extratask
    {
        const string FILE = @"..\..\extra\file.txt";
        const string FFILE = @"..\..\extra\result.txt";
        const string searchword = "Силвия";

        public static void start()
        {
            StreamReader read = new StreamReader(FILE, Encoding.GetEncoding(1251));
            StreamWriter write = new StreamWriter(FFILE);
            using (read)
            {
                using (write)
                {
                    string readtext = read.ReadToEnd();
                    char[] mass = readtext.ToCharArray();
                    string word = "";
                    int index = readtext.IndexOf(searchword, 0);
                    int br = 0;
                    while (br != searchword.Length)
                    {
                        word = word + mass[index];
                        index++;
                        br++;
                    }
                    word=word.ToUpper();
                    write.WriteLine(word);
                }
            }
        }
    }
}
