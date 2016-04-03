using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace String
{
    public class zad20
    {
        const string pathfile = "../../zad20.txt";
        public static void ExtractPalidromes()
        {
            StreamReader file = new StreamReader(pathfile);
            List<string> allword = new List<string>();
            using (file)
            {
                string alltext = file.ReadToEnd();
                for (int i = 0; i < alltext.Length; i++)
                {
                    StringBuilder word=new StringBuilder();
                    while (char.IsLetter(alltext[i]))
                    {
                        word=word.Append(alltext[i]);
                        if (i==alltext.Length-1)
                        {
                            break;
                        }
                        i++;
                    }
                    allword.Add(word.ToString());
                }

                foreach (var word in allword)
                {
                    
                    bool palidromes = true;
                    if (word.Length == 0)
                    {
                        palidromes = false;
                    }
                    int letters = 0;
                    int allletters = word.Length;
                    while (letters!=word.Length/2)
                    {
                        if (char.IsLetter(word[letters])==false)
                        {
                            palidromes = false;
                            break;
                        }
                        if (word[letters]!=word[allletters-1])
                        {
                            palidromes = false;
                            break;
                        }
                        letters++;
                        allletters--;
                    }
                    if (palidromes)
                    {
                        Console.WriteLine(word);
                    }

                }
            }
            
        }
        
    }
}
