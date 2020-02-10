using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15.Essential15_1
{
    class Calculator
    {
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int? Div(int operand1, int operand2)
        {
            try
            {
                return operand1 / operand2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handling.");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
