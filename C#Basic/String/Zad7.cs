using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad7
    {
        public static string Coder(string word)
        {
            Console.WriteLine("Vuvedete kliu4 za kodirane");
            string key = Console.ReadLine();
            StringBuilder codeword = new StringBuilder();
            int lenght=0;
           
            while (word.Length>lenght)
            {
                int keylenght = 0;
                while (keylenght<key.Length)
                {
                    if (lenght == word.Length)
                    {
                        break;
                    }
                    codeword.Append((char)(word[lenght] ^ key[keylenght]));
                    keylenght++;
                    lenght++;
                }
            }
            return codeword.ToString();
        }

        public static string Decoder(string word)
        {
            Console.WriteLine("Vuvedete kliu4 za dekodirane");
            string key = Console.ReadLine();
            StringBuilder decodeword = new StringBuilder();
            int lenght = 0;

            while (word.Length > lenght)
            {
                int keylenght = 0;
                while (keylenght < key.Length)
                {
                    if (lenght == word.Length)
                    {
                        break;
                    }
                    decodeword.Append((char)(word[lenght] ^ key[keylenght]));
                    keylenght++;
                    lenght++;
                }
            }
            return decodeword.ToString();
        }
    }
}
