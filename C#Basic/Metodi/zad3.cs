﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad3
    {
        public static string FromNumToWordLastDigit(int num)
        {
            int last = num % 10;
            string word = "";
            switch (last)
            {
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "tree"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
                default: word = "zero";
                    break;
            }
            return word;
        }
    }
}
