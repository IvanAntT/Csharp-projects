using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_ball
{
    class Program
    {
        static void Main()
        {
            char[,] matrix = new char[8, 8];
            char[] T = new char[8];
            char[] B = new char[8];
            int Tscore = 0;
            int Bscore = 0;

            for (int i = 0; i < 8; i++)
            {
                string num = Console.ReadLine();
                int numm = int.Parse(num);
                T = Convert.ToString(numm, 2).PadLeft(8,'0').ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    if (T[j] == '1') { matrix[i,j] = 'T'; };
                }
               
            }

            for (int i = 0; i < 8; i++)
            {
                string num = Console.ReadLine();
                int numm = int.Parse(num);
                B = Convert.ToString(numm, 2).PadLeft(8,'0').ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    
                    if (B[j] == '1')
                    {
                        if (matrix[i, j] == 'T')
                        {
                            matrix[i, j] = ' ';
                        }
                        else { matrix[i, j] = 'B'; }
                    }
                    
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i,j]=='T')
                    {
                        int curRow=i;
                        int curCol=j;
                        int stop = 0;
                        while (curRow<7)
                        {
                            curRow++;
                            if (matrix[curRow, curCol] == 'B' || matrix[curRow, curCol] == 'T')
                            {
                                stop = 1;
                                break;
                            }
                        }
                        if (stop == 1)
                        {
                            continue;
                        }
                        else { Tscore++; }
                    }

                    if (matrix[i,j]=='B')
                    {
                        int cuRow = i;
                        int cuCol = j;
                        int stop = 0;
                        while (cuRow>0)
                        {
                            cuRow--;
                         if (matrix[cuRow, cuCol] == 'B' || matrix[cuRow, cuCol] == 'T')
                            {
                                stop = 1;
                                break;
                            }   
                        }
                        if (stop == 1)
                        {
                            continue;
                        }
                        else { Bscore++; }
                        
                    }
                }
            }

            Console.WriteLine("{0}:{1}",Tscore,Bscore);
            
            //izgled na matricata
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
