using Essential_1.Essential1_2;
using Essential_1.Essential1_3;
using Essential_1.Essential1_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_1
{
    class Program
    {
        static void Main()
        {
            Address address = new Address();

            address.Country = "Ukraine";
            address.City = "Kharkiv";
            address.Street = "Sumska Street";
            address.House = "1";
            address.Apartment = "1";
            address.Index = "11111";

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the first side of the rectangle");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second side of the rectangle");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);

            Console.WriteLine(new string('-', 50));

            string content = "In this chapter, I will introduce information that is fundamental to" +
                                   " working with types and the common language runtime (CLR).";
      
            Book book = new Book("CLR via C#", "Jeffrey Richter", content);
            book.Show();


            Console.WriteLine(new string('-', 50));


            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));

            Console.Write("{0}, P = ", figure.Type);
            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
