using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit
{
    public class Kaspi4anNumber
    {
        public static void start()
        {
            List<string> allLetter = new List<string>();
            List<string> tempMass = new List<string>(); 
            string[] bigLetter = new string[26];
            string[] smallLetter = new string[26];
            int index=0;
            for (int i = 65 ;i < 91; i++)
            {
                bigLetter[index] = char.ConvertFromUtf32(i);
                index++;
            }
            index = 0;
            for (int i = 97; i < 123; i++)
            {
                smallLetter[index] = char.ConvertFromUtf32(i);
                allLetter.Add(bigLetter[index]);
                index++;
            }
            int brLetter = 26;

            for (int i = 0; i < smallLetter.Length; i++)
            {
                for (int j = 0; j < bigLetter.Length; j++)
                {
                    allLetter.Add(smallLetter[i] + bigLetter[j]);
                    brLetter++;
                }
            }

            for (int i = 0; i < smallLetter.Length; i++)
            {
                for (int j = 0; j < bigLetter.Length; j++)
                {
                    for (int k = 0; k < smallLetter.Length; k++)
                    {
                        allLetter.Add(smallLetter[i] + bigLetter[j]+smallLetter[k]);
                    }
                }
            }

            Console.WriteLine("Vuvedete 4islo: ");
            int choise = int.Parse(Console.ReadLine());
            if (choise==0)
            {
                Console.WriteLine("A");
            }
            string result = "";
            while (choise!=0)
            {
                result = allLetter[choise % 256] + result;
                choise = choise / 256;
            }
            Console.WriteLine(result);
        }
        
    }
}
