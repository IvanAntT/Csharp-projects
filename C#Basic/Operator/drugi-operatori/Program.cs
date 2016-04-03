using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugi_operatori
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = (ConsoleColor)((22) % 16); 
            string a = "pesho ";
            string b = "gosho ";
            string c = " priqteli";
            Console.WriteLine(a+b+"sa"+c);
            Console.BackgroundColor = (ConsoleColor)((5) % 16);
            Console.WriteLine("ebahto lilavoto");
            Console.WriteLine(new string('-',40));
            int[] d={1,2,3,4,5};
            Console.WriteLine(d[3]);
            Console.WriteLine(5.ToString());
            Console.WriteLine(int.Parse("1234")+4);
            Console.WriteLine(typeof(Console).Name);
            Console.WriteLine(typeof(int).Name);
            Console.WriteLine(a is int);
            Console.WriteLine(a[0]);              //izpisva purvata bukva ot stringa
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.Length);
            string n = "f";
            int m = 6;
            int k = 15;
            Console.WriteLine(m > k ? "m>k" : "m<k"); //proverqva dali e izpulneno uslovieto ako e izpulneno vru6ta m>k ako ne e m<k
            string i = null;
            string y = "stoqn";
            string z = i ?? "empty";
            Console.WriteLine(z);
            double h = Math.PI;
            double o = Math.Max(10, 7);
            Console.WriteLine(h);
            Console.WriteLine(o);

           
        }
    }
}
