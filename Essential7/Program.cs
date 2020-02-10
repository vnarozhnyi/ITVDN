using Essential7.Essential7_1;
using Essential7.Essential7_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential7
{
    class MyNewClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void ClassTaker(MyNewClass c)
        {
            c.change = "changed";
        }

        static void StructTaker(MyStruct s)
        {
            s.change = "changed";
        }
       

        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Show();

            Notebook notebook2 = new Notebook("TT-45", "DELL", 570.99);
            notebook2.Show();

            Notebook notebook3 = new Notebook("RR-34");
            notebook3.Show();

            Console.WriteLine(new string('-', 20));

            var train = new Train[2];

            MyClass.AddingAnArray(train);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("You entered the following train information:");
            Console.WriteLine(new string('-', 50));

            MyClass.Sort(train);
            MyClass.Show(train);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter train number:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 30));
            MyClass.Search(train, poisk);

            Console.WriteLine(new string('-', 20));

            MyNewClass testClass = new MyNewClass();
            MyStruct testStruct = new MyStruct();

            testClass.change = "not changed";
            testStruct.change = "not changed";

            ClassTaker(testClass);
            StructTaker(testStruct);

            Console.WriteLine("Class field = {0}", testClass.change);
            Console.WriteLine("Structure field = {0}", testStruct.change);

            Console.ReadKey();
        }
    }
}
