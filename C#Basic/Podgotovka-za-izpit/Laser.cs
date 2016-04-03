using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Podgotovka_za_izpit
{
    public class Laser
    {
        public static void start()
        {
            if (File.Exists("../../LaserInput.txt"))
            {
                Console.SetIn(new StreamReader("../../LaserInput.txt"));
            }
            List<string> allpath = new List<string>();
            int[] figureSize = FromConsoleToMass();
            int[] startIndexToLaser = FromConsoleToMass();
            int[] directions = FromConsoleToMass();
            int[] masswithsum = new int[3];
            Array.Copy(startIndexToLaser, masswithsum, startIndexToLaser.Length);
            bool end = false ;
            while (true)
            {
                int f = masswithsum[0];
                int s = masswithsum[1];
                int t = masswithsum[2];
                for (int i = 0; i < 3; i++)
                {
                    if (figureSize[i] <= masswithsum[i])
                    {
                        end = true;
                        masswithsum[i] = figureSize[i];
                    }
                    else if (masswithsum[i] < 2) { end = false; masswithsum[i] = 1; }
                    if (end)
                    {
                        masswithsum[i] = masswithsum[i] - directions[i];
                    }
                    else if (end == false) 
                    {
                        masswithsum[i] = masswithsum[i] + directions[i]; 
                    }
                }
                if (Search(allpath,masswithsum))
                {
                    Console.WriteLine("{0} {1} {2}", f, s, t);
                    break;
                }
                if (masswithsum[0]==masswithsum[1]||masswithsum[1]==masswithsum[2]||
                    masswithsum[0]==masswithsum[2]||
                   (masswithsum[0]==masswithsum[1]&&masswithsum[1]==masswithsum[2]))
                {
                    Console.WriteLine("{0} {1} {2}", f, s, t);
                    break;
                }
                if (Enumerable.SequenceEqual(masswithsum, startIndexToLaser))
                {
                    Console.WriteLine("{0} {1} {2}", f, s, t);
                    break;
                }
                allpath = Add(allpath, masswithsum);
            }
        }

        public static int[] FromConsoleToMass()
        {
            string textOnConsole = Console.ReadLine();
            string[] massWithElement = textOnConsole.Split(' ');
            int[] massWithElementInt=new int[3]; 
            for (int i = 0; i <massWithElement.Length; i++)
            {
                massWithElementInt[i] = int.Parse(massWithElement[i]);
            }
            return massWithElementInt;
        }

        public static List<string> Add(List<string> list,int[] mass) 
        {
            StringBuilder data=new StringBuilder();
            for (int i = 0; i < mass.Length; i++)
            {
                data.Append(mass[i]);
            }
            list.Add(data.ToString());
            return list;
        }

        public static bool Search(List<string> list, int[] mass)
        {
            StringBuilder Searchdata = new StringBuilder();
            for (int i = 0; i < mass.Length; i++)
            {
                Searchdata.Append(mass[i]);
            }
            bool answer=list.Contains(Searchdata.ToString());
            return answer;
        }
    }
}
