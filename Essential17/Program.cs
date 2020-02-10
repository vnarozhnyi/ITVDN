using Essential17.Essential17_1;
using Essential17.Essential17_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int operand1 = 20, operand2 = 13;

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, calculator.Add(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, calculator.Sub(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, calculator.Mul(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, calculator.Div(operand1, operand2));


            Console.WriteLine(new string('-', 50));


            var listAuto = new List<Auto>
                               {
                                   new Auto("Fiat", "Bravo", 2005, "red"),
                                   new Auto("Mersedes", "E", 2010, "black"),
                                   new Auto("Skoda", "Fabia", 2009, "yellow"),
                                   new Auto("Mersedes","A", 2009, "grey")
                               };

            foreach (var auto in listAuto)
            {
                Console.WriteLine(auto.ToString());
            }


            Console.WriteLine(new string('-', 50));


            var listCustomer = new List<Customer>
                                   {
                                       new Customer( "Petrov","Mersedes", "0509864578"),
                                       new Customer( "Ivanov", "Fiat", "0509876545"),
                                       new Customer( "Vasiliev", "Skoda", "0504789863")
                                   };

            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.ToString());
            }


            Console.WriteLine(new string('-', 50));


            var query = from auto in listAuto
                        select new { Brand = auto.Brand, Color = auto.Color };

            foreach (var item in query)
            {
                Console.WriteLine("Car Brand: {0}  - {1}", item.Brand, item.Color);
            }


            Console.WriteLine(new string('-', 50));


            var query1 = from customer in listCustomer
                         join auto in listAuto on customer.Model equals auto.Brand
                         select new
                         {
                             Name = customer.Name,
                             Tel = customer.Tel,
                             Model = customer.Model,
                             Color = auto.Color,
                             Brand = auto.Model,
                             Year = auto.Year
                         };


            Console.WriteLine(new string('-', 50));


            foreach (var item in query1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Name, item.Tel, item.Model, item.Brand, item.Color, item.Year);
            }


            Console.WriteLine(new string('-', 50));


            var dictionary = new Dictionary<dynamic, dynamic>
                               {
                                  {new {Key = "table"},    new {Value="стол"}},
                                  {new {Key = "apple"},    new {Value="яблоко"}},
                                  {new {Key = "pen"},      new {Value="ручка"}},
                                  {new {Key = "pencil"},   new {Value="карандаш"}},
                                  {new {Key = "task"},     new {Value="задание"}},
                                  {new {Key = "key"},      new {Value="ключ"}},
                                  {new {Key = "customer"}, new {Value="покупатель"}},
                                  {new {Key = "ship"},     new {Value="корабль"}},
                                  {new {Key = "car"},      new {Value="машина"}},
                                  {new {Key = "cap"},      new {Value="чашка"}}
                               };
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
