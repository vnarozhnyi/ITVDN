using Essential10.Essential10_2;
using Essential10.Essential10_3;
using Essential10.Essential10_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential10
{
    class Program
    {
        class MyClass<T> where T : new()
        {
            public static T FacrotyMethod()
            {
                return new T();
            }
        }

        static void Main(string[] args)
        {
            int i = MyClass<int>.FacrotyMethod();

            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.FacrotyMethod();

            Console.WriteLine(p.GetType().Name);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the dimension of the array:");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new Essential10_2.MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Array of elements:");
            for (int x = 0; x < list.Count; x++)
            {
                Console.Write(list[x] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Enter a value to search for:");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("The entered value is contained in an array");
            }
            else
            {
                Console.WriteLine("Value not found!");
            }


            Console.WriteLine(new string('-',50));


            Console.WriteLine("Enter the dictionary dimension:");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int y = 0; y < n; y++)
            {
                dictionary.Add(y, "стол", "table");
            }

            for (int z = 0; z < n; z++)
            {
                Console.WriteLine(dictionary[z]);
            }

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Lenght);


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the dimension of the array:");
            int param = Convert.ToInt32(Console.ReadLine());

            var lists = new Essential10_4.MyList<int>(param);

            var rand = new Random();
            for (int x = 0; x < param; x++)
            {
                lists.Add(x, rand.Next(100));
            }

            Console.WriteLine("Array");
            int[] f = lists.GetArray();   

            for (int q = 0; q < f.Length; q++)
            {
                Console.Write("{0} ", f[q]);
            }

            Console.WriteLine();
            Console.WriteLine("Array Length: {0}", lists.Lenght);

            Console.ReadKey();
        }
    }
}
