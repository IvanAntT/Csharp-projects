using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UK_flag
{
    class Program
    {
        static void Main()
        {
            int row=0;
            int col=0;
            string str = Console.ReadLine();
            row = int.Parse(str);
            col = int.Parse(str);
            char[,] mass=new char[row,col];

            for (int i = 0; i < row; i++)
			{
			  for (int j = 0; j < col; j++)
			{
			       mass[i,j]='.';
			}

			}
            int a = row-1;
            int b = col-1;
            while (a>=0&&b>=0)
            {
                mass[a, b] = '\\';
                a--;
                b--;
            }

            int aa = 0;
            int bb = col - 1;
            while (aa<row&&bb>=0)
            {
                mass[aa,bb]='/';
                aa++;
                bb--;
            }

            int aaa = row-1;
            int bbb = (col / 2);
            
            while (aaa>=0)
            {
                mass[aaa, bbb] = '|';
                aaa--;
            }

            int bbbb = 0;
            int aaaa = (row / 2);
            while (bbbb<row)
            {
                mass[aaaa, bbbb] = '-';
                bbbb++;
            }

            mass[row / 2, col / 2 ] = '*';

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mass[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
