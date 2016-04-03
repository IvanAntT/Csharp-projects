using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogomerni_masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] mass = { "Pole", "Stoe", "Ambel", "Dovel", "Koska" };
            //Console.WriteLine(string.Join(" ",mass));
            //Array.Sort(mass);
            //Console.WriteLine(string.Join(" ",mass));
            //int index=Array.BinarySearch(mass, "Krakk");
            //Console.WriteLine("Krakk e na {0} poziciq",index);
            Console.WriteLine("Domashno");
            //Console.WriteLine("ZADA4A 1 A");
            //int[,] mass = new int[8, 8];
            //int br = 1;
            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 0; col < 8; col++)
            //    {
            //        mass[col, row] = br;
            //        br++;
            //    }
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(mass[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("ZADA4A 1 B");
            //int[,] mass = new int[4, 4];
            //int row = 0;
            //int col = 0;
            //int br=1;
            //while (col<4)
            //{
            //    mass[row, col] = br;
            //    if (col % 2 == 0)
            //    {
            //        row++;
            //        br++;
            //    }
            //    else { row--; br++; }
            //    mass[row, col] = br;
            //    if (row==3 || row==0)
            //    {
            //        col++;
            //        br++;
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(mass[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("ZADA4A 1 C");
            //int n = 7;
            //int[,] mass = new int[n, n];
            //int krrow = n-1;

            //int br = 1;
            //for (int roww = n-1; roww >= 0; roww--)
            //{
            //    int currow = roww;
            //    for (int coll = 0; coll < n-krrow; coll++)
            //    {
            //        mass[currow, coll]=br;
            //        currow++;
            //        br++;
            //    }
            //    krrow--;
            //}
            //int z = n-1;
            //for (int i = 1; i < n; i++)
            //{
            //    int curow = i;
            //    for (int j = 0; j < z; j++)
            //    {
            //        mass[j,curow]=br;
            //        curow++;
            //        br++;
            //    }
            //    z--;
            //}
            
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(mass[i,j]+"  ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("ZADA4A 2");
            //int[,] mass = {
            //               {1,3,4,5,5,6,1,2,3},
            //               {3,4,1,1,4,2,6,2,5},
            //               {5,1,2,1,3,5,6,5,4}
            //              };
            //int bestsum=0;
            //for (int i = 0; i < mass.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        Console.Write(mass[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < mass.GetLength(0)-2; i++)
            //{
            //    for (int j = 0; j < mass.GetLength(1)-2; j++)
            //    {
            //        int sum = mass[i, j] + mass[i + 1, j] + mass[i + 2, j] +
            //                mass[i, j + 1] + mass[i + 1, j + 1] + mass[i + 2, j + 1] +
            //                mass[i, j + 2] + mass[i + 1, j + 2] + mass[i + 2, i + 2];
            //        if (sum>bestsum)
            //        {
            //            bestsum = sum;
            //        }
            //    }
            //}
            //Console.WriteLine(bestsum);

            //Console.WriteLine("ZADA4A 3");
            //string[,] mass ={
            //                   {"ha","xsx","ho","xxxx"},
            //                   {"fo","ha","xsx","xxxx"},
            //                   {"ho","ho","h","xxxx"}
            //               };
            //string end = "";
            //int bestbr = 1;
            //int curRow = 0;
            //int curCol = 0;
            //for (int f = 0; f < mass.GetLength(0); f++)
            //{
            //    for (int z = 0; z < mass.GetLength(1); z++)
            //    {
            //        Console.Write(mass[f,z]+" ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < mass.GetLength(0)-1; i++) //proverqva diagonali
            //{
                
            //    for (int j = 0; j < mass.GetLength(1)-1; j++)
            //    {
            //        int crow = i;
            //        int ccol = j;
            //        int br = 1; 
            //        while (mass[crow, ccol] == mass[crow + 1, ccol + 1])
            //        {
            //            br++;
            //            crow++;
            //            ccol++;
            //            if (crow==mass.GetLength(0)-1||ccol==mass.GetLength(1)-1)
            //            {
            //                break;
            //            }
            //        }
            //        if (br>bestbr)
            //        {
            //            bestbr = br;
            //            curRow = crow-1;
            //            curCol = ccol -1;

            //        }
            //    }
            //}

            //for (int i = 0; i < mass.GetLength(0); i++) //proverqva redove
            //{
               
            //    for (int j = 0; j < mass.GetLength(1)-1; j++)
            //    {
            //        int br = 1;
            //        int crow = i;
            //        int ccol = j;
            //        while (mass[crow, ccol] == mass[crow, ccol+1])
            //        {
            //            br++;
            //            ccol++;
            //            if (ccol == mass.GetLength(0) - 1)
            //            {
            //                break;
            //            }
            //        }
            //        if (br > bestbr)
            //        {
            //            bestbr = br;
            //            curRow = crow;
            //            curCol = ccol-1;
            //        }
            //    }
            //}

            //for (int i = 0; i < mass.GetLength(0)-1; i++)
            //{
            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        int br = 1;
            //        int crow = i;
            //        int ccol = j;
            //        while (mass[crow, ccol] == mass[crow+1, ccol])
            //        {
            //            br++;
            //            crow++;
            //            if (crow == mass.GetLength(0) - 1)
            //            {
            //                break;
            //            }
            //        }
            //        if (br > bestbr)
            //        {
            //            bestbr = br;
            //            curRow = crow-1;
            //            curCol = ccol;
            //        }
            //    }
            //}

            //while (bestbr>0)
            //{
            //    Console.Write(mass[curRow,curCol]+" ");
            //    bestbr--;
            //}
            //Console.WriteLine();
            //Console.WriteLine(end);
            //Console.WriteLine("ZADA4A 4");
            //Console.Write("N=");
            //int n = int.Parse(Console.ReadLine());
            //int[] mass = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    mass[i] = num;
            //}
            //Console.WriteLine("K=");
            //int k = int.Parse(Console.ReadLine());
            //Array.Sort(mass);
            //int index=-1;
            //while (index<0)
            //{
            //    index = Array.BinarySearch(mass, k);
            //    k--;
            //    if (k==0)
            //    {
            //        Console.WriteLine("Nqma namereno 4islo");
            //        return;
            //    }
            //}
            //Console.WriteLine("4isloto e {0}",mass[index]);

            //Console.WriteLine("ZADA4A 5");
            //int N = int.Parse(Console.ReadLine());
            //string[] mass = new string[N];
            //string[] mass2=new string[N];
            //int[] masssort=new int [N];
            //for (int i = 0; i < N; i++)
            //{
            //    string word = Console.ReadLine();
            //    mass[i] = word;
            //    masssort[i] = word.Length;
            //}
            //Array.Copy(mass, mass2,mass.Length);
            //Array.Sort(masssort);
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < masssort.Length; j++)
            //    {
            //        if (mass[i].Length == masssort[j])
            //        {
            //            mass2[i] = mass[j];
            //        }
            //    }
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(mass2[i]);
            //}


        }
    }
}
