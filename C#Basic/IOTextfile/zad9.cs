using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class zad9
    {
        const string FILE = @"..\..\zad9\file.txt";

        public static void start()
        {
            List<string> mass;
            StreamReader read = new StreamReader(FILE);
            using (read)
            {
                mass=new List<string>();
                string textline = read.ReadLine();
                int linenumber = 1;
                while (textline!=null)
                {
                    if (linenumber%2==0)
                    {
                        mass.Add(textline);
                    }
                    linenumber++;
                    textline = read.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(FILE);
            using (writer)
            {
                foreach (var item in mass)
                {
                    writer.WriteLine(item);
                }
            }
        }

    }
}
