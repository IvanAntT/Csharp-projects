using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbergame = int.Parse(Console.ReadLine());
            int global1 = 0;
            int global2 = 0;
            int pobedip1 = 0;
            int pobedip2 = 0;
            bool xp1 = false;
            bool xp2 = false;

            for (int i = 0; i < numbergame; i++)
            {
                int localp1 = 0;
                int localp2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": localp1 = localp1 + 1; break;
                        case "K": localp1 = localp1 + 13; break;
                        case "Q": localp1 = localp1 + 12; break;
                        case "J": localp1 = localp1 + 11; break;
                        case "X": xp1=true; break;
                        case "Y": global1=global1 -200; break;
                        case "Z": global1=global1*2; break;
                        default: localp1=localp1+(12-int.Parse(card));
                            break;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": localp2 = localp2 + 1; break;
                        case "K": localp2 = localp2 + 13; break;
                        case "Q": localp2 = localp2 + 12; break;
                        case "J": localp2 = localp2 + 11; break;
                        case "X": xp1 = true; break;
                        case "Y": global2 = global2 - 200; break;
                        case "Z": global2 = global2 * 2; break;
                        default: localp2 = localp2 + (12 - int.Parse(card));
                            break;
                    }
                }
                if (xp1&&xp2)
                {
                    global1 += 50;
                    global2 += 50;
                }

                else if (xp1)
                {
                    Console.WriteLine("X card drawn");
                    Console.WriteLine("Player 1 win the match!");
                    return;
                }

                else if (xp2)
                {
                    Console.WriteLine("X card drawn");
                    Console.WriteLine("Player 2 win the match!");
                    return;
                }
                if (localp1>localp2)
                {
                    global1 = global1 + localp1;
                    pobedip1=pobedip1 + 1;
                }
                else if (localp1<localp2)
                {
                    global2 = global2 + localp2;
                    pobedip2 = pobedip2 + 1;
                }
            }
            if (global1>global2)
            {
                Console.WriteLine("Player 1 win");
                Console.WriteLine("Score: {0}",global1);
                Console.WriteLine("Games won: {0}",pobedip1);
            }

            else if (global1 < global2)
            {
                Console.WriteLine("Player 2 win");
                Console.WriteLine("Score: {0}", global2);
                Console.WriteLine("Games won: {0}", pobedip2);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}",global1);
            }
        }
    }
}
