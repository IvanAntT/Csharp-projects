using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miss_cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko sudii 6te glasuvat:");
            int juri = int.Parse(Console.ReadLine());
            int[] cat = new int[10];
            for (int i = 0; i < juri; i++)
            {
                Console.Write("sudiq "+(i+1)+" glasuva za kotka N:");
                int vot = int.Parse(Console.ReadLine());
                cat[vot]++;
            }

            for (int i = 0; i < cat.Length; i++)
            {
                if (cat[i] == cat.Max())
                {
                    Console.WriteLine("pobeditelka e kotka N:" + i);
                }
            }

            
        }
    }
}
