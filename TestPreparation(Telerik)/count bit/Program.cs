using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            char B = char.Parse(Console.ReadLine());

            int num = int.Parse(Console.ReadLine());
            string str = Convert.ToString(num, 2);
            char[] mass = str.ToCharArray();
            int br = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]==B)
                {
                    br++;
                }
            }
            Console.WriteLine(br);
        }
    }
}
