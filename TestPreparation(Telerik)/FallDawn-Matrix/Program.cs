using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDawn_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            
            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());
                string str = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(str[col].ToString());
                }
            }
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

            for (int col = 0; col < 8; col++)
            {
                int br = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row,col]==1)
                    {
                        br++;
                        matrix[row, col] = 0;
                    }
                }

                for (int i = 0; i < br; i++)
                {
                   matrix[7 - i, col]=1;
                }
            }

            /* 1-variant na izpe4atvane na matricata
             * 
            Console.WriteLine();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
             */
            // 2 variant na izpe4atvane na matricata
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb=new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row, col]);
                }
                int chislo = Convert.ToInt32(sb.ToString(), 2);//prevru6ta ot dvoi4na 
                                                               //v deseti4na sistema
                Console.WriteLine(chislo);
            }

        
            
        }
    }
}
