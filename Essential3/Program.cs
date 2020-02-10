using Essential3.Essential3_1;
using Essential3.Essential3_2;
using Essential3.Essential3_3;
using Essential3.Essential3_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceColor print = new InheritanceColor(ConsoleColor.Yellow);
            print.Print("Hello");

            Printer printUp = print;
            printUp.Print("Hello");

            InheritanceColor print1 = new InheritanceColor(ConsoleColor.Red);
            print1.Print("Hello");


            Console.WriteLine(new string('-', 50));


            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();

            ClassRoom group = new ClassRoom(p1, p2);

            group.Study();
            group.Read();
            group.Write();
            group.Relax();


            Console.WriteLine(new string('-', 50));


            Ship ship = new Ship(20000, 120, 2000) { Passengers = 28, Port = "Odessa" };

            Console.WriteLine("Ship price {0}, speed {1}, year of manufacture {2}, number of passengers {3}, port of registry {4}", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter Key");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                case "expert":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("Key is incorrect");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
