using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logo_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z =(x/2+1);
            int w= (2*x+2*z)-3;
            int [,] mass= new int[w,w];
            int curRow=z-1;
            int curCol = 0;

            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol++;
                curRow--;
                if (curRow<0)
                {
                    curCol--;
                    curRow++;
                    break;
                }
            }

            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol++;
                curRow++;
                if (curCol>w-z)
                {
                    curCol--;
                    curRow--;
                    break;
                }
            }

            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol--;
                curRow++;
                if (curCol < w/2)
                {
                    curCol++;
                    curRow--;
                    break;
                }
            }

            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol--;
                curRow--;
                if (curCol<z-1)
                {
                    curRow++;
                    curCol++;
                    break;
                }
            }
            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol++;
                curRow--;
                if (curRow<0)
                {
                    curCol--;
                    curRow++;
                    break;
                }
            }

            while (true)
            {
                mass[curRow, curCol] = 1;
                curCol++;
                curRow++;
                if (curCol>w-1)
                {
                    break;
                }

            }
            
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (mass[i,j]==0)
                    {
                        Console.Write(".");
                    }

                    if (mass[i, j] == 1)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
