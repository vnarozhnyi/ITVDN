using Proffesional1.Proffesional1_2;
using Proffesional1.Proffesional1_3;
using Proffesional1.Proffesional1_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional1
{
    class Program
    {
        static IEnumerable GetCollection(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] %2 != 0)
                {
                    yield return array[i] * array[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in GetCollection(array))
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 50));


            Calendar calendar = new Calendar();

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetDaysByMonth(5));

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetMonthByDays(30));


            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 50));


            var listInts = new List<string> { "Ivan", "Petya", "Vasiliy", "Andrey" };
            var linkList = MyFamily<string>.CreateList(listInts);

            foreach (var item in linkList.LinkListIterator())
                Console.Write("{0}, ", item);



            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 50));


            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблyко"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
