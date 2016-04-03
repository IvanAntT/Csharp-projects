using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad16
    {
        public static void DaysBitweenTwoDateTime()
        {
            Console.Write("Vuvedete purva data: ");
            string date1 = Console.ReadLine();
            Console.Write("Vuvedete vtora data: ");
            string date2 =Console.ReadLine();
            string[] newdate1 = date1.Split('.');
            string[] newdate2 = date2.Split('.');
            Array.Reverse(newdate1);
            Array.Reverse(newdate2);
            DateTime Ddate1 = new DateTime(int.Parse(newdate1[0]), int.Parse(newdate1[1]), int.Parse(newdate1[2]));
            DateTime Ddate2 = new DateTime(int.Parse(newdate2[0]), int.Parse(newdate2[1]), int.Parse(newdate2[2]));

            TimeSpan days = Ddate1 - Ddate2;
            Console.WriteLine("Dnite mejdu {0:dd.MM.yyyy} i {1:dd.MM.yyyy} sa:{2:dd}", Ddate1, Ddate2, days);
        }
    }
}
