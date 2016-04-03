using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDown_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //DateTime data = new DateTime(year,month,day);
            //data = data.AddDays(1);

            //Console.WriteLine("{0}.{1},{2}",data.Day,data.Month,data.Year);

            Random rand = new Random();
            int a=rand.Next(1, 101);
            int br = 1;
            while (true)
            {
                
                int num;
                Console.Write("vuvedete 4islo "+br+" opit:");
                string str = Console.ReadLine();
                if (!int.TryParse(str,out num))
                {
                    continue;
                }
                num = int.Parse(str);
                if (br==10)
	            {
		             Console.WriteLine("OPITAI PAK :(");
                    break;
	            }
                if (num==a)
                {
                    Console.WriteLine("BRAVO E LUD!!!");
                    break;
                }
                if (num>a)
                {
                    Console.WriteLine("DOWN");
                    br++;
                    continue;
                    
                }
                if (num<a)
                {
                    Console.WriteLine("UP");
                    br++;

                    continue;
                    
                }
                
            }
        }
    }
}
