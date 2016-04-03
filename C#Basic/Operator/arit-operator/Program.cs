using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arit_operator
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 4;
            int c = 10;
            int sqP = 17;
            double sqS = sqP / 4.0;
            double sqA = sqS * sqS;
            bool chet = (a % 2 == 0);
            bool nechet = (a % 2 != 0);
            Console.WriteLine("4isloto A 4etno li e ={0}", chet);
            Console.WriteLine("4isloto A ne4etno li e ={0}", nechet);
            Console.WriteLine("stranata na kvadrata e {0}", sqS);
            Console.WriteLine("liceto na kvadrata e {0}", sqA);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b++);              //uveli4avame b sled uravnenieto
            Console.WriteLine(a + b);
            Console.WriteLine(a + (++b));              //uveli4ava se na momenta b
            Console.WriteLine(11.0 / 3);
            Console.WriteLine(11.0 % -3);
            Console.WriteLine(-11.0 % 3);
            Console.WriteLine(1.5 / 0);
            Console.WriteLine(0.0 / 0.0);
            int m = 2000000000;
            long n= 2*(long)m;
            Console.WriteLine(n);
            for (int i = 1; i < 100; i++)
            {
                bool che = (i % 2.0 == 0);
                if (che == true)
                {
                    int y = i;
                    Console.WriteLine("ot 1 do 100 c4etnite 4isla sa {0}", y);
                }
            }
        }
    }
}
