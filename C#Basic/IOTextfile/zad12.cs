using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    public class zad12
    {
        const string FILE1 = @"..\..\zad12\file1.txt";
        const string FILE2 = @"..\..\zad12\file2.txt";
        public static void start()
        {
            try
            {
                StreamReader readfile1 = new StreamReader(FILE1);
                StreamReader readfile2 = new StreamReader(FILE2);
                string textfromfile1;
                string textfromfile2;
                string finaltext;
                using (readfile1)
                {
                    using (readfile2)
                    {
                        textfromfile1 = readfile1.ReadToEnd();
                        textfromfile2 = readfile2.ReadToEnd();
                        int index = textfromfile1.IndexOf(textfromfile2, 0);
                        finaltext = textfromfile1.Remove(index, textfromfile2.Length);
                    }
                }
                Console.WriteLine(finaltext);
            }
            catch (FileNotFoundException) { Console.WriteLine("Path is not true"); }
            catch (OverflowException) { Console.WriteLine("Prepulnen masiv"); }
            catch (Exception) { Console.WriteLine("Some other exeption"); }
        }
    }
}
