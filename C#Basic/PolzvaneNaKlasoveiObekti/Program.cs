using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolzvaneNaKlasoveiObekti
{
    class Program
    {
        public enum Day
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday=0
        };

        static void Main(string[] args)
        {
            //string str = "123456789";
            //string krai =str.Substring(3,2);
            //Console.WriteLine(krai);
            //Console.WriteLine("ZADA4A 1");
            //Console.WriteLine("vuvedi godina");
            //string date = Console.ReadLine();
            //DateTime a = new DateTime(int.Parse(date),2,28);
            //DateTime b = a.AddDays(1);
            //if (b.Day == 29)
            //{
            //    Console.WriteLine("Leap year");
            //}
            //else
            //{
            //    Console.WriteLine("The year is not a Leap");
            //}

            //Console.WriteLine("ZADA4A 2");
            //for (int i = 0; i < 10; i++)
            //{
            //    Random number = new Random();                
            //    Console.WriteLine(number.Next());
            //    System.Threading.Thread.Sleep(1000);
            //}

            //Console.WriteLine("ZADA4A 3");
            //DateTime today1 = DateTime.Now;
            //DateTime today = today1.AddDays(14);
            //int den = (int)today.DayOfWeek;
            //Day d = (Day)den;
            //Console.WriteLine(d);

            Console.WriteLine("ZADA4A 4");
            SurfaceOfTriangle.Lice(2, 3);
            SurfaceOfTriangle.Lice(2, 3, 2.3);
            SurfaceOfTriangle.Lice(2, 3, 3);
        }
    }
}
