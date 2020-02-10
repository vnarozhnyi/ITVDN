using Essential11.Essential11_2;
using Essential11.Essential11_3;
using Essential11.Essential11_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11
{
    class MyClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(0.67);
            arrayList.Add('a');
            arrayList.Add("elem");
            arrayList.Add(new MyClass());

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Our fleet of cars:");
            var park = new CarCollection<string>();

            park.AddCar("Lada", new DateTime(1985, 12, 5));
            park.AddCar("Toyota", new DateTime(2000, 4, 7));
            park.AddCar("Ford", new DateTime(2005, 5, 3));
            park.AddCar("Mercedes", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString());

            Console.WriteLine("In the park are: {0} cars", park.Lenght);

            Console.WriteLine("Enter the number of the car you are interested in:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka))
                Console.WriteLine("You have not entered a value. Search failed.");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Dictionary:");

            var dic = new Essential11_3.Dictionary<string, string>();

            dic.AddToDictionary("table", "стол");
            dic.AddToDictionary("apple", "яблоко");
            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("pencil", "карандаш");
            dic.AddToDictionary("cap", "чашка");
            dic.AddToDictionary("tea", "чай");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine("In the dictionary {0} entries", dic.Lenght);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter the entry number in the dictionary:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("You did not enter a dictionary entry number");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]);
            }

            Console.WriteLine("Enter a value to search");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]);


            Console.WriteLine(new string('-', 50));


            MyArrayList m = new MyArrayList();

            m.Add(5);
            m.Add("Hello");
            m.Add('d');
            m.Add(5.78);

            Console.WriteLine("Array:");
            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}
