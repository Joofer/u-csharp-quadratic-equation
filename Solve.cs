using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u13
{
    class Solve
    {
        private double a, b, c, e;

        public Solve(double A, double B, double C, double E)
        {
            a = A;
            b = B;
            c = C;
            e = E;
        }

        public string Get()
        {
            string str = "";

            if (a != 0)
            {
                if (a != 1 && a != -1)
                    str += a + "x^2 ";
                else if (a == -1)
                    str += "-x^2 ";
                else
                    str += "x^2 ";
            }
            if (b != 0)
            {
                if (b > 0)
                {
                    if (b != 1)
                        str += "+ " + b + "x ";
                    else
                        str += "+ x ";
                }
                else
                {
                    if (b != -1)
                        str += "- " + -b + "x ";
                    else
                        str += "- x ";
                }
            }
            if (c != 0)
            {
                if (c > 0)
                {
                    if (a != 0 || b != 0)
                        str += "+ " + c + " ";
                    else
                        str += c + " !";
                }
                else
                {
                    str += "- " + -c + " ";
                }
            }
            if (a == 0 && b == 0 && c == 0)
            {
                str += "0 ";
            }

            str += "= 0";

            return str;
        }

        public double Discriminant()
        {
            double d;

            d = Math.Pow(b, 2) - 4 * a * c;

            return d;
        }

        public double X1()
        {
            double x;

            if (a != 0)
            {
                if (Discriminant() > 0)
                    x = (-b - Math.Sqrt(Discriminant())) / (2 * a);
                else if (Discriminant() == 0)
                    x = -b / (2 * a);
                else
                    x = Double.NaN;
            }
            else
            {
                if (b != 0)
                {
                    x = -c / b;
                }
                else
                {
                    x = Double.NaN;
                }
            }

            return x;
        }

        public double X2()
        {
            double x;

            if (a != 0)
            {
                if (Discriminant() > 0)
                    x = (-b + Math.Sqrt(Discriminant())) / (2 * a);
                else if (Discriminant() == 0)
                    x = -b / (2 * a);
                else
                    x = Double.NaN;
            }
            else
            {
                if (b != 0)
                {
                    x = -c / b;
                }
                else
                {
                    x = Double.NaN;
                }
            }

            return x;
        }

        public bool Check(double x)
        {
            return (a * Math.Pow(x, 2) + b * x + c <= e) ? true : false;
        }
    };
}
