using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSet_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int brnum = int.Parse(Console.ReadLine());
            int[] mass = new int[brnum];
            for (int i = 0; i < brnum; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }

            int varianti=(int)(Math.Pow(2,(double)(brnum)));
            int uspvarinti = 0;
            for (int i = 1; i <varianti ; i++)
            {
                int elsum=0;
                string binary = Convert.ToString(i, 2).PadLeft(brnum,'0');
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j]=='1')
                    {
                        elsum = elsum + mass[j];
                    }
                }
                if (elsum==sum)
                {
                    uspvarinti++;
                }
            }
            Console.WriteLine(uspvarinti);
        }
    }
}
