using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
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
                mass = Convert.ToString(num, 2).PadLeft(8,'0').ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = mass[j];
                }
            }

            int longest = 1;
            int longCount = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int br = 0;
                    if (matrix[i, j] == '1')
                    {
                        int curRow = i;
                        while (matrix[curRow, j] == '1' && curRow < 7)
                        {
                            curRow++;
                            br++;
                        }
                        if (longest < br)
                        {
                            longest = br;
                        }
                        if (longest == br)
                        {
                            longCount++;
                        }
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    int brr = 0;
                    if (matrix[i, j] == '1')
                    {
                        int curCol = j;
                        while (matrix[i, curCol] == '1')
                        {
                            brr++;
                            curCol++;
                            if (curCol == 8)
                            {
                                break;
                            }
                        }
                        if (longest < brr)
                        {
                            longest = brr;
                        }
                        if (longest == brr)
                        {
                            longCount++;
                        }
                    }

                }
            }

            if (longest==1)
            {
                longCount = longCount / 2;
            }
            Console.WriteLine(longest);
            Console.WriteLine(longCount);
            Console.WriteLine(new string('-',32));
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
