using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolzvaneNaKlasoveiObekti
{
    public class SurfaceOfTriangle
    {
        public static void Lice(int Side, int Altitude) //altitude-viso4ina
        {
            int S = (Side / 2) * Altitude;
            Console.WriteLine("S={0}",S);
        }

        public static void Lice(int first, int second,double sinfirst) 
        {
            double S = (first * second) * sinfirst;
            Console.WriteLine("S={0}", S);
        }

        public static void Lice(int a,int b,int c) 
        {
            int p = (a + b + c) / 2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("S={0:F}", S);
        }
        
    }
}
