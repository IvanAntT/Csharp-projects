using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad13
    {
        public static List<int> ArrayCreator()
        {
            List<int> array = new List<int>();
            string number = "-";
            Console.WriteLine("vuvedete 4islata na masiva:");
            while (number!="")
            {
                number = Console.ReadLine();
                if (number == "") { break; }
                int num = int.Parse(number);
                array.Add(num);
            }
            return array;
        }

        public static void Start()
        {
            string choice = "-";
            while (choice!="")
            {
                Console.WriteLine("1.Min");
                Console.WriteLine("2.Max");
                Console.WriteLine("3.Average");
                Console.WriteLine("4.Sum");
                Console.WriteLine("5.Product");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Vuvedete va6iq izbor");
                choice = Console.ReadLine();
                if (choice == "") { break; }
                int ch = int.Parse(choice);
                switch (ch)
                {
                    case 1: Min(); break;
                    case 2: Max(); break;
                    case 3: Average();break;
                    case 4: Sum(); break;
                    case 5: Product(); break;
                    case 0: return;
                    default:
                        break;
                }
            }
        }

        public static void Average()
        {
            List<int> ArrayAvg = ArrayCreator();
            double avg = ArrayAvg.Average();
            Console.WriteLine("srednata stoinost na masiva e {0}",avg);
        }

        public static void Min()
        {
            List<int> ArrayMin = ArrayCreator();
            int min = ArrayMin.Min();
            Console.WriteLine("nai-malkata stoinost na masiva e {0}", min);
        }

        public static void Max()
        {
            List<int> ArrayMax = ArrayCreator();
            int max = ArrayMax.Max();
            Console.WriteLine("nai-golqmata stoinost na masiva e {0}", max);
        }

        public static void Sum()
        {
            List<int> ArraySum = ArrayCreator();
            int sum = ArraySum.Sum();
            Console.WriteLine("sumata ot stoinostite na masiva e {0}", sum);
        }

        public static void Product()
        {
            List<int> ArrayProduct = ArrayCreator();
            int product = 1;
            for (int i = 0; i < ArrayProduct.Count; i++)
            {
                product = product * ArrayProduct[i];
            }
            Console.WriteLine("sumata ot stoinostite na masiva e {0}", product);
        }
    }
}
