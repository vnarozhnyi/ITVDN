using Essential14.Essential14_2;
using Essential14.Essential14_3;
using Essential14.Essential14_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential14
{
    class Program
    {
        static IEnumerable FindEven(int[] arr)
        {
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        yield return arr[i];
            }
            else
            {
                yield break;
            }

        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            IEnumerable res = FindEven(array);
            foreach (int elem in res)
                Console.Write("{0}  ", elem);
            Console.Write("\n");
            Console.ReadKey();

            Essential14_2.MyList<int> list = new Essential14_2.MyList<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            Console.WriteLine("Array Length = {0}", list.Count);

            foreach (int item in list)
                Console.Write("{0}  ", item);


            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 50));


            var dictionary = new MyDictionary<string, string>(5);

            dictionary.Add(0, "стол", "table");
            dictionary.Add(1, "яблоко", "aplle");
            dictionary.Add(2, "карандаш", "pencil");
            dictionary.Add(3, "солнце", "sun");
            dictionary.Add(4, "блокнот", "notepad");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Second entry in the dictionary:");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Dictionary Size:");
            Console.WriteLine(dictionary.Lenght + " words");
            Console.WriteLine(new string('-', 20));


            Console.WriteLine(new string('-', 50));


            Essential14_4.MyList<int> lists = new Essential14_4.MyList<int>();

            for (int i = 0; i < 8; i++)
                list.Add(i);

            int[] arr = lists.GetArray();

            foreach (int t in arr)
                Console.Write("{0}  ", t);

            Console.ReadKey();
        }
    }
}
