using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neutron
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str!="-1")
            {
                uint num = uint.Parse(str);
                char[] ca = Convert.ToString(num, 2).PadLeft(32,'0').ToCharArray();
                bool akoEedno = false;
                bool akoEnula = false;
                bool vutre = false;
                Console.WriteLine(new string(ca, 0, 32));
                int br = 0;
                for (int i = 0; i < ca.Length; i++)
                {
                    if (ca[i]=='1')
                    {
                        ca[i] = '0';
                        akoEedno = true;

                        if (akoEnula && vutre)
                        {
                            vutre = false;
                            akoEedno = false;
                            br = 1;
                        }
                        akoEnula = false;
                    }
                    else if (ca[i]=='0')
                    {
                        akoEnula = true;
                        if (akoEedno)
                        {
                            if (br == 1)
                            {
                                vutre = false;
                                akoEedno = false;
                            }
                            else
                            {
                                ca[i] = '1';
                                vutre = true;
                            }
                        }
                    }
                }
                if (vutre == true)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    string re = "";
                    for (int i = 0; i < ca.Length; i++)
                    {
                        re = re + ca[i];
                    }
                    Console.WriteLine(re);
                    UInt32 rez = Convert.ToUInt32(re, 2);
                    Console.WriteLine(rez);
                }
                str = Console.ReadLine();
            }
        }
    }
}
