using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ZADA4A 1");
            int b = 10;
            int c = 12;
            if (c%2==0&&c==12)
            {
                Console.WriteLine("za "+c+" uslovieto e izpulneno");
            }
            else 
            {
            Console.WriteLine("uslovieto ne e izpulneno");
        }
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 2");
            for (int i = 1; i < 100; i++)
            {
                bool y = (i % 7 == 0 && i % 5 == 0);
                if (y)
                {
                    Console.WriteLine("4islata koito se delqt ednovremenno na 5 i 7 sa {0}",i); 
                }
            }
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 3");
            double weidth = 3.22;
            double height = 5.55;
            double area = weidth * height;
            Console.WriteLine("liceto na pravougulnika e {0}",area);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("ZADA4A 4");
            int[] l = { 1, 7, 3, 2 };
            bool q = (l[1] == 7);
            Console.WriteLine("za 4isloto 1732 ima slednite vuprosi");
            Console.WriteLine("tretata cifra ot dqsno na lqvo 7 li e {0}",q);
            string li = "1732";
            Console.WriteLine("tretata cifra ot dqsno na lqvo e {0}",li[1]);
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 5");
            int[] bi = {1,0,1,0,1,0,1};
            bool bip = (bi[2] == 0);
            bool bin = (bi[2] != 0);
            Console.WriteLine("za 4isloto 1010101:");
            Console.WriteLine("tretoto 4islo 0 li e {0}\ntretoto 4islo 1 li e {1}",bip,bin);
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 6");
            int x=3;
            int z=6;
            bool vutre=(x<=5&&z<=5);
            if (vutre){Console.WriteLine("to4kata e vutre");}
            else Console.WriteLine("to4kata ne e vutre");
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 7");
            object ki = 37.4;
            Console.WriteLine("stoinostta na ki e {0}",ki.GetType());
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 8");
            int trapA=4;
            int trapB=5;
            int trapH=6;
            double trapArea = (double)(trapA + trapB) / 2 * trapH;
            Console.WriteLine("liceto na trapeca e {0}",trapArea);
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 9");
            int X=-2;
            int Y=4;
            bool Xkrug = (X >= -2 && X <= 4);
            bool Ykrug = (Y >= -2 && Y <= 4);
            bool Xprav = (X >= -1 && X <= 5);
            bool Yprav = (Y >= -1 && Y <= 1);
            if (Xkrug == true && Ykrug == true && Xprav == false && Yprav == false)
            {
                Console.WriteLine("To4kata e vutre v kvadrata i izvun pravougulnika");
            }
            else { Console.WriteLine("to4kata NE e vutre v kruga i vun ot pravougulnika"); }

            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 10");
            int pos=5;
            int st=5;
            int[] chis = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            bool nam = (chis[pos] == st);
            if (nam == true)
            {
                Console.WriteLine("0, 1, 2, 3, 4, 5, 6, 7, 8");
                Console.WriteLine("4isloto na {0} pos e {1}", pos+1, st);
            }

            else
            {
                Console.WriteLine("0, 1, 2, 3, 4, 5, 6, 7, 8"); 
                Console.WriteLine("4isloto {0} ne e na pos {1}",st,pos+1); }
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 11");
            int brbit = 3;
            int cchislo=20;
            Console.WriteLine(Convert.ToString(cchislo, 2).PadLeft(1, '0'));
            cchislo = cchislo >> brbit;
            Console.WriteLine("sled izmestvaneto s {0} pozicii polu4iloto se 4islo e {1}",brbit,Convert.ToString(cchislo, 2).PadLeft(1, '0'));
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 12");
            int p = 4;
            int vv=1;
            int nn = 35;
            int mask = vv << p;
            int result = nn|mask;
            Console.WriteLine("sled kato e dobavena {0} na {1} poziciq ot 4isloto :",vv,p);
            Console.WriteLine(Convert.ToString(nn,2).PadLeft(1,'0'));
            Console.WriteLine("se polu4ava 4isloto :");
            Console.WriteLine(Convert.ToString(result,2).PadLeft(1,'0'));
            Console.WriteLine(new string('-',40));
            Console.WriteLine("ZADA4A 13");

            uint n = 35;
        Console.WriteLine("Binary representation of your number is: \n{0}", Convert.ToString(n, 2));
     for (int p1 = 3; p1 < 6; p1++) //bits of position 3, 4, 5
     {
         int p2 = p1 + 21;  //bits of position 24, 25, 26 
         //chacking which bits stay of this positions 0 or 1
         uint mask1 = (uint)(1 << p1);
         uint mask2 = (uint)(1 << p2);
         uint bit1 = (n & mask1);
         uint bit2 = (n & mask2);
         //bit of position p1 goes to bit of position p2
         if (bit1 == 0)
         {
             uint replacer = (uint)(1 << p2);
             n = (n & ~replacer);
         }
         else
         {
             uint replacer = (uint)(1 << p2);
             n = (n | replacer);
         }
         //bit of position p1 goes to bit of position p2
         if (bit2 == 0)
         {
             uint replacer = (uint)(1 << p1);
             n = (n & ~replacer);
         }
         else
         {
             uint replacer = (uint)(1 << p1);
             n = (n | replacer);
         }
     }
        Console.WriteLine("Binary representation of modifed number is: \n{0}", Convert.ToString(n, 2));
        Console.WriteLine("The number after bit changes (3, 4, 5 <=> 24, 25, 26) is: \n{0}", n);

        }
    }
}
