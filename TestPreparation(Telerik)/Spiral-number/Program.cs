using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] mass=new int[num,num];
            int curRow = 0;
            int curCol = 0;
            int br = 1;
            int a=0;
            while (true)
            {

                while (true)
                {
                    mass[curRow, curCol] = br;

                    curCol++;
                    br++;
                    if (curCol > num - 1-a)
                    {
                        br--;
                        curCol--;
                        break;
                    }
                }

                while (true)
                {
                    mass[curRow, curCol] = br;
                    curRow++;
                    br++;
                    if (curRow > num - 1-a)
                    {
                        br--;
                        curRow--;
                        break;
                    }
                }

                while (true)
                {
                    mass[curRow, curCol] = br;
                    curCol--;
                    br++;
                    if (curCol < a)
                    {
                        br--;
                        curCol++;
                        break;
                    }
                }

                while (true)
                {
                    mass[curRow, curCol] = br;
                    curRow--;
                    br++;
                    if (curRow < a+1)
                    {
                        br--;
                        curRow++;
                        break;
                    }
                }
                a++;
                if (a>num/2)
                {
                    break;
                }
            }
        
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    
                    Console.Write(mass[row,col]);
                    if (mass[row, col] < 10)
                    {
                        Console.Write("   ");
                    }
                    else { Console.Write("  "); }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
