using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace String
{
    public class Zad18
    {
        const string FILEPATH = "../../zad18.txt";
        public static void ExtractEmailFromText()
        {
            StreamReader file = new StreamReader(FILEPATH);
            List<string> allemails = new List<string>();
            using (file)
            {
                string alltext = file.ReadToEnd();
                int index = alltext.IndexOf("@", 0);
                while (index>0)
                {
                    allemails.Add(Email(index, alltext));
                    index = alltext.IndexOf("@", index+1);
                   // em = Email(index, alltext);
                  
                }
                int numberofemail = 1;
                foreach (var email in allemails)
                {
                    string trimem = email.Trim('.', ',', '!', '?', ':');
                    Console.WriteLine("{0} email is {1}",numberofemail,trimem);
                    numberofemail++;
                }

            }
        }

        public static string Email(int index,string text)
        {
            StringBuilder email = new StringBuilder();
            StringBuilder emailafter = new StringBuilder();
            string emailbefore="";
            int indexafter = index;
            while (true)
            {
                if (text[indexafter].Equals(' '))
                {
                       break;
                }
                emailafter.Append(text[indexafter]);
                indexafter++;
                if (indexafter == text.Length)
                {
                    break;
                }
            }
            int indexbef = index;
            while (true)
            {
                indexbef--;
                if (text[indexbef].Equals(' ') || indexafter < 0)
                {
                    break;
                }
                emailbefore = emailbefore + text[indexbef];
            }
            char[] embef = emailbefore.ToCharArray();
            Array.Reverse(embef);
            email.Append(embef);
            email.Append(emailafter);
            return email.ToString();
        }
    }
}
