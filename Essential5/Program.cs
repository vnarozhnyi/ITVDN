using Essential5.Essential5_1;
using Essential5.Essential5_2;
using Essential5.Essential5_3;
using Essential5.Essential5_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);

           

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }


            Console.WriteLine(new string('-', 50));


            MyArray ar = new MyArray(8);

            ar.MinMax();
            ar.Average();
            ar.Odd();


            Console.WriteLine(new string('-', 50));


            MyMatrix m = new MyMatrix(4, 5);
            m.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("[1][2] = {0}", m[1, 2]);
            Console.WriteLine("[6][2] = {0}", m[6, 2]);
            m[0, 0] = 11;

            m.ChengeSize(7, 6);
            m.Show();
            m.ShowPartly(1, 0, 4, 4);


            Console.WriteLine(new string('-', 50));


            Store st = new Store(3);

            st.AddArticle(new Article("Book", "MackMilan", 20.50), 0);
            st.AddArticle(new Article("Apple", "Delight", 5.90), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7.25), 2);

            Console.WriteLine(st["Apple"]);
            Console.WriteLine(st["Dog"]);
            Console.WriteLine(st[2]);
            st.Show();
            st.Sort();
            st.Show();

            Console.ReadKey();
        }
    }
}
