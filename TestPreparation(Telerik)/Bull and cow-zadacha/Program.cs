using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bull_and_cow_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = Console.ReadLine();
            string num1= "1234";
           // int num1 = int.Parse(num);
           // int bull = int.Parse(Console.ReadLine());
            int bull=3;
            //int cow = int.Parse(Console.ReadLine());
            int cow = 0;
            char[] gnum;
            char znak='*';
            char znak1 = '-';

            List<int> list = new List<int>();
            for (int guessNum = 1001; guessNum < 9999; guessNum++)
            {
                int brbull = 0;
                int brcow = 0;
                gnum=guessNum.ToString().ToCharArray();
                char[] num = num1.ToString().ToCharArray();
                for (int i = 0; i < gnum.Length; i++)
                {
	                
                    //if (in t.Parse(num[i].ToString())==int.Parse(gnum[i].ToString()))
                    if (gnum[i]==num[i])
                    { 
                        brbull++;
                        gnum[i] = znak;
                        num[i]=znak1;
                    }
                }

                for (int i = 0; i < num.Length; i++)
                {
                     for (int j = 0; j < num.Length; j++)
                    {
                       // if (int.Parse(num[i].ToString()) == int.Parse(gnum[j].ToString()))
                        if (num[i]==gnum[j])
                        {
                            brcow++;
                            gnum[j] = znak;
                            num[i] = znak1;
                        }
                    }
                }
                if (brcow == cow && brbull == bull)
                {
                    list.Add(guessNum);
                }
            }
            
            if (list.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (list.Count>0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                       
                        if (i%5==0&&i!=0)
                        {
                            Console.WriteLine();
                        }
                        Console.Write(list[i] + " ");
                }
            }

        }
    }
}
