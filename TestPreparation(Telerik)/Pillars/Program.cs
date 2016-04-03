using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];
            char[] mass = new char[8];
            for (int i = 0; i < 8; i++)
            {
                int num = int.Parse(Console.ReadLine());
                mass = Convert.ToString(num, 2).PadLeft(8, '0').ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = mass[j];
                }
            }

            int equalbr = 0;
            int equalcol = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i,j]=='1')
                    {
                        int curColL = j;
                        int curColR = j;
                        int brL = 0;
                        int brR = 0;
                        for (int row = 0; row < 8; row++)
                        {
                            for (int col = 0; col < curColL; col++)
                            {
                                if (matrix[row,col]=='1')
                                {
                                    brL++;
                                }
                            }
                        }

                        for (int roww = 0; roww < 8; roww++)
                        {
                            for (int coll = curColR+1; coll <8; coll++)
                            {
                                if (matrix[roww,coll]=='1')
                                {
                                    brR++;
                                }
                            }
                        }

                        if (brL==brR)
                        {
                            equalbr = brR;
                            equalcol = 7-j;
                        }
                        else
                        {
                            equalbr = -1;
                        }
                    }
                }
            }
            if (equalbr == -1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(equalcol);
                Console.WriteLine(equalbr);
            }
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
