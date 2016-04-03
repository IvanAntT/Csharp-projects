using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String
{
    public class zad19
    {
        const string inputfilepath = "../../zad19.txt";
        public static void ExtractDateFormat()
        {
            StreamReader file = new StreamReader(inputfilepath);
            using (file)
            {
                string alltext = file.ReadToEnd();
                List<string> alldates = new List<string>();
                int indexofdot = alltext.IndexOf(".", 0);
                for (int i = 0; i < alltext.Length; i++)
                {
                    string str = "";
                    if (char.IsDigit(alltext[i]))
                    {
                        while (alltext[i]!=' ')
                        {
                            str = str + alltext[i];
                            i++;
                        }
                        if (str.Contains('.'))
                        {
                            str = str.Trim('.', ',', '!', '?');
                            alldates.Add(str);
                        }
                    }
                }
                FromEuropeanToCanadian(alldates);
            }
        }

        public static void FromEuropeanToCanadian(List<string> listofdates)
        {
            Console.WriteLine("Prezentirani po Canadskiq na4in datite izglejdat taka:");
            foreach (var dates in listofdates)
            {
                string[] daysindate=new string[3];
                daysindate=dates.Split('.');
                Console.WriteLine("{0}.{1}.{2}",daysindate[2], daysindate[1], daysindate[0]);
            }
        }
    }
}
