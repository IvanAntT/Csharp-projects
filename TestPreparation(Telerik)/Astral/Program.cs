using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int a;
            string str = Console.ReadLine();
            while (true)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!(int.TryParse(str[i].ToString(),out a)))
                    {
                        continue;
                    }
                    sum = sum + int.Parse(str[i].ToString());
                }
                
            
                if (str.Length==1)
                {
                    break;
                }
                Console.WriteLine(sum);
                str = sum.ToString();
                sum = 0;
            }
        }
    }
}
