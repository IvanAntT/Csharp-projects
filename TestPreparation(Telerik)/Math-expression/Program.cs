using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n = int.Parse(Console.ReadLine());
            //double m = int.Parse(Console.ReadLine());
            //double p = int.Parse(Console.ReadLine());

            //double urav1 = n * n + 1 / (m * p) + 1337;
            //double z = 128.523123123 * p;
            //double urav2 = n-(z);
            //double urav3 = Math.Sin(m % 180);
            //double kraino = urav1 / urav2 + urav3;
            //Console.WriteLine("{0:F6}",kraino);

            string str = Console.ReadLine();
            int num = int.Parse(str);
            int sum = 0;
            double sum1 = 0;
            int posl = 0;
            int br2 = 0;
            while (true)
            {
                posl = num % 10;
                sum1 = sum1+posl * (Math.Pow(7, br2));
                br2++;
                num = num / 10;
                if (num==0)
                {
                    break;
                }
            }
            //Console.WriteLine(sum1);
            //sum = sum + 1;
            sum = (int)sum1+1;
            string su = sum.ToString();
            string strr = "";
            double ostatuk = 0;
            while (true)
            {
                ostatuk = sum % 7; //  6 ostatuk
                sum = sum / 7;  // 5 polu4eno
                strr = ostatuk.ToString()+strr;
                if (sum==0)
                {
                    break;
                }
            }
            Console.WriteLine(strr);
        }
    }
}
