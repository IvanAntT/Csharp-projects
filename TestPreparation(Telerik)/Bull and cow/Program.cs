using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bull_and_cow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOVA E IGRATA BIKOVE I KRAVI TRQBVA DA POZNAESH 4ISLOTO");
            Console.WriteLine("KATO TI SE DAVAT SAMO KOLKO BIKA I KOLKO KRAVI IMA");
            Random ran = new Random();
            int num1=ran.Next(1000, 9999);
            string str = num1.ToString();
            Console.WriteLine(str);
            int bull = 0;
            int cow = 0;
            int bulll = 0;
            int coww = 0;
            while (true)
            {
                Console.Write("MOLQ VUVEDETE CHISLO:");
                string str2 = Console.ReadLine();
                int num2 = int.Parse(str2);
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (int.Parse(str[i].ToString()) == int.Parse(str2[j].ToString()))
                        {
                            if (i == j)
                            {
                                bulll++;
                            }
                            else if (i != j) { coww++; }
                        }
                    }
                    if (bulll > 0 && coww >= 0)
                    {
                        bull++;
                    }
        
                    else if (bulll == 0 && coww > 0)
                    {
                        cow++;
                    }
                    bulll = 0;
                    coww = 0;
                }

                Console.WriteLine("Bull={0}\nCow={1}", bull, cow);
                if (bull==4)
                {
                    Console.WriteLine("BRAVO!!!");
                    break;
                }
                cow = 0;
                bull = 0;
            }

        }
    }
}
