using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6.Essential6_1
{
    class Calculator
    {
        static public double Add(double a, double b)
        {
            return a + b;
        }

        static public double Subtraction(double a, double b)
        {
            return a - b;
        }

        static public double Multiply(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a * b;
        }

        static public double Division(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
    }
}
