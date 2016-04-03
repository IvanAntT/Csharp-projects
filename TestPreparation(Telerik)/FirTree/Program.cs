using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            
            int brdot=num-2;
            int brstar = 1;
            string lastrow = new string('.', brdot) + new string('*', brstar) + new string('.', brdot);
            for (int i = 0; i < num-1; i++)
            {
                Console.Write(new string('.',brdot));
                Console.Write(new string('*', brstar));
                Console.Write(new string('.', brdot));
                Console.WriteLine();
                brdot--;
                brstar += 2;
            }
           Console.WriteLine(lastrow);
            //Za trapec koda e
            //brdot+=2;
            //brstar -= 4;

            //for (int i = 0; i < num-1; i++)
            //{
            //   Console.Write(new string('.',brdot));
            //    Console.Write(new string('*', brstar));
            //    Console.Write(new string('.', brdot));
            //    Console.WriteLine();
            //    brdot++;
            //    brstar -= 2;
            //    if (brstar<0)
            //    {
            //        break;
            //    }
            //}
        }
    }
}
