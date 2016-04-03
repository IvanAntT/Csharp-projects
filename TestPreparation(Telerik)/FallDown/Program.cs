using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("n0=");
            int n0 = int.Parse(Console.ReadLine()); //vsqko 4islo e red;
            Console.Write("n1=");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("n2=");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("n3=");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("n4=");
            int n4 = int.Parse(Console.ReadLine());
            Console.Write("n5=");
            int n5 = int.Parse(Console.ReadLine());
            Console.Write("n6=");
            int n6 = int.Parse(Console.ReadLine());
            Console.Write("n7=");
            int n7 = int.Parse(Console.ReadLine());
           
            //solution
            for (int j = 0; j < 8; j++)
            {
            for (int i = 0; i < 8; i++) // 4isloto se razdelq na 8 kletki kato v 
                                        // v binaren kod i se obhojda vsqka kletka
            {
                    if ((n7 >> i & 1) == 0 &&//dali kato izmestim n7 s i pozicii 4isloto e 0
                        (n6 >> i & 1) == 1) //dali kato izmestim n6 s i pozicii 4isloto e 1 
                    {
                        n7 = n7 | (1 << i);
                        n6 = n6 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n6 >> i & 1) == 0 &&
                         (n5 >> i & 1) == 1)
                    {
                        n6 = n6 | (1 << i);
                        n5 = n5 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n5 >> i & 1) == 0 &&
                         (n4 >> i & 1) == 1)
                    {
                        n5 = n5 | (1 << i);
                        n4 = n4 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n4 >> i & 1) == 0 &&
                         (n3 >> i & 1) == 1)
                    {
                        n4 = n4 | (1 << i);
                        n3 = n3 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n3 >> i & 1) == 0 &&
                         (n2 >> i & 1) == 1)
                    {
                        n3 = n3 | (1 << i);
                        n2 = n2 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n2 >> i & 1) == 0 &&
                         (n1 >> i & 1) == 1)
                    {
                        n2 = n2 | (1 << i);
                        n1 = n1 ^ (1 << i);
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                    if ((n1 >> i & 1) == 0 &&
                         (n0 >> i & 1) == 1)
                    {
                        n1 = n1 | (1 << i);
                        n0 = n0 ^ (1 << i);
                    }
            }
            
           }
            
            
            //OutPut
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            
         
        }
    }
}
