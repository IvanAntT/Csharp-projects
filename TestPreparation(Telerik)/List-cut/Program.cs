using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_cut
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string str=Convert.ToString(num,2);
            char[] mass = new char[str.Length];
            mass = str.PadLeft(11,'0').ToCharArray();
            for (int i = mass.Length-1; i >= 0; i--)
            {
                if (mass[i]=='0')
                {
                    Console.WriteLine("A{0}",i);
                }
            }
        }
    }
}
