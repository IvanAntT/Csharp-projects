using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad17
    {
        public static void DateConvener()
        {
            Console.Write("Vuvedete data i 4as : ");
            string date = Console.ReadLine();
            string[] convertdate = date.Split('.', ':',' ');
            DateTime datetoconvert = new DateTime(
                int.Parse(convertdate[2]),int.Parse(convertdate[1]), 
                int.Parse(convertdate[0]),int.Parse(convertdate[3]), 
                int.Parse(convertdate[4]),int.Parse(convertdate[5]));
            datetoconvert=datetoconvert.AddHours(6);
            datetoconvert = datetoconvert.AddMinutes(30);
            Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss}",datetoconvert);
        }
    }
}
