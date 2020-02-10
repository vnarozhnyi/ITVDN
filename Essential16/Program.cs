using Essential16.Essential16_1;
using Essential16.Essential16_2;
using Essential16.Essential16_3;
using Essential16.Essential16_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential16
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1, 1);
            Point b = new Point(2, 2, 2);

            Point c = a + b;

            Console.WriteLine("The coordinates of point C are equal " + c.X + " " + c.Y + " " + c.Z);


            Console.WriteLine(new string('-', 50));


            Block block1 = new Block(15, 12, 5, 7);
            Block block2 = new Block(7, 12, 5, 15);

            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());

            Console.WriteLine(new string(' ', 30));

            Console.WriteLine("Block1 is equal to block2= {0} ", block1.Equals(block2));

            if (block1.GetHashCode() == block2.GetHashCode())
            {
                Console.WriteLine("The perimeters of the two blocks are equal");
            }
            else
            {
                Console.WriteLine("Block perimeters are not equal");
            }


            Console.WriteLine(new string('-', 50));


            var house = new House(new Street("Sumska"), "Kharkiv");

            House clone;
            clone = house.DeepClone();

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);
            Console.WriteLine(new string('-', 50));

            clone.City = "Odessa";
            clone.Street = new Street("Deribasovskaya");

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);


            Console.WriteLine(new string('-', 50));


            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2012, 12, 4));
            Console.WriteLine(date2.ToString());

            Console.WriteLine(MyDate.Sub(date1, date2).ToString());
            Console.WriteLine(MyDate.Add(date1, date2).ToString());

            Console.ReadKey();
        }
    }
}
