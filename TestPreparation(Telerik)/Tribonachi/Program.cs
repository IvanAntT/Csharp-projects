using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonachi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            string str;
            int row;
            do
            {
                 Console.Write("row=");
                 str = Console.ReadLine();
            } while (!(int.TryParse(str, out row)) || !(int.Parse(str) < 20) || !(int.Parse(str) >= 1));
            row = int.Parse(str);


            string str1;
            int col;
            do
            {
                Console.Write("col=");
                str1 = Console.ReadLine();
            } while (!(int.TryParse(str1, out col)) || !(int.Parse(str1) <= 20) || !(int.Parse(str1) >= 4));
            col = int.Parse(str1);
            int[,] mass = new int[row, col];
            int rez = 0;
            mass[0, 0] = a;
            mass[0, 1] = b;
            mass[0, 2] = c;
            mass[0, 3] = d;
            for (int i = 0; i < row; i++)
            {
                if (i == 0)
                {
                    for (int j = 4; j < col; j++)
                    {
                        rez = a + b + c + d;
                        a = b;
                        b = c;
                        c = d;
                        d = rez;
                        mass[i, j] = rez;
                    }
                }
                else
                {
                    for (int j = 0; j < col; j++)
                    {
                        rez = a + b + c + d;
                        a = b;
                        b = c;
                        c = d;
                        d = rez;
                        mass[i, j] = rez;
                    }

                }
            }

            for (int roww = 0; roww < row; roww++)
            {
                for (int coll = 0; coll < col; coll++)
                {
                    Console.Write(mass[roww,coll]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
