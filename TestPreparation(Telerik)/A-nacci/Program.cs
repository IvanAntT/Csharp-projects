using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char first = str1[0];
            string str2 = Console.ReadLine();
            char second = str2[0];
            int row = int.Parse(Console.ReadLine());
            int firs = first- 64;
            int sec = second - 64;
            int sum = firs + sec;    //sbora na purvoto i vtoroto
            if (sum > 26)
            {
                sum = sum % 26;
            }
            Console.WriteLine((char)(firs+64));
            Console.WriteLine("{0}{1}",(char)(sec+64),(char)(sum+64));

            firs = sec;
            sec = sum;
            for (int i = 2; i < row; i++)
            {
                sum = firs + sec;   //sbora na vtoroto i tretoto
                if (sum>26)
                {
                    sum = sum % 26;
                }
                firs = sec;
                sec = sum;
                sum = firs + sec;  //sbora na tretoto i 4etvurtoto
                if (sum > 26)
                {
                    sum = sum % 26;
                }
                firs = sec;
                sec = sum;
                Console.Write((char)(firs+64));
                Console.Write(new string(' ',i-1));
                Console.Write((char)(sec + 64));
                Console.WriteLine();
            }
        }
    }
}
