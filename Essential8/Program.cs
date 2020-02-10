using Essential8.Essential8_2;
using Essential8.Essential8_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan wait;

            Console.WriteLine("Enter your date of birth in the format 'yyyy, mm, dd'");
            birthday = Convert.ToDateTime(Console.ReadLine());


            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }

            Console.WriteLine("Birthday left {0} days", wait.Days);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the string:");
            string line = Console.ReadLine();

            Console.WriteLine("Specify color: ( 0-blue, 2-green, 1-red)");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(line, color);


            Console.WriteLine(new string('-', 50));


            Console.Write("Enter the number of hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant a = new Accauntant();

            if (a.AskForBonus(Post.Cleaner, hours))
            {
                Console.WriteLine("Give a bonus");
            }
            else
            {
                Console.WriteLine("Do not give out a bonus");
            }

            Console.ReadKey();
        }
    }
}
