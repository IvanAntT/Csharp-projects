using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajneniq_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //string str = Convert.ToString(num, 2).PadLeft(6, '0');
            //string str1 = Convert.ToString(num1, 2).PadLeft(6, '0');
            //Console.WriteLine(str);
            //Console.WriteLine(str1);
            //Console.WriteLine("-------------");
            
            //    Console.Write(Convert.ToString(num&num1,2).PadLeft(6,'0'));
            //int[,] matrix = new int[8, 8];
            //for (int row = 0; row < 8; row++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    string str = Convert.ToString(num, 2).PadLeft(8, '0');
               
            //    for (int col = 0; col < 8; col++)
            //    {
            //        matrix[row, col] = int.Parse(str[col].ToString()); 
            //    }
            //}

            //for (int row = 0; row < 8; row++)
            //{
            //    int count = 0;
            //    for (int col = 0; col < 8; col++)
            //    {
            //        if (matrix[row,col]==1)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("pri "+row+" red broqt edinici e "+count);
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.Write(" "+i);
            //    Console.WriteLine();
            //}

            //for (int row = 0; row < 8; row++)
            //{
            //    StringBuilder sb=new StringBuilder();
            //    for (int col = 0; col < 8; col++)
            //    {
            //        sb.Append(matrix[row, col]);
            //    }

            //    int m = Convert.ToInt32(sb.ToString(), 2);
            //    Console.WriteLine(m);
            //}

            int[] arr = { 2, 2, 3, 3, 4, 4, 7, 5, 5 };
            int raz = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                raz = raz ^ arr[i + 1];
            }
            Console.WriteLine(raz);

            Console.WriteLine(TimeSpan.TicksPerSecond);
        }
    }
}
