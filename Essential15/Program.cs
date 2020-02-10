using Essential15.Essential15_1;
using Essential15.Essential15_2;
using Essential15.Essential15_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number B");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation");
            string choice = Console.ReadLine();

            Calculator calculator = new Calculator();

            int? result = 0;
            bool calculation = true;
            switch (choice)
            {
                case "+":
                    {
                        result = calculator.Add(operand1, operand2);
                        break;
                    }
                case "-":
                    {
                        result = calculator.Sub(operand1, operand2);
                        break;
                    }
                case "*":
                    {
                        result = calculator.Mul(operand1, operand2);
                        break;
                    }
                case "/":
                    {
                        result = calculator.Div(operand1, operand2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered an invalid value.");
                        Console.ReadKey();
                        calculation = false;
                        break;
                    }
            }

            if (calculation && result != null)
            {
                Console.WriteLine("{0} {1} {2} = {3}", operand1, choice, operand2, result);
            }


            Console.WriteLine(new string('-', 50));


            Company comp = new Company();
            Console.WriteLine(comp[5]);


            Console.WriteLine(new string('-', 50));


            PriceTable priceTable = new PriceTable();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]);
            }

            Console.WriteLine("Enter the item number to search for:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]);

            Console.ReadKey();
        }
    }
}
