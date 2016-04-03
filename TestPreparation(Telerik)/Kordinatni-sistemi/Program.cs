using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordinatni_sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());

            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
           
            int D = int.Parse(Console.ReadLine());

            if (Px2>Px1)
            {
                int temp = Px1;
                Px1 = Px2;
                Px2 = temp;
            }

            if (Py1>Py2)
            {
                int temp1 = Py2;
                Py2 = Py1;
                Py1 = temp1;
            }

            int br = 0;

            if (Fx + D <= Px1 && Fx + D >= Px2 && Fy >= Py1 && Fy <= Py2)
            {
                br = br + 100;
            }

            if (Fx + D <= Px1 && Fx + D >= Px2 && Fy - 1 >= Py1 && Fy - 1 <= Py2
                || Fx + D <= Px1 && Fx + D >= Px2 && Fy +1 >= Py1 && Fy+1 <= Py2)
            {
                br = br + 50;
            }

            if (Fx + D + 1 <= Px1 && Fx + D+1 >= Px2 && Fy >= Py1 && Fy <= Py2)
            {
                br = br + 75;
            }

            Console.WriteLine("{0}%",br);
        }
    }
}
