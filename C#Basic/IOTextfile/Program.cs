using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class Program
    {
        const string INPUTFILE = "input.txt";

        static void Main()
        {
            StreamReader read=new StreamReader(INPUTFILE);
            //using (read)
            //{
            //    string text = read.ReadToEnd();                
            //    Console.WriteLine(text);
            //}

            //using (read)
            //{
            //    string te = "";
            //    int br = 0;
            //    while (te!=null)
            //    {
            //        br++;
            //        te = read.ReadLine();
            //        if (br%2==1)
            //        {
            //            Console.WriteLine(te);
            //        }
            //        else
            //        {
            //            continue;
            //        }
                    
            //    }
            //}
            //Zad2.start();
            //Zad3.start();
            //Zad4.start();
            //Zad5.start();
            //Zad6.start();
            //Zad7.start();
            //zad9.start();
            //zad10.start();
            //zad11.start();
            //zad12.start();
            //zad13.start();
            Extratask.start();

        }
    }
}
