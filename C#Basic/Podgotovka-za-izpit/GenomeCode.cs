using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit
{
    public class GenomeCode
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            string[] param = input.Split(' ');
            int letterOnRow = int.Parse(param[0]);
            int letterBeforeInterval = int.Parse(param[1]);
            string codeText = Console.ReadLine();
            StringBuilder allDecodeText = GenomDecoder(codeText);

            int br = 1;
            int timeToSpace = 1;
            int timeToNewRow = 1;
            if (allDecodeText.Length > 54) { Console.Write(" " + br + " "); }
            else if (allDecodeText.Length < 55) { Console.Write(br + " "); }

            for (int i = 0; i < allDecodeText.Length; i++)
            {
                if (allDecodeText.Length > 54)
                {
                    if (br < 9)
                    {
                        Console.Write(allDecodeText[i]);

                        if (timeToSpace == letterBeforeInterval)
                        {
                            Console.Write(" ");
                            timeToSpace = 0;
                        }
                        if (timeToNewRow == letterOnRow)
                        {
                            Console.WriteLine();
                            timeToNewRow = 0;
                            timeToSpace = 0;
                            br++;
                            Console.Write(" " + br + " ");
                        }
                        timeToSpace++;
                        timeToNewRow++;
                    }
                    else
                    {
                        Console.Write(allDecodeText[i]);

                        if (timeToSpace == letterBeforeInterval)
                        {
                            Console.Write(" ");
                            timeToSpace = 0;
                        }
                        if (timeToNewRow == letterOnRow)
                        {
                            Console.WriteLine();
                            timeToNewRow = 0;
                            timeToSpace = 0;
                            br++;
                            Console.Write(br + " ");
                        }
                        timeToSpace++;
                        timeToNewRow++;
                    }
                }


                else if (allDecodeText.Length < 55)
                {
                    if (allDecodeText[i]==' ')
                    {
                        break;
                    }
                    Console.Write(allDecodeText[i]);

                    if (timeToSpace == letterBeforeInterval)
                    {
                        Console.Write(" ");
                        timeToSpace = 0;
                    }
                    if (timeToNewRow == letterOnRow)
                    {
                        if (i==allDecodeText.Length-1)
                        {
                            break;
                        }
                        Console.WriteLine();
                        timeToNewRow = 0;
                        timeToSpace = 0;
                        br++;
                        Console.Write(br + " ");
                    }
                    timeToSpace++;
                    timeToNewRow++;
                    
                }
            }
            Console.WriteLine();
        }

        private static StringBuilder GenomDecoder(string codeText)
        {
            StringBuilder allDecodeText = new StringBuilder();
            for (int i = 0; i < codeText.Length; i++)
            {
                if (codeText[i]=='A'||codeText[i]=='C'||codeText[i]=='G'||codeText[i]=='T')
                {
                    if (char.IsDigit(codeText[i-1]))
                    {
                        int count;
                        if (char.IsDigit(codeText[i-2]))
                        {
                             count = int.Parse(codeText[i - 2].ToString() + codeText[i - 1].ToString());
                        }
                        else
                        {
                             count = int.Parse(codeText[i - 1].ToString());
                        }
                        for (int time = 0; time < count; time++)
                        {
                            allDecodeText.Append(codeText[i]);
                        }
                    }
                    else
                    {
                        allDecodeText.Append(codeText[i]);
                    }
                }
            }
            return allDecodeText;
        }
    }
}
