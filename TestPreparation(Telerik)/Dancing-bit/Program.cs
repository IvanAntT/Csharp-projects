using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dancing_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            string all = "";
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string str=Convert.ToString(num,2);
                all = all + str;
            }
            Console.WriteLine(all);
            int brall = 0;
            int br1 = 0;
            int br0 = 0;
            int br = 0;
            int b = 0;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i]=='1')
                {
                    br++;
                    br0 = b;
                    b = 0;
                    if (i==all.Length-1)
                    {
                        br1 = br;
                    }
                }
                else if (all[i] == '0' )
                {
                    b++;
                    br1 = br;
                    br = 0;
                    if (i==all.Length-1)
                    {
                        br0 = b;
                    }
                }
                if (K==br1||K==br0)
                {
                    brall++;
                    br1 = 0;
                    br0 = 0;
                }
            }
            Console.WriteLine(brall);
            
        }
    }
}
