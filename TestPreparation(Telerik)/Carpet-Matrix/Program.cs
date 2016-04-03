using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpet_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] mass = new int[num, num];
            int start=num/2-1; //na4alo na simvolite razli4ni ot "."
            int end=num/2-1;   //krai na simvolite razli4ni ot "."
            
            for (int row = 0; row < num/2; row++)
            {
                int br = 0;
                for (int col = 0; col < num/2; col++)
                {
                    if (start<=col&&col<=end)
                    {
                        mass[row, col] = 2;
                        mass[row, (num - 1)- col]=3;
                        mass[num - 1 - row, col] = 3;
                        mass[num - 1 - row, num - 1 - col] = 2;
                        br++;
                        if (br % 2 == 0)
                        {
                            mass[row, col] = 1;
                            mass[row, (num - 1) - col] = 1;
                            mass[num - 1 - row, col] = 1;
                            mass[num - 1 - row, num - 1 - col] = 1;
                        }
                    } 
                }
                start--;
            }


            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (mass[row,col]==0)
                    {
                        Console.Write(".");
                    }

                    else if (mass[row,col]==1)
                    {
                        Console.Write(" ");
                    }

                    else if (mass[row, col] == 2)
                    {
                        Console.Write("/");
                    }

                    else if (mass[row, col] == 3)
                    {
                        Console.Write("\\");
                    }
                   
                }
                Console.WriteLine(); 
            }
        }
    }
}
