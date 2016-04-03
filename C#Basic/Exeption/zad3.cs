using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exeption
{
    public class zad3
    {
        public static void ReadFilePath()
        {
            Console.Write("Vuvedete putq na faila: ");
            string path = Console.ReadLine();
            StreamReader read = new StreamReader(path);
            string text = read.ReadToEnd();
            Console.WriteLine(text);
        }
    }
}
