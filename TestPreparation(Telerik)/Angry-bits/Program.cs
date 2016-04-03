using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 16];
            char[] mass = new char[16];

            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());
                mass = Convert.ToString(num, 2).PadLeft(16,'0').ToCharArray();

                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = mass[col];
                }
            }
            int brpos = 0;
           // int brpigs = 0;
            int score = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i,j]=='0')
                    {
                        continue;
                    }
                    else
                    {
                        int curRow = i;
                        int curCol = j;
                        int brpigs = 0;
                        while (curRow>0)
                        {
                           
                            curRow--;
                            curCol++;
                       

                            if (matrix[curRow, curCol] == '1')
                            {
                                 
                                brpos=(curCol - j);
                               
                                brpigs++;
                                matrix[curRow, curCol] = '0';
                                for (int ok = curRow - 1; ok < curRow + 2; ok++)
                                {
                                    for (int okk = curCol - 1; okk < curCol + 2; okk++)
                                    {
                                        if (ok == -1 || okk == 16 || ok == 8 || okk == -1)
                                        {
                                            continue;
                                        }
                                        if (matrix[ok, okk] == '1')
                                        {
                                            brpigs++;
                                            matrix[ok, okk] = '0';
                                        }
                                    }
                                }
                                score = score + brpos * brpigs;
                            }
                        }
                        while (curRow<7)
                        {
                           
                            curRow++;
                            curCol++;
                          //  brpos++;
                            if (curRow == -1 || curCol == 16 || curRow == 8 || curCol == -1)
                            {
                                break;
                            }
                            if (matrix[curRow, curCol] == '1')
                            {
                                brpigs++;
                                matrix[curRow, curCol] = '0';
                                brpos = (curCol - j);
                                
                                for (int ok = curRow-1;ok < curRow+2;ok++)
                                {
                                    for (int okk = curCol-1; okk < curCol+2; okk++)
                                    {
                                        if (ok == -1 || okk == 16 || ok == 8 || okk == -1)
                                        {
                                            continue;
                                        }
                                        if (matrix[ok,okk]=='1')
                                        {
                                            brpigs++;
                                            matrix[ok, okk] = '0';
                                        }
                                    }
                                }
                                score = score + brpos * brpigs;
                            }
                        }
                    }
                }
            }
            string clean = "Yes";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 8; j < 16; j++)
                {
                    if (matrix[i,j]=='1')
                    {
                        clean = "No";
                    }
                }
           
            }
           
            Console.WriteLine("{0} {1}",score,clean);
        }
    }
}
