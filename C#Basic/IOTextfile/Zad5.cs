using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOTextfile
{
    class Zad5
    {
        const string INPUTFILE = @"..\..\zad5\input.txt";
        const string OUTPUT = @"..\..\zad5\output.txt";

        public static void start()
        {
            StreamReader read = new StreamReader(INPUTFILE);
            StreamWriter write = new StreamWriter(OUTPUT);
            int[,] mass;
            int N;
            using (read)
            {
                N = int.Parse(read.ReadLine());
                mass = new int[N, N];
                string textline = read.ReadLine();
                int row = 0;
                int col = 0;
                while (textline!=null)
                {
                    while (col!=N)
                    {
                        mass[row, col] = int.Parse(textline[col].ToString());
                        col++;
                    }
                    col = 0;
                    row++;
                    if (row==N)
                    {
                        break;
                    }
                    textline = read.ReadLine();
                }
            }

            int maxsum = 1;
            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < N-1; j++)
                {
                    int sum=mass[i,j]+mass[i,j+1]+mass[i+1,j]+mass[i+1,j+1];
                    if (sum>maxsum)
                    {
                        maxsum = sum;
                    }
                }
            }
            using (write)
            {
                write.WriteLine(maxsum);
            }
            
        }
    }
}
