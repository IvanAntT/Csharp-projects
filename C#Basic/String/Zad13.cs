using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad13
    {
        public static void ReverseSentences(string sentence)
        {
            StringBuilder finalsentence = new StringBuilder();
            string[] masswithword = sentence.Split(' ', ',','!','?','.');
            Array.Reverse(masswithword);
            for (int i = 1; i < masswithword.Length; i++)
            {
                finalsentence.Append(masswithword[i]);
                if (i==masswithword.Length-1)
                {
                    break;
                }
                finalsentence.Append(' ');
            }
	           
            if (sentence.Contains('!'))
            {
                finalsentence.Append('!');
            }
            else if (sentence.Contains('?'))
            {
                finalsentence.Append('?');
            }
            else if (sentence.Contains('.'))
            {
                finalsentence.Append('.');
            }
            Console.WriteLine(finalsentence.ToString()); 
        }
    }
}
