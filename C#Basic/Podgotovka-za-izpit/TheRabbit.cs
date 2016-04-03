using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit
{
    public class TheRabbit
    {
        public static void start()
        {
            Console.WriteLine("Vuvedete putq na zaeka");
            string path = Console.ReadLine();
            int maxbr = 1;
            int curstep = 0;
            int curnum = 0;
            string[] masswithnumberofpath = path.Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < masswithnumberofpath.Length; i++)
            {
                //int curbr = 0;
                for (int j = 1; j < masswithnumberofpath.Length; j++)
                {
                    int curbr = 1;
                    int next = i + j;
                    curnum = i;
                    if (next >= masswithnumberofpath.Length)
                    {
                        next = next - masswithnumberofpath.Length;
                    }
                    while (int.Parse(masswithnumberofpath[curnum])<int.Parse(masswithnumberofpath[next]))
                    {
                        curbr++;
                        if (maxbr<curbr)
                        {
                            maxbr = curbr;
                            curstep = j;
                        }
                        if (int.Parse(masswithnumberofpath[curnum])==int.Parse(masswithnumberofpath[next]))
                        {
                            break;
                        }
                        curnum = next;
                        next = curnum + j;
                        if (curnum>=masswithnumberofpath.Length)
                        {
                            curnum = curnum - masswithnumberofpath.Length;
                        }
                        if (next>=masswithnumberofpath.Length)
                        {
                            next = next - masswithnumberofpath.Length;
                        }
                    }
                }
            }
            Console.WriteLine("Lenght={0} , step ={1}",maxbr,curstep);
        }
    }
}
