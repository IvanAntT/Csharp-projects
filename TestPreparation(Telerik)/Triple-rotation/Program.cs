using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    1-VARIANT(VUVEJDANE NA STRING)
            string str = Console.ReadLine();
            string str2="";
            for (int i = 0; i < 3; i++)
            {
                str2 = str[str.Length - 1].ToString();
                
               str=str.Remove(str.Length - 1);
               if (str2=="0")
               {
                   str2 = "";
               }
                str = str2 + str;
            }
            Console.WriteLine("krainoto 4islo e "+str);
             */

            //2-VARIANT(VUVEJDANE NA INTEGER)
            int num = int.Parse(Console.ReadLine());
            int last = 0;
            string str = "";
            if (num < 100&&num>9)
            {
                last = num % 10;
                num = num / 10;
                str = last.ToString() + num.ToString();
                Console.WriteLine(str);
            }
            else if (num < 10) { Console.WriteLine(num); }
            else if (num > 99)
            {
                for (int i = 0; i < 3; i++)
                {
                    last = num % 10;
                    if (last == 0)
                    {
                        num = num / 10;
                    }
                    else
                    {
                        str = last.ToString() + str;
                        num = num / 10;
                    }
                }
                if (num == 0) { Console.WriteLine(str); }
                else { Console.WriteLine(str + num.ToString()); }
            }    
        }
    }
}
