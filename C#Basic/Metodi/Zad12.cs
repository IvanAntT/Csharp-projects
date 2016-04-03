using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    class Zad12
    {
        public static void start()
        {
            int input = 4;
            string inpu = "-";
            while (inpu!="")
            {
                Console.WriteLine("Vuvedete 4isloto na va6iq izbor:");
                Console.WriteLine("1.Razmesti 4islata na masiv.");
                Console.WriteLine("2.Srednata stoinost na dadeni 4isla ot masiv.");
                Console.WriteLine("3.Reshete uravnenieto.");
                Console.WriteLine("0.Za izhod");
                inpu = Console.ReadLine();
                if (inpu == "") { break; }
                input = int.Parse(inpu);
                switch (input)
                {
                    case 1: Razmesti(); break;
                    case 2: AverageArray(); break;
                    case 3: LinearEquation(); break;
                    default : return;
                }
            }
        }

        public static List<int> ArrayCreator()
        {
            string number = "-";
            List<int> mass = new List<int>();
            int br = 1;
            while (number != "")
            {
                Console.WriteLine("Vuvedete {0} 4islo", br);
                number = Console.ReadLine();
                if (number == "") { break; }
                int digit = int.Parse(number);
                mass.Add(digit);
                br++;
            }
            return mass;
        }

        public static void Razmesti()
        {
            List<int> mass = ArrayCreator();
            mass.Reverse();
            Console.WriteLine("Sled razmestvaneto 4islata ot masiva izglejdat taka:");
            foreach (var item in mass)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',30));
        }

        public static void AverageArray()
        {
            List<int> mass = ArrayCreator();
            Console.WriteLine(mass.Average());
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
        }

        public static void LinearEquation()
        {
            Console.WriteLine("Vuvedete uravnenieto:");
            string equation = Console.ReadLine();
            char[] finEqual=equation.ToCharArray();
            Console.Write("a=");
            string Anum = Console.ReadLine();
            while(Anum=="0") 
            {
                Console.WriteLine("nevalidna stoinosti");
                Console.Write("a=");
                Anum = Console.ReadLine();
            }
            double a=double.Parse(Anum);
            Console.Write("b=");
            string Bnum = Console.ReadLine();
            while(Bnum.Contains('.')) 
            {
                Console.WriteLine("nevalidna stoinosti");
                Console.Write("b=");
                Bnum = Console.ReadLine();
            }
            double b= double.Parse(Bnum);
                double x = ((-b) / a);
                Console.WriteLine("re6enieto na uravnenieto e:\nx={0}",x);
        }


    }
}
