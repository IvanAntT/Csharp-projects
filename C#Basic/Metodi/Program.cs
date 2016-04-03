using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Metodi
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Print();      ZAD 1
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c=");
            //int c = int.Parse(Console.ReadLine());
            //int maxAandB = Zad2.GetMax(a, b);
            //int max = Zad2.GetMax(maxAandB, c);
            //Console.WriteLine(max);     ZAD 2
            //Console.Write("Imput your number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Zad3.FromNumToWordLastDigit(number));  ZAD 3
            //Console.Write("Vubedete tursenoto 4islo: ");
            //int numberTosearch=int.Parse(Console.ReadLine());
            //int[] mass ={2,3,3,4,2,2,5,1,2,2,3,4};
            //Console.WriteLine(Zad4.HowManyTimeAppearDigit(mass,numberTosearch));   ZAD 4
            //Console.Write("Vubedete tursenata poziciq: ");
            //int searchposition = int.Parse(Console.ReadLine());
            //int[] mass = { 2, 3, 10, 3, 2, 2, 5, 1, 2, 2, 3, 4 };
            //if (searchposition<2||searchposition>mass.Length-1)
            //{
            //    Console.WriteLine("nqma susedi");
            //}
            //else if (Zad5.BiggerThanNeighbours(mass,searchposition))
            //{
            //    Console.WriteLine("4isloto e po-golqmo ot susedite si");
            //}
            //else
            //{
            //    Console.WriteLine("4isloto ne e po golqmo ot susedite si");
            //}     ZAD 5
            //Console.WriteLine("4isloto koeto e po golqmo ot susedite si e na pos {0}",Zad6.IndexOfTheFirstDigitBiggerThanNeighbour(mass));  ZAD 6
            //Console.Write("Vuvedete 4islo= ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Zad7.ConvertNumber(num));  ZAD7
            //int[] mass1 = { 1, 3, 4, 5, 1, 2,6,9,1,4,2,7,9 };
            //int[] mass2 = { 3, 4, 1, 7, 8, 9, 9 ,3,1,5,6,1,3,4};
            //Console.WriteLine(Zad8.SumTwoInteger(mass1,mass2));  ZAD8
            //int[] mass1 = {2,3,4,1,7,1,9,3,4,1,5,7,6};
            //Zad9.SortedArray(mass1).CopyTo(mass1,0);
            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(mass1[i]);
            //}   ZAD 9
            //BigInteger faktoriel = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    faktoriel = Zad10.Faktoriel(i);
            //    Console.WriteLine("Faktoriel ot {0} e = {1}",i,faktoriel);
            //}
            //string urav = "2X^3+5X^1";
            //string urav2 = "2X^3+4X^2+2X^0";
            //int[] Addrezmass = new int[4];
            //int[] Decrezmass = new int[4];
            //int[] Mulrezmass = new int[4];
            //Zad11.AddsPolynoms(Zad11.FromPolyToArray(urav), Zad11.FromPolyToArray(urav2)).CopyTo(Addrezmass, 0);
            //Zad11.DecPolynoms(Zad11.FromPolyToArray(urav), Zad11.FromPolyToArray(urav2)).CopyTo(Decrezmass, 0);
            //Zad11.MulPolynoms(Zad11.FromPolyToArray(urav), Zad11.FromPolyToArray(urav2)).CopyTo(Mulrezmass, 0);
            //Console.WriteLine(urav);
            //Console.WriteLine("+");
            //Console.WriteLine(urav2);
            //Console.WriteLine(new string('-', 30));
            //for (int i = 0; i < Addrezmass.Length; i++)
            //{
            //    Console.WriteLine("X^{0}={1}", i, Addrezmass[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(urav);
            //Console.WriteLine("-");
            //Console.WriteLine(urav2);
            //Console.WriteLine(new string('-', 30));
            //for (int i = 0; i < Decrezmass.Length; i++)
            //{
            //    Console.WriteLine("X^{0}={1}", i, Decrezmass[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(urav);
            //Console.WriteLine("*");
            //Console.WriteLine(urav2);
            //Console.WriteLine(new string('-', 30));
            //for (int i = 0; i < Mulrezmass.Length; i++)
            //{
            //    Console.WriteLine("X^{0}={1}", i, Mulrezmass[i]);
            //}
            //Zad12.start();     ZAD 12
            object s = 2;
            object c = 3.4;
            object d = "fasd";
            object z = 'a';
            List<object> mass = new List<object>();
            mass.Add(s);
            mass.Add(c);
            mass.Add(d);
            mass.Add(z);
            Console.WriteLine(mass.GetType());
            for (int i = 0; i < mass.Count; i++)
            {
                Console.WriteLine(mass[i].GetType());
            }

            
        }

        static void Print() 
        {
            Console.Write("What's your name sir: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);
        }

    }
}
