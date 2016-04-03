using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit
{
    public class _9gagnumber
    {
        public static void start()
        {
            string[] massWithNumber = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
            List<int> convertednum = new List<int>();
            string number = Console.ReadLine();
            string temp = "";
            for (int i = 0; i < number.Length; i++)
            {
                temp = temp + number[i];
                if (massWithNumber.Contains(temp))
                {
                    convertednum.Add(Array.FindIndex(massWithNumber, x => x.Contains(temp)));
                    temp = "";
                }
            }
            int result = 0;
            convertednum.Reverse();
            for (int i = 0; i < convertednum.Count; i++)
            {
                result = result + convertednum[i] * MyPow(9, i);
            }
            
            Console.WriteLine(result);
        }

        public static int FromListToInt(List<int> list)
        {
            StringBuilder number=new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                number.Append(list[i]);
            }
            return int.Parse(number.ToString());
        }

        public static int MyPow(int number, int step)
        {
            if (step==0)
            {
                return 1;
            }
            if (step==1)
            {
                return number;
            }
            for (int i = 1; i < step; i++)
            {
                number = number * number;
            }
            return number;
        }
    }
}
