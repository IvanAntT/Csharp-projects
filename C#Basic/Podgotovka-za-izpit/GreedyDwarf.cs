using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit
{
    public class GreedyDwarf
    {
        public static void InsertData()
        {
            Console.WriteLine("Insert Dwarf");
            string valley = Console.ReadLine();
            StringBuilder va = new StringBuilder();
            for (int i = 0; i < valley.Length; i++)
            {
                if (char.IsDigit(valley,i)||valley[i]==','||valley[i]=='-')
                {
                    va.Append(valley[i]);
                }
            }
            valley = va.ToString();
            string[] valleymass=valley.Split(',');
            Console.WriteLine("Insert how many patern you will insert");
            int numberofpatern = int.Parse(Console.ReadLine());
            //string[] masswithpatern = new string[numberofpatern];
            
            int numberpatern = 0;
            int bigsum = 0;
            while (numberofpatern!=numberpatern)
            {
                Console.WriteLine("Insert {0} Patern",numberpatern+1);
                string patern = Console.ReadLine();
                int currentsum = SumPatern(valleymass, patern);
                if (bigsum<currentsum)
                {
                    bigsum = currentsum;
                }
                numberpatern++;
            }
            Console.WriteLine(bigsum);
        }

        static int SumPatern(string[] valleymasss, string patern)
        {
            int pos = 0;
            int posPatern =0;
            string[] valleymass=new string[valleymasss.Length];
            Array.Copy(valleymasss, valleymass,valleymasss.Length);
            int sum = int.Parse(valleymass[0]);
            StringBuilder pater=new StringBuilder();
            for (int i = 0; i < patern.Length; i++)
            {
                if (char.IsDigit(patern,i)||patern[i]==','||patern[i]=='-')
                {
                    pater.Append(patern[i]);
                }
            }
            patern = pater.ToString();
            string[] paternElement = patern.Split(',');
            while (true)
            {
                pos = pos + int.Parse(paternElement[posPatern]);
                if (pos>valleymass.Length-1)
                {
                    break;
                }
                if (valleymass[pos] == "")
                {
                    break;
                }
                sum = sum + int.Parse(valleymass[pos]);
                valleymass[pos] = "";
                posPatern++;
                if (posPatern==paternElement.Length)
                {
                    posPatern = 0;
                }
            }
            return sum;
        }

    }
}
