using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    public class Zad11
    {
        public static string Normalization(string polynomials)
        {
            int brX0=0;
            int brX1=0;
            int brX2=0;
            int brX3=0;

            for (int i = 0; i < polynomials.Length-2; i++)
            {
                if (polynomials[i]=='X'&&polynomials[i+1]=='^'&&polynomials[i+2]=='0')
                {
                    brX0++;
                }
                if (polynomials[i] == 'X' && polynomials[i + 1] == '^' && polynomials[i + 2] == '1')
                {
                    brX1++;
                }
                if (polynomials[i] == 'X' && polynomials[i + 1] == '^' && polynomials[i + 2] == '2')
                {
                    brX2++;
                }
                if (polynomials[i] == 'X' && polynomials[i + 1] == '^' && polynomials[i + 2] == '3')
                {
                    brX3++;
                }
            }

            if (brX3 == 0)
            {
                polynomials = polynomials + "+0X^3";
            }
            if (brX2 == 0)
            {
                polynomials = polynomials + "+0X^2";
            }
            if (brX1 == 0)
            {
                polynomials = polynomials + "+0X^1";
            }
            if (brX0 == 0)
            {
                polynomials = polynomials + "+0X^0";
            }
            return polynomials;
        }

        public static int[] FromPolyToArray(string poly)
        {
            int polyX0 = 0;
            int polyX1 = 0;
            int polyX2 = 0;
            int polyX3 = 0;
            poly = Normalization(poly);
            for (int i = 0; i < poly.Length - 2; i++)
            {
                if (poly[i] == 'X' && poly[i + 1] == '^' && poly[i + 2] == '0')
                {
                    polyX0 = int.Parse(poly[i - 1].ToString());
                }
                if (poly[i] == 'X' && poly[i + 1] == '^' && poly[i + 2] == '1')
                {
                    polyX1 = int.Parse(poly[i - 1].ToString());
                }
                if (poly[i] == 'X' && poly[i + 1] == '^' && poly[i + 2] == '2')
                {
                    polyX2 = int.Parse(poly[i - 1].ToString());
                }
                if (poly[i] == 'X' && poly[i + 1] == '^' && poly[i + 2] == '3')
                {
                    polyX3 = int.Parse(poly[i - 1].ToString());
                }
            }
            int[] rezArray = { polyX0, polyX1, polyX2, polyX3 };
            return rezArray;
        }

        public static int[] AddsPolynoms(int[] polyFirst, int[] polySecond)
        {
            int[] mass = new int[4];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = polyFirst[i] + polySecond[i];
            }
            return mass;
        }

        public static int[] DecPolynoms(int[] polyFirst, int[] polySecond)
        {
            int[] mass = new int[4];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = polyFirst[i] - polySecond[i];
            }
            return mass;
        }

        public static int[] MulPolynoms(int[] polyFirst, int[] polySecond)
        {
            int[] mass = new int[4];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = polyFirst[i] * polySecond[i];
            }
            return mass;
        }
    }
}
