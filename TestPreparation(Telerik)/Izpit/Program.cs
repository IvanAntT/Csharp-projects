using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint A = uint.Parse(Console.ReadLine());
            //uint B = uint.Parse(Console.ReadLine());
            //uint C = uint.Parse(Console.ReadLine());
            //uint R = 0;
            //uint krai = 0;

            //switch (B)
            //{
            //    case 2: R = A % C; break;
            //    case 4: R = A + C; break;
            //    case 8: R = A * C; break;
            //    default: return;
            //}

            //if (R % 4 == 0)
            //{
            //    if (R==0)
            //    {
            //        krai=0;
            //    }
            //    else
            //    {
            //        krai = R / 4;

            //    }
            //}
            //else { krai = R % 4; }

            //Console.WriteLine(krai);
            //Console.WriteLine(R);

            //Console.WriteLine(new string('-', 32));
            //Console.WriteLine("ZADA4A 2");
            //string num = Console.ReadLine();
            //int sum = 0;
            //int br = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum = sum + int.Parse(num[i].ToString());
            //        br++;
            //    }
            //}
            //Console.WriteLine("{0} {1}", br, sum);
            //Console.WriteLine(new string('-', 32));
//            Console.WriteLine("ZADA4A 3");
            //string urav = Console.ReadLine();

            //string[] mass = new string[urav.Length];
            //for (int i = 0; i < urav.Length - 1; i++)
            //{
            //    mass[i] = urav[i].ToString();
            //}

            //int sum = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    int sum2 = 0;
            //    if (mass[i] == "(")
            //    {
            //        while (mass[i] != ")")
            //        {
            //            i++;
            //            if (mass[i] == "+")
            //            {
            //                sum = sum + int.Parse(mass[i - 1].ToString()) + int.Parse(mass[i + 1].ToString());
            //            }

            //            else if (mass[i] == "*")
            //            {
            //                sum = sum + int.Parse(mass[i - 1].ToString()) * int.Parse(mass[i + 1].ToString());
            //            }

            //            else if (mass[i] == "-")
            //            {
            //                sum = sum + int.Parse(mass[i - 1].ToString()) - int.Parse(mass[i + 1].ToString());
            //            }

            //            else if (mass[i] == "%")
            //            {
            //                sum = sum + int.Parse(mass[i - 1].ToString()) % int.Parse(mass[i + 1].ToString());
            //            }
            //        }
            //        mass[i] = sum.ToString();

            //    }

            //    else if (mass[i] == "+")
            //    {
            //        if (sum == 0)
            //        {
            //            sum = int.Parse(mass[i - 1].ToString());
            //        }

            //        if (mass[i + 1] == "(")
            //        {
            //            while (mass[i] != ")")
            //            {
            //                i++;
            //                if (mass[i] == "+")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) + int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "*")
            //                {
            //                    sum = sum + int.Parse(mass[i - 1].ToString()) * int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "-")
            //                {
            //                    sum = sum + int.Parse(mass[i - 1].ToString()) - int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "%")
            //                {
            //                    sum = sum + int.Parse(mass[i - 1].ToString()) % int.Parse(mass[i + 1].ToString());
            //                }
            //            }
            //            sum = sum + sum2;
            //        }
            //        else
            //        {
            //            sum = sum + int.Parse(mass[i + 1].ToString());
            //            mass[i + 1] = sum.ToString();
            //        }
            //    }

            //    else if (mass[i] == "*")
            //    {
            //        if (sum == 0)
            //        {
            //            sum = int.Parse(mass[i - 1].ToString());
            //        }

            //        if (mass[i + 1] == "(")
            //        {
            //            while (mass[i] != ")")
            //            {
            //                i++;
            //                if (mass[i] == "+")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) + int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "*")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) * int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "-")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) - int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "%")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) % int.Parse(mass[i + 1].ToString());
            //                }
            //            }
            //            sum = sum * sum2;
            //        }
            //        else
            //        {
            //            sum = sum * int.Parse(mass[i + 1].ToString());
            //            mass[i + 1] = sum.ToString();
            //        }
            //    }


            //    else if (mass[i] == "-")
            //    {
            //        if (sum == 0)
            //        {
            //            sum = int.Parse(mass[i - 1].ToString());
            //        }

            //        if (mass[i + 1] == "(")
            //        {
            //            while (mass[i] != ")")
            //            {
            //                i++;
            //                if (mass[i] == "+")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) + int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "*")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) * int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "-")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) - int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "%")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) % int.Parse(mass[i + 1].ToString());
            //                }
            //            }
            //            sum = sum - sum2;
            //        }
            //        else
            //        {
            //            sum = sum - int.Parse(mass[i + 1].ToString());
            //            mass[i + 1] = sum.ToString();
            //        }
            //    }

            //    else if (mass[i] == "%")
            //    {
            //        if (sum == 0)
            //        {
            //            sum = int.Parse(mass[i - 1].ToString());
            //        }

            //        if (mass[i + 1] == "(")
            //        {
            //            while (mass[i] != ")")
            //            {
            //                i++;
            //                if (mass[i] == "+")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) + int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "*")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) * int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "-")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) - int.Parse(mass[i + 1].ToString());
            //                }

            //                else if (mass[i] == "%")
            //                {
            //                    sum2 = sum2 + int.Parse(mass[i - 1].ToString()) % int.Parse(mass[i + 1].ToString());
            //                }
            //            }
            //            sum = sum % sum2;
            //        }
            //        else
            //        {
            //            sum = sum % int.Parse(mass[i + 1].ToString());
            //            mass[i + 1] = sum.ToString();
            //        }
            //    }

            //}

            ////Console.WriteLine("{0:0.000}", sum);
            //Console.WriteLine("{0:F3}", sum);
            Console.WriteLine(new string('-',32));
            Console.WriteLine("ZADA4A 5");
            char[,] mass = new char[16, 16];
            char[] mas = new char[16];
            double sum = 0.0;
            for (int i = 0; i < 16; i++)
            {
                string str = Console.ReadLine();
                mas = str.ToCharArray();
                for (int j = 0; j < 16; j++)
			    {
                    mass[i, j] = mas[j];
			    }
            }

            string comand="";
            int row = 0;
            int col = 0;
            do
            {
                int br1=0;
                comand = Console.ReadLine();
                if (comand=="paypal")
                {
                    break;
                }
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
                if (comand=="what is")
                {

                    for (int i = row-1; i <row+2 ; i++)
                    {
                        if (i<0||i>15)
                        {
                            continue;
                        }
                        for (int j = col-1; j < col+2; j++)
                        {
                            if (j<0||j>15)
                            {
                                continue;
                            }
                            if (mass[i, j] == '1') { br1++; }
                        }
                    }
                    if (br1 == 9)
                    {
                        Console.WriteLine("cookie");
                    }
                    else if (br1==1)
                    {

                        Console.WriteLine("cookie crumb");
                    }
                    else if (br1 == 0) { Console.WriteLine("smile"); ; }
                    else { Console.WriteLine("broken cookie"); }
                }

                else if (comand=="buy")
                {
                    for (int i = row - 1; i < row + 2; i++)
                    {
                        if (i < 0 || i > 15)
                        {
                            continue;
                        }
                        for (int j = col - 1; j < col + 2; j++)
                        {
                            if (j < 0 || j > 15)
                            {
                                continue;
                            }
                            if (mass[i, j] == '1') {br1++; }
                        }
                    }
                    if (br1 == 9)
                    {
                        for (int i = row - 1; i < row + 2; i++)
                        {
                            for (int j = col - 1; j < col + 2; j++)
                            {
                                if (mass[i, j] == '1') { mass[i, j] = '0';}
                            }
                        }
                        sum = sum + 1.79;
                    }
                    else if (br1 == 0)
                    {
                        Console.WriteLine("smile");
                    }
                    else { Console.WriteLine("page"); }
                }
            } while (comand!="paypal");
            Console.WriteLine(sum);
        }
    }
}
