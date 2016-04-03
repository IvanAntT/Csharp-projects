using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IOTextfile
{
    class Zad7
    {
        const string FILE = @"..\..\zad7\file.txt";
        const string FFILE = @"..\..\zad7\file.txt";
        const string searchword = "start";
        const string repaceword = "finish";
        public static void start()
        {
            StreamReader read = new StreamReader(FILE);
           
            string newtext;
            using (read)
            {
                string text = read.ReadToEnd();
                newtext=text.Replace(searchword,repaceword);
            }
            StreamWriter write = new StreamWriter(FFILE);
            using(write)
	        {
	        	 write.Write(newtext);
	        }
        }
    }
}
