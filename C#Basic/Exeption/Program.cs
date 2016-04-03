using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Exeption
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Vuvedete Integer: ");  ZADA4A 1
            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number<0)
            //    {
            //             throw new FormatException();
            //    }
            //    Console.WriteLine(Math.Pow(number,2));
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //finally { Console.WriteLine("\nGood Bye"); };

            //Console.WriteLine("Vuvedete nai-malkata dopustima stoinost");  ZADA4A 2
            //int startnum=int.Parse(Console.ReadLine());
            //Console.WriteLine("Vuvedete nai-golqmata dopustima stoinost");
            //int endnum = int.Parse(Console.ReadLine());
            //try
            //{
            //    Read.ReadNumberr(startnum, endnum);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Write Integer number!!!");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Write Integer in the range {0}-{1}", startnum, endnum);
            //}
            //try
            //{
            //    zad3.ReadFilePath();
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Vuvedete pravilno putq");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("vuvedete pravilno imeto na faila");
            //}
            //catch (DriveNotFoundException)
            //{
            //    Console.WriteLine("nqmate dostup do tozi put");
            //}
            //catch (EndOfStreamException)
            //{
            //    Console.WriteLine("opit za 4etene sled kraq na faila");
            //}
            //catch (FileLoadException)
            //{
            //    Console.WriteLine("failut e nameren no nomoje da se otvori");
            //}
            //catch (PathTooLongException)
            //{
            //    Console.WriteLine("putq ili imeto na faila sa tvurde golemi");
            //}
            WebClient download = new WebClient();
            try
            {
                download.DownloadFile("http://tattoospedia.com/tatuaje/Wolf%20Tattoo%20Meaning/Wolf%20Tattoo%20Meaning_13.jpg", @"../../wolf.jpg");
                Console.WriteLine("Download Complete");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("adresa e prazen");
            }
            catch (WebException)
            {
                Console.WriteLine("greshen URI adres");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Nqkolko nishki izpolzvat tozi fail");
            }
            finally
            {
                download.Dispose();
                Console.WriteLine("Resources is clear");
            }
            Console.WriteLine(download.BaseAddress);
        }
    }
}
