using Essential2.Essential2_1;
using Essential2.Essential2_2;
using Essential2.Essential2_3;
using Essential2.Essential2_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.date.ToString());
            Console.WriteLine(user.Surname);

            user.Surname = "Evans";
            Console.WriteLine(user.Surname);

            User user2 = new User("naya", "Ann", "Kolesnik", 20);
            Console.WriteLine(user2.date.ToString());
            Console.WriteLine(user2.Surname);


            Console.WriteLine(new string('-', 50));


            Converter converter = new Converter(25.03, 27.66, 0.39);

            converter.ToUSD(123);
            converter.FromUSD(123);
            converter.ToEUR(123);
            converter.FromEUR(123);
            converter.ToRUB(123);
            converter.FromRUB(123);


            Console.WriteLine(new string('-', 50));


            Employee employee = new Employee("Smith", "Petr");
            employee.Post = "manager";
            employee.Experience = 1;

            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Post.ToUpper());
            employee.ShowSalary();


            Console.WriteLine(new string('-', 50));


            Invoice inv = new Invoice(678904, "Alex", "Foxtrot") { Article = "USB-hab", Quantity = 6 };

            inv.CostCalculation(true);
            inv.CostCalculation(false);

            Console.ReadKey();
        }
    }
}
